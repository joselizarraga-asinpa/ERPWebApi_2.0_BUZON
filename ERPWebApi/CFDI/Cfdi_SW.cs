using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Text;
using SW.Services.Authentication;
using SW.Services.Stamp;
using SW.Services.Cancelation;
using SW.Services.Issue;
using SW.Services.Status;
using SW.Services.Pendings;
using SW.Services.AcceptReject;
using SW.Services.Account;
using SW.Services.Validate;
using SW.Helpers;
using Enumeradores;

namespace ERPWebApi.CFDI
{
    public class Cfdi_SW : CfdiBase, ICfdiPAC
    {
        //Asignación de ambiente de Producción ó Pruebas
        private bool Produccion = true;

        //Variables Publicas
        public CFDIStatus enStatus = CFDIStatus.No_Especificado;
        public CFDICancelable enCancelable = CFDICancelable.No_Especificado;        
        public List<string> lSolPendientes = new List<string>();

        private string url = "";
        private string urlProduction = "https://services.sw.com.mx";
        private string urlTest = "http://services.test.sw.com.mx";        
        private string urlSATTest = "https://srvconsultacfdiuat.cloudapp.net/ConsultaCFDIService.svc";
        private string urlSAT = "https://consultaqr.facturaelectronica.sat.gob.mx/ConsultaCFDIService.svc";
        private Cfdi_SWXml SwXml;
        private StampResponseV4 stampResultV4;
        
        public Cfdi_SW(long _IdDocFiscal, Int16 _IdSucursal = 0)
        {
            url = Produccion ? urlProduction : urlTest;
            base.Response = "";
            base.Xml = "";            
            base.IdDocFiscal = _IdDocFiscal;            
            if (base.LeeCfdiEncabezado() || _IdSucursal > 0)
            {
                if (CargaDatosSucursal(_IdSucursal > 0 ? _IdSucursal : base.eCfdiEnc.IDSUCURSAL
                                , Enumeradores.SucursalConfigValores.TimbradoSW_user.ToString().ToUpper()
                                , Enumeradores.SucursalConfigValores.TimbradoSW_pwd.ToString().ToUpper()))
                {
                    if (base.User != "" && base.Password != "")
                    {
                        SwXml = new Cfdi_SWXml(_IdDocFiscal, base.User, base.Password, url);
                    }
                    else
                        Response = "No Existen Datos de Configuración de Usuario y Password de Timbrado en la Sucursal del Documento";
                }
            }
        }
        
        public bool GetStatusCFDI()
        {
            bool ret = false;            
            enStatus = CFDIStatus.NoEncontrado;
            Status status = new Status(Produccion ? urlSAT : urlSATTest);
            var response = status.GetStatusCFDI(base.eCfdiEnc.EMISORRFC, base.eCfdiEnc.RECEPTORRFC, base.eCfdiEnc.TOTAL.ToString(), base.eCfdiEnc.FOLIOFISCAL);
            Response = "Estado SAT: " + response.Estado + ", " + response.EsCancelable + (response.EstatusCancelacion != "" ?", Estatus de Cancelacion: " + response.EstatusCancelacion:"");
            switch (response.Estado)
            {
                case "Vigente":
                    enStatus = CFDIStatus.Vigente;
                    ret = true;
                    break;
                case "Cancelado":
                    enStatus = CFDIStatus.Cancelado;
                    ret = true;
                    break;
                default:
                    if (response.EstatusCancelacion.Contains("Cancelado") || response.EstatusCancelacion.Contains("Plazo vencido"))
                        enStatus = CFDIStatus.Cancelado;
                    else if (response.CodigoEstatus.Contains("602"))
                        enStatus = CFDIStatus.NoEncontrado;
                    else if (response.CodigoEstatus.Contains("601"))
                        enStatus = CFDIStatus.ExpresionNoValida;                    
                    ret = true;
                    break;
            }
            if (ret)
            {
                if (response.EstatusCancelacion == "En proceso")
                    enStatus = CFDIStatus.En_proceso;
                else if (!(response.EstatusCancelacion.Contains("Cancelado") || response.EstatusCancelacion.Contains("Plazo vencido")))
                {
                    if (Enum.TryParse(response.Estado, out enStatus))
                    {
                        if (!Enum.IsDefined(typeof(CFDIStatus), enStatus))
                            enStatus = CFDIStatus.ExpresionNoValida;
                    }
                    else
                        enStatus = CFDIStatus.ExpresionNoValida;
                }
                if (Enum.TryParse(response.EsCancelable.ToLower().Replace(" ", "_"), out enCancelable))
                {
                    if (!Enum.IsDefined(typeof(CFDICancelable), enCancelable))
                        enCancelable = CFDICancelable.ExpresionNoValida;
                }
                else
                    enCancelable = CFDICancelable.ExpresionNoValida;
                GuardaTimbradoLog(Enumeradores.LogAction.Status, Response, base.eCfdiEnc.FOLIOFISCAL);
                if (base.LeeCfdiStatusBuzon())
                {
                    if (base.eCfdiStatusBuzon.STATUS != enStatus.GetHashCode())                    
                        GuardarCFDIStatusBuzon(Funciones.StringToInt16(enStatus.GetHashCode().ToString()));                    
                }
            }
            else
            {
                enCancelable = CFDICancelable.No_Especificado;
            }
            return ret;
        }

        public bool CancelCFDI()
        {
            bool ret = false;
            HasError = false;            
            try
            {
                if (SwXml == null)
                {
                    Response = "No Existen Datos de Configuración de Usuario y Password de Timbrado";
                    return false;
                }                                
                if (base.eCfdiEnc.IDDOCFISCAL > 0)
                {
                    if (base.eCfdiEnc.FOLIOFISCAL != "")
                    {
                        if (GetStatusCFDI())
                        {
                            if (enStatus == CFDIStatus.Vigente
                                || (enCancelable == CFDICancelable.cancelable_con_aceptación
                                 || enCancelable == CFDICancelable.cancelable_sin_aceptación))
                            {
                                Cancelation cancelation = new Cancelation((Produccion ? urlProduction : urlTest), base.User, base.Password);
                                var response = cancelation.CancelarByRfcUuid(base.eCfdiEnc.EMISORRFC, base.eCfdiEnc.FOLIOFISCAL);
                                if (response.status == "success")
                                {
                                    Task.Delay(5000); //Esperar 5 segundos para darle tiempo al PAC y al SAT
                                    GetStatusCFDI();
                                    ret = true;
                                }
                                else
                                {
                                    HasError = true;
                                    Response = response.status;
                                }
                                GuardaTimbradoLog(Enumeradores.LogAction.Cancelar, response.status, base.eCfdiEnc.FOLIOFISCAL);
                            }
                            else
                            {
                                if (enStatus == CFDIStatus.Cancelado)
                                {
                                    ret = true;
                                }
                                else
                                {
                                    HasError = true;
                                    Response = "El CFDI No Es Cancelable, Consulte su Estatus";
                                    GuardaTimbradoLog(Enumeradores.LogAction.Cancelar, Response, base.eCfdiEnc.FOLIOFISCAL);
                                }
                            }
                        }
                    }
                    else
                    {
                        HasError = true;
                        Response = "El Documento Fiscal a Cancelar No está Timbrado. " + Environment.NewLine + Response;
                    }
                }
                else
                {
                    HasError = true;
                    Response = "No Existe Documento Fiscal. " + Environment.NewLine + Response;
                }
            }
            catch (Exception ex)
            {
                HasError = true;
                Response = ex.Message;
            }
            return ret;
        }
                
        public bool GetCFDI()
        {
            bool ret = false;            
            IdCfdi = 0;
            Xml = "";
            XmlATimbrar = "";
            HasError = false;
            Response = "";            
            if(base.LeeCfdiStatus())
            {
                switch(base.eCfdiStatus.STATUS)
                {
                    case 0:     //no es CFDI
                        HasError = true;
                        Response = "El documento no corresponde a un CFDI. Revise que el RFC del documento esté correcto";
                        break;
                    case 1:     //Ya Timbrado                        
                        if (base.LeeCfdiXml())
                        {
                            Xml = base.eXml.ARCHIVOXML;
                            Response = base.eXml.ARCHIVOXML;
                            ret = true;
                        }
                        else
                        {
                            HasError = true;
                            Response += "No existe Archivo XML";
                        }
                        break;
                    case 2:     //Por Timbrar
                        ret = Timbrar();
                        break;
                }
            }
            return ret;
        }
        
        private bool Timbrar()
        {
            bool ret = false;
            HasError = false;
            try
            {
                if (SwXml == null)
                {
                    Response = "No Existen Datos de Configuración de Usuario y Password de Timbrado";
                    return false;
                }
                if (TimbrarV4(SwXml.GetXML()))
                {
                    GuardaTimbradoLog(Enumeradores.LogAction.Timbrar, stampResultV4.status, stampResultV4.data.uuid);
                    ActualizaDocFiscal(Enumeradores.LogAction.Timbrar, stampResultV4.data.uuid, DateTime.Parse(stampResultV4.data.fechaTimbrado));
                    HasError = !this.GuardarCFDI();
                    ret = true;
                }
                else
                {
                    HasError = true;
                    if (stampResultV4.data != null)
                    {
                        GuardaTimbradoLog(Enumeradores.LogAction.Timbrar, stampResultV4.status, stampResultV4.data.uuid);
                        GuardaCFDITemp();
                    }                    
                        
                }
            }
            catch (Exception ex)
            {
                HasError = true;
                Response += ex.Message;
            }
            return ret;
        }

        private bool GuardarCFDI()
        {            
            Entidades.Cfdi eCfdi = new Entidades.Cfdi();
            eCfdi.IDDOCFISCAL = IdDocFiscal;
            eCfdi.VERSION = "1.1";
            eCfdi.USUARIO = base.eCfdiEnc.USUARIO;
            eCfdi.FEEMISION = base.eCfdiEnc.FECHA;
            eCfdi.SERIE = base.eCfdiEnc.SERIE;
            eCfdi.NODOCUMENTO = stampResultV4.data.uuid;
            eCfdi.CADENAORIGINAL = stampResultV4.data.cadenaOriginalSAT;
            eCfdi.FETIMBRADO = DateTime.Parse(stampResultV4.data.fechaTimbrado);
            eCfdi.CEREMISOR = stampResultV4.data.noCertificadoCFDI;
            eCfdi.CERSAT = stampResultV4.data.noCertificadoSAT;
            eCfdi.SELLODIGITAL = stampResultV4.data.selloCFDI;
            eCfdi.SELLODIGITALSAT = stampResultV4.data.selloSAT;
            eCfdi.QR = Encoding.ASCII.GetBytes(stampResultV4.data.qrCode);            
            eCfdi.XML = stampResultV4.data.cfdi;
            Xml = stampResultV4.data.cfdi;
            return base.GuardarCFDI(eCfdi);
        }

        public bool SolicitudesPendientes()
        {
            bool ret = false;
            HasError = false;
            lSolPendientes = new List<string>();
            try
            {
                if (SwXml == null)
                {
                    Response = "No Existen Datos de Configuración de Usuario y Password de Timbrado";
                    return false;
                }
                if (base.RFC != "")
                {
                    Pending pendientes = new Pending((Produccion ? urlProduction : urlTest), base.User, base.Password);
                    PendingsResponse response = pendientes.PendingsByRfc(base.RFC);
                    Response = response.status;
                    lSolPendientes = response.data.uuid;
                    if (response.status == "success")
                    {                        
                        ret = true;                        
                    }
                    else
                    {
                        HasError = true;
                        Response += ". " + response.messageDetail;
                    }
                    GuardaTimbradoLog(Enumeradores.LogAction.SolicitudesPendientes, response.status, base.eCfdiEnc.EMISORRFC);
                }
                else
                {
                    HasError = true;
                    Response = "Hace falta configurar el RFC del Emisor. " + Environment.NewLine + Response;
                }
            }
            catch (Exception ex)
            {
                HasError = true;
                Response = ex.Message;
            }
            return ret;
        }

        public bool AceptarRechazarCFDI(string UUID, EnumAcceptReject enAceptarRechazar)
        {
            bool ret = false;
            HasError = false;
            try
            {
                if (SwXml == null)
                {
                    Response = "No Existen Datos de Configuración de Usuario y Password de Timbrado";
                    return false;
                }
                if (UUID == "" && base.eCfdiEnc.FOLIOFISCAL != "")
                    UUID = base.eCfdiEnc.FOLIOFISCAL;
                if (UUID != "")
                {
                    AcceptReject acceptReject = new AcceptReject((Produccion ? urlProduction : urlTest), base.User, base.Password);
                    var response = acceptReject.AcceptByRfcUuid(base.RFC, UUID, enAceptarRechazar);
                    if (response.status == "success")
                    {
                        ret = true;
                    }
                    else
                    {
                        HasError = true;
                        Response = response.status;
                    }
                    GuardaTimbradoLog(Enumeradores.LogAction.AceptarRechazar, enAceptarRechazar.GetHashCode() + " - " + response.status, UUID);
                }
                else
                {
                    HasError = true;
                    Response = "El Documento Fiscal a Cancelar No está Timbrado. " + Environment.NewLine + Response;
                }
            }
            catch (Exception ex)
            {
                HasError = true;
                Response = ex.Message;
            }
            return ret;
        }

        public bool SaldoTimbres()
        {
            bool ret = false;
            try
            {                
                BalanceAccount account = new BalanceAccount((Produccion ? urlProduction : urlTest), base.User, base.Password);
                var response = account.ConsultarSaldo();
                if (response.status == "success")
                {
                    Response = response.data.saldoTimbres.ToString();
                    ret = true;
                }                
            }
            catch (Exception ex)
            {
                HasError = true;
                Response = ex.Message;
            }
            return ret;
        }

        public bool ValidaRFC(string rfc)
        {
            bool ret = false;
            try
            {                                                           
                Validate validate = new Validate((Produccion ? urlProduction : urlTest), base.User, base.Password);
                ValidateLrfcResponse response = validate.ValidateLrfc(rfc);
                ret = response.status == "success" && response.data.contribuyenteRFC == rfc;                
                Response = response.data.contribuyenteRFC;
            }
            catch (Exception ex)
            {
                HasError = true;
                Response = ex.Message;
            }
            return ret;
        }

        public bool ValidaXML(string xml)
        {
            bool ret = false;
            try
            {                
                Validate validate = new Validate((Produccion ? urlProduction : urlTest), base.User, base.Password);
                //var xml = GetXml(build);
                ValidateXmlResponse response = validate.ValidateXml(xml.ToString());
                if (response.status == "success" && !string.IsNullOrEmpty(response.statusCodeSat))
                {
                    ret = true;
                    Response = response.messageDetail;
                }
                else
                    Response = "N - 601: La expresión impresa proporcionada no es válida.";
            }
            catch (Exception ex)
            {
                HasError = true;
                Response = ex.Message;
            }
            return ret;
        }

        #region Funciones de Timbrado

        private string TimbrarV1(string xmlInfo)
        {
            /* 1- Timbrar con versión V1
            * Esta versión te regresa solo el TFD de la factura (cfdi) que mandaste a timbrar. 
            * Timbrar CFDI recibe un comprobante sellado en formato string o en su defecto en bytes, 
            * posteriormente retorna el complemento Timbre Fiscal Digital (TFD) correspondiente 
            * al xml que se mando a timbrar ó en su defecto retorna una excepción detallando el error de validación.
            */
            string Result = "";
            Result = "Timbrado V1\n";            
            Issue issue = new Issue(url, base.User, base.Password);
            StampResponseV1 stampResult;
            try
            {
                Convert.FromBase64String(xmlInfo);
                stampResult = issue.TimbrarV1(xmlInfo,true);
            }
            catch
            {
                stampResult = issue.TimbrarV1(xmlInfo);
            }
            if (stampResult.status == "success")
            {
                HasError = false;
                Result += "Respuesta del Timbrado\n\n";
                Result += "CFDI+TFD:" + stampResult.data.tfd + "\n";
            }
            else
            {
                HasError = true;
                Result += "Error al timbrar\n\n";
                Result += stampResult.message + " : " + stampResult.messageDetail + "\n";
            }
            return Result;
        }

        private string TimbrarV2(string xmlInfo)
        {
            /* 2- Timbrar con versión V2                                    
            * Esta versión regresa el TFD y el CFDI 
            * Timbrar CFDI recibe un comprobante sellado en formato string o en su defecto en bytes,
            * posteriormente retorna el complemento Timbre Fiscal Digital (TFD) correspondiente al 
            * xml que se mando a timbrar ó en su defecto retorna una excepción detallando el error de validación.
            * */
            string Result = "";
            Result += "Timbrado V2\n";
            Issue issue = new Issue(url, base.User, base.Password);
            StampResponseV2 stampResult;
            try
            {
                Convert.FromBase64String(xmlInfo);
                stampResult = issue.TimbrarV2(xmlInfo, true);
            }
            catch
            {
                stampResult = issue.TimbrarV2(xmlInfo);
            }
            if (stampResult.status == "success")
            {
                Result += "Respuesta del Timbrado\n\n";
                Result += "TFD:" + stampResult.data.tfd + "\n";
                Result += "CFDI:" + stampResult.data.cfdi + "\n";
            }
            else
            {
                Result += "Error al timbrar\n\n";
                Result += stampResult.message + " : " + stampResult.messageDetail + "\n";
            }
            return Result;
        }

        private string TimbrarV3(string xmlInfo)
        {
            /* 3- Timbrar con versión V3
            * Esta versión regresa el CFDI y el TFD ya unidos Timbrar CFDI recibe un comprobante sellado 
            * en formato string o en su defecto en bytes, posteriormente retorna el complemento Timbre Fiscal 
            * Digital (TFD) correspondiente al xml que se mando a timbrar ó en su defecto retorna una excepción 
            * detallando el error de validación.
            */
            string Result = "";
            Result += "Timbrado V3\n";
            Issue issue = new Issue(url, base.User, base.Password);
            StampResponseV3 stampResult;
            try
            {
                Convert.FromBase64String(xmlInfo);
                stampResult = issue.TimbrarV3(xmlInfo, true);
            }
            catch
            {
                stampResult = issue.TimbrarV3(xmlInfo);
            }
            if (stampResult.status == "success")
            {
                Result += "Respuesta del Timbrado\n\n";
                Result += "CFDI:" + stampResult.data.cfdi + "\n";
            }
            else
            {
                Result += "Error al timbrar\n\n";
                Result += stampResult.message + " : " + stampResult.messageDetail + "\n";
            }
            return Result;
        }

        private bool TimbrarV4(string xmlInfo)
        {
            /* 4- Timbrar con versión V4 
            * Esta versión regresa el CFDI, TFD, CadenaOriginal, noCertificadoSat, noCertificadoCFDI, 
            * UUID, selloSAT, selloCFDI, fechaTimbrado y QR Timbrar CFDI recibe un comprobante sellado
            * en formato string o en su defecto en bytes, posteriormente retorna el complemento Timbre
            * Fiscal Digital (TFD) correspondiente al xml que se mando a timbrar ó en su defecto retorna
            * una excepción detallando el error de validación.
            */
            bool ret = false;
            Response += "Timbrado V4";
            HasError = true;
            Issue issue = new Issue(url, base.User, base.Password);
            stampResultV4 = new StampResponseV4();
            try
            {
                Convert.FromBase64String(xmlInfo);
                XmlATimbrar = xmlInfo;
                stampResultV4 = issue.TimbrarV4(xmlInfo, true);
            }
            catch
            {
                XmlATimbrar = xmlInfo;
                stampResultV4 = issue.TimbrarV4(xmlInfo);
            }            
            if (stampResultV4.status == "success")
            {
                ret = true;
                HasError = false;
                base.Xml = stampResultV4.data.cfdi;
                Response += "Respuesta del Timbrado\n\n";
                Response += "CFDI:" + stampResultV4.data.cfdi + "\n";
                Response += "Cadena Original SAT:" + stampResultV4.data.cadenaOriginalSAT + "\n";
                Response += "Fecha de Timbrado:" + stampResultV4.data.fechaTimbrado + "\n";
                Response += "Número de Certificado CFDI:" + stampResultV4.data.noCertificadoCFDI + "\n";
                Response += "Número de Certificado SAT:" + stampResultV4.data.noCertificadoSAT + "\n";
                Response += "qrCode:" + stampResultV4.data.qrCode + "\n";
                Response += "Sello CFDI:" + stampResultV4.data.selloCFDI + "\n";
                Response += "Sello SAT:" + stampResultV4.data.selloSAT + "\n";
                Response += "UUID:" + stampResultV4.data.uuid + "\n";                
            }
            else
            {
                HasError = true;
                base.Xml = "";
                Response += "Error al timbrar\n\n";
                Response += stampResultV4.message + " : " + stampResultV4.messageDetail + "\n";
            }
            return ret;
        }

        #endregion
        
        #region Pruebas

        public bool PruebaTimbrado(string option)
        {
            HasError = true;
            Response = "";
            try
            {
                string xmlInfo = string.Empty;
                switch (option)
                {
                    case "1":                       
                        //xmlInfo = GetXmlFile(_pathXmlFile);                            
                        Response = TimbrarV1(SwXml.GetInvoiceDemo());
                        break;
                    case "2":                        
                        //xmlInfo = GetXmlFile(_pathXmlFile);
                        Response = TimbrarV2(SwXml.GetInvoiceDemo());
                        break;
                    case "3":                        
                        //xmlInfo = GetXmlFile(_pathXmlFile);
                        Response = TimbrarV3(SwXml.GetInvoiceDemo());
                        break;
                    case "4":                        
                        //xmlInfo = GetXmlFile(_pathXmlFile);
                        TimbrarV4(SwXml.GetInvoiceDemo());
                        break;
                    case "5":   //5- Autenticación
                                //xmlInfo = GetXmlFile(_pathXmlFile);
                                //Response = Autenticacion();
                        break;
                    case "6":   //6- Cambiar de Formato de timbrado (XML/B64)
                        xmlInfo = GetXmlFile(SwXml.GetInvoiceDemo());
                        break;
                    case "7":   //7- Cancelar PFX
                                //Response = CancelarPFX();
                        break;
                    case "8":   //8- Cancelar CSD
                                //Response = CancelarCSD();
                        break;
                    case "s":   //s- Salir
                        Response = Response = "Aplicación finalizada.....";
                        break;
                    default:
                        Response = "Opción no válida.";
                        break;
                }
            }
            catch (Exception ex)
            {
                HasError = true;
                Response = ex.Message;
            }
            return !HasError;
        }

        private static string GetXmlFile(string path)
        {
            string Result = "";
            //Result += "Seleccione el formato del timbrado.\n1- Formato XML\n2- Formato B64\n");            
            bool b64 = false;
            string xmlText = string.Empty;
            try
            {
                xmlText = File.ReadAllText(path, Encoding.UTF8);
                return b64 ? System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(xmlText)) : xmlText;
            }
            catch (Exception ex)
            {
                Result += "Error al obtener la información del xml: " + ex.Message;
                return Result;
            }
        }

        #endregion

        #region Codigo Comentado

        //private static string CancelarPFX()
        //{
        //    string Result = "";
        //    byte[] pfx = File.ReadAllBytes(Path.Combine(@"ArchivosPrueba", "CSD_Prueba_CFDI_LAN8507268IA.pfx"));
        //    string pfxB64 = Convert.ToBase64String(pfx);
        //    string uuid = "01724196-ac5a-4735-b621-e3b42bcbb459";
        //    string rfc = "LAN8507268IA";
        //    string passwordKey = "12345678a";
        //    Cancelation cancelation = new Cancelation(url, user, password);
        //    CancelationResponse response = (CancelationResponse)cancelation.CancelarByPFX(pfxB64, rfc, passwordKey, uuid);
        //    if (response.status == "success" && response.data != null)
        //    {
        //        //Acuse de cancelación
        //        Result += response.data.acuse + "\n";
        //        //Estatus por UUID
        //        foreach (var folio in response.data.uuid)
        //        {
        //            Result += "UUID: " + folio.Key + " Estatus: "+ folio.Value + "\n";
        //        }
        //    }
        //    else
        //    {
        //        Result += "Error al Cancelar\n\n";
        //        Result += response.message + "\n";
        //        Result += response.messageDetail + "\n";
        //    }
        //    return Result;
        //}
        //private static string CancelarCSD()
        //{
        //    string Result = "";
        //    byte[] csd_key = File.ReadAllBytes(Path.Combine(@"ArchivosPrueba", "CSD_Prueba_CFDI_LAN8507268IA.key"));
        //    byte[] csd_cer = File.ReadAllBytes(Path.Combine(@"ArchivosPrueba", "CSD_Prueba_CFDI_LAN8507268IA.cer"));
        //    string csd_key_B64 = Convert.ToBase64String(csd_key);
        //    string csd_cer_B64 = Convert.ToBase64String(csd_cer);
        //    string uuid = "01724196-ac5a-4735-b621-e3b42bcbb459";
        //    string rfc = "LAN8507268IA";
        //    string passwordKey = "12345678a";
        //    Cancelation cancelation = new Cancelation(url, user, password);
        //    CancelationResponse response = (CancelationResponse)cancelation.CancelarByCSD(csd_cer_B64, csd_key_B64, rfc, passwordKey, uuid);
        //    if (response.status == "success" && response.data != null)
        //    {
        //        //Acuse de cancelación
        //        Result += response.data.acuse + "\n";
        //        //Estatus por UUID
        //        foreach (var folio in response.data.uuid)
        //        {
        //            Result += "UUID: " + folio.Key + " Estatus: " + folio.Value + "\n";
        //        }
        //    }
        //    else
        //    {
        //        Result += "Error al Cancelar\n\n";
        //        Result += response.message + "\n";
        //        Result += response.messageDetail + "\n";
        //    }
        //    return Result;
        //}

        //public void Issue_Test_45_IssueXMLV1()
        //{
        //    var build = new BuildSettings();
        //    SW.Services.Issue.Issue issue = new SW.Services.Issue.Issue(build.Url, build.User, build.Password);
        //    var xml = GetXml(build);
        //    var response = (StampResponseV1)issue.TimbrarV1(xml);//
        //    Assert.IsTrue(response.status == "success"
        //        && !string.IsNullOrEmpty(response.data.tfd), "El resultado data.tfd viene vacio.");
        //}


        //private static string Autenticacion()
        //{
        //    string Result = "";            
        //    Authentication swAutentication = new Authentication(url, user, password);
        //    AuthResponse authResponse = swAutentication.GetToken();
        //    if (authResponse.status == "success")
        //    {
        //        Result = "Se ha autenticado de manera correcta Token:" + authResponse.data.token + "\n";
        //    }
        //    else
        //    {
        //        Result = "Error en la autenticación" + authResponse.message + " : " + authResponse.messageDetail + "\n";
        //    }
        //    return Result;
        //}

        #endregion

    }
}
