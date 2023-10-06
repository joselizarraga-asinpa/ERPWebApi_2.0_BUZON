using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ERPWebApi.DAL;

namespace ERPWebApi.CFDI
{
    public class CfdiBase
    {
        private bool _HasError;
        private string _Response;
        private string _Xml;

        protected string XmlATimbrar = "";
        protected string User = "";   //"contacto@wallacesoftware.com.mx";  
        protected string Password = ""; //"Test.1234";
        protected string RFC = "";
        protected long IdDocFiscal;
        protected long IdCfdi;

        protected Entidades.CFDIEncabezado eCfdiEnc = new Entidades.CFDIEncabezado();
        protected Entidades.CFDIStatus eCfdiStatus = new Entidades.CFDIStatus();
        protected Entidades.CFDIStatusBuzon eCfdiStatusBuzon = new Entidades.CFDIStatusBuzon();        
        protected Entidades.CfdiComplemento eComp = new Entidades.CfdiComplemento();
        protected Entidades.Xml eXml = new Entidades.Xml();        

        protected List<Entidades.CFDIDet> lCfdiDet = new List<Entidades.CFDIDet>();
        protected List<Entidades.CFDIRelacion> lCfdiRel = new List<Entidades.CFDIRelacion>();
        protected List<Entidades.CFDIPagos> lCfdiPagos = new List<Entidades.CFDIPagos>();
        protected List<Entidades.CFDIPagosDocs> lCfdiPagosDocs = new List<Entidades.CFDIPagosDocs>();
        protected List<Entidades.SucursalConfig> lSucursalConfig = new List<Entidades.SucursalConfig>();

        public CfdiBase()
        {
        }

        public bool HasError
        {
            get { return _HasError; }
            set
            {
                _HasError = value;
            }
        }

        public string Response
        {
            get { return _Response; }
            set
            {
                _Response = value;
            }
        }

        public string Xml
        {
            get { return _Xml; }
            set
            {
                _Xml = value;
            }
        }

        #region Funciones de Lectura

        protected bool CargaDatosSucursal(Int16 IdSucursal, string VariableUsuario, string VariablePwd)
        {
            bool ret = false;
            lSucursalConfig = Datos.Consultar<Entidades.SucursalConfig>(new Entidades.SucursalConfig()
            {
                ID = 0,
                IDSUCURSAL = IdSucursal
            },
            new List<object>().ToArray()
            );
            if (lSucursalConfig.Count == 0)
                _Response = "No Existen Datos de Configuración de la Sucursal";
            else
            {
                foreach (Entidades.SucursalConfig sc in lSucursalConfig)
                {
                    if (sc.VARIABLE.ToUpper() == VariableUsuario)
                        User = sc.VALOR;
                    if (sc.VARIABLE.ToUpper() == VariablePwd)
                        Password = sc.VALOR;
                    if (sc.VARIABLE.ToUpper() == Enumeradores.SucursalConfigValores.TimbradoRFC.ToString().ToUpper())
                        RFC = sc.VALOR;
                }
                ret = true;
            }
            return ret;
        }

        protected bool LeeCfdiEncabezado()
        {
            eCfdiEnc = new Entidades.CFDIEncabezado();
            List<Entidades.CFDIEncabezado> lCfdiEnc = Datos.Consultar<Entidades.CFDIEncabezado>(new Entidades.CFDIEncabezado() { IDDOCFISCAL = IdDocFiscal }, new List<object>().ToArray());
            if (lCfdiEnc.Count > 0)
                eCfdiEnc = lCfdiEnc[0];
            return lCfdiEnc.Count > 0;
        }

        protected bool LeeCfdiStatus()
        {
            eCfdiStatus = new Entidades.CFDIStatus();
            List<Entidades.CFDIStatus> lCfdiGetStatus = Datos.Consultar<Entidades.CFDIStatus>(new Entidades.CFDIStatus() { IDDOCFISCAL = IdDocFiscal }, new List<object>().ToArray());
            if (lCfdiGetStatus.Count > 0)
                eCfdiStatus = lCfdiGetStatus[0];
            return lCfdiGetStatus.Count > 0;
        }

        protected bool LeeCfdiStatusBuzon()
        {
            eCfdiStatusBuzon = new Entidades.CFDIStatusBuzon();
            List<Entidades.CFDIStatusBuzon> lCfdiGetStatusBuzon = Datos.Consultar<Entidades.CFDIStatusBuzon>(new Entidades.CFDIStatusBuzon() { IDDOCFISCAL = IdDocFiscal }, new List<object>().ToArray());
            if (lCfdiGetStatusBuzon.Count > 0)
                eCfdiStatusBuzon = lCfdiGetStatusBuzon[0];
            return lCfdiGetStatusBuzon.Count > 0;
        }

        protected bool LeeCfdiXml()
        {
            eXml = new Entidades.Xml();
            List<Entidades.Xml> lXml = Datos.Consultar<Entidades.Xml>(new Entidades.Xml() { IDDOCFISCAL = IdDocFiscal }, new List<object>().ToArray(), Conexiones.SqlServer.conexionTimbrado);
            if (lXml.Count > 0)
                eXml = lXml[0];
            return lXml.Count > 0;
        }

        protected bool LeeCfdiDet()
        {
            lCfdiDet = Datos.Consultar<Entidades.CFDIDet>(new Entidades.CFDIDet() { IDDOCFISCAL = IdDocFiscal }, new List<object>().ToArray());
            return lCfdiDet.Count > 0;
        }

        protected bool LeeCfdiRelacion()
        {
            lCfdiRel = new List<Entidades.CFDIRelacion>();
            lCfdiRel = Datos.Consultar<Entidades.CFDIRelacion>(new Entidades.CFDIRelacion() { IDDOCFISCAL = IdDocFiscal }, new List<object>().ToArray());            
            return lCfdiRel.Count > 0;
        }

        protected bool LeeCfdiPagos()
        {
            lCfdiPagos = Datos.Consultar<Entidades.CFDIPagos>(new Entidades.CFDIPagos() { IDDOCFISCAL = IdDocFiscal }, new List<object>().ToArray());
            return lCfdiPagos.Count > 0;
        }

        protected bool LeeCfdiPagosDocs(long IdPago)
        {
            lCfdiPagosDocs = Datos.Consultar<Entidades.CFDIPagosDocs>(new Entidades.CFDIPagosDocs() { IDPAGO = IdPago }, new List<object>().ToArray());
            return lCfdiPagosDocs.Count > 0;
        }

        protected bool LeeCfdiComplemento()
        {
            eComp = new Entidades.CfdiComplemento();
            List<Entidades.CfdiComplemento> lComp = Datos.Consultar<Entidades.CfdiComplemento>(new Entidades.CfdiComplemento() { IDDOCFISCAL = IdDocFiscal }, new List<object>().ToArray());
            if (lComp.Count > 0)
                eComp = lComp[0];
            return lComp.Count > 0 && eComp.XML != "" ;
        }

        #endregion

        #region Funciones de Guardado

        protected bool GuardarCFDICancel()
        {
            bool ret = false;
            Entidades.CfdiCancel eCfdiCancel = new Entidades.CfdiCancel();
            eCfdiCancel.IDDOCFISCAL = IdDocFiscal;
            string Res = Datos.Nuevo<Entidades.CfdiCancel>(eCfdiCancel, null, Enumeradores.TypeAction.None);
            IdCfdi = Funciones.StringToLong(Res);
            if (IdCfdi > 0)
                ret = true;
            else
            {
                _Response = "La cancelación del Cfdi NO pudo ser Guardada pero se Timbró la Cancelación."
                        + Environment.NewLine + "IMPORTANTE: Copie este mensaje completo y reporte a su proveedor de sistemas."
                        + Environment.NewLine
                        + Environment.NewLine
                        + Res
                        + Environment.NewLine
                        + Environment.NewLine
                        + _Response;
            }
            return ret;
        }

        protected bool GuardarCFDIStatusBuzon(Int16 status)
        {
            bool ret = false;
            Entidades.CFDIGuardaStatusBuzon eCFDIGuardaStatusBuzon = new Entidades.CFDIGuardaStatusBuzon();
            eCFDIGuardaStatusBuzon.IDDOCFISCAL = IdDocFiscal;
            eCFDIGuardaStatusBuzon.STATUS = status;
            string Res = Datos.Nuevo<Entidades.CFDIGuardaStatusBuzon>(eCFDIGuardaStatusBuzon, null, Enumeradores.TypeAction.None);
            IdCfdi = Funciones.StringToLong(Res);
            if (IdCfdi > 0)
                ret = true;
            else
            {
                if (status == 2)   //Cancelación
                {
                    _Response = "La cancelación del Cfdi NO pudo ser Guardada pero se Timbró la Cancelación."
                            + Environment.NewLine + "IMPORTANTE: Copie este mensaje completo y reporte a su proveedor de sistemas."
                            + Environment.NewLine
                            + Environment.NewLine
                            + Res
                            + Environment.NewLine
                            + Environment.NewLine
                            + _Response;
                }
                else
                    _Response = Res;
            }
            return ret;
        }

        protected virtual bool GuardarCFDI(Entidades.Cfdi eCfdi)
        {
            bool ret = false;
            string Res = Datos.Nuevo<Entidades.Cfdi>(eCfdi, null, Enumeradores.TypeAction.None, Conexiones.SqlServer.conexionTimbrado);
            IdCfdi = Funciones.StringToLong(Res);
            if (IdCfdi > 0)
                ret = true;
            else
            {
                _Response = "El Cfdi NO pudo ser Guardado pero se Timbró con el UUID [" + eCfdi.NODOCUMENTO + "]."
                        + Environment.NewLine + "IMPORTANTE: Copie este mensaje completo y reporte a su proveedor de sistemas."
                        + Environment.NewLine
                        + Environment.NewLine
                        + Res
                        + Environment.NewLine
                        + Environment.NewLine
                        + _Response;
            }
            return ret;
        }

        protected bool GuardaCFDITemp()
        {
            bool ret = false;
            Entidades.CfdiTemp eCfdiTemp = new Entidades.CfdiTemp();
            eCfdiTemp.IDDOCFISCAL = IdDocFiscal;
            eCfdiTemp.XMLSELLADO = XmlATimbrar;
            string Res = Datos.Nuevo<Entidades.CfdiTemp>(eCfdiTemp, null, Enumeradores.TypeAction.None, Conexiones.SqlServer.conexionTimbrado);
            if (Funciones.StringToLong(Res) > 0)
                ret = true;
            else
            {
                _Response = "El Cfdi No pudo Timbrado "
                        + Environment.NewLine + "IMPORTANTE: Copie este mensaje completo y reporte a su proveedor de sistemas."
                        + Environment.NewLine
                        + Environment.NewLine
                        + Res
                        + Environment.NewLine
                        + Environment.NewLine
                        + _Response;
            }
            return ret;
        }

        protected bool ActualizaDocFiscal(Enumeradores.LogAction enLogAction, string UUID, DateTime FechaTimbrado)
        {
            bool ret = false;
            List<Entidades.DocFiscal> lDocFiscal = Datos.Consultar<Entidades.DocFiscal>(new Entidades.DocFiscal()
            {
                ID = IdDocFiscal
            },
            new List<object>().ToArray()
            );
            if (lDocFiscal.Count > 0)
            {
                lDocFiscal[0].IDCFDI = IdCfdi;
                lDocFiscal[0].FOLIOFISCAL = UUID;
                if (enLogAction == Enumeradores.LogAction.Timbrar)
                    lDocFiscal[0].TIMBRADO = FechaTimbrado;
                if (enLogAction == Enumeradores.LogAction.Cancelar)
                    lDocFiscal[0].CANCELADO = FechaTimbrado;
                string Res = Datos.Actualizar<Entidades.CfdiTemp>(lDocFiscal[0], null, Enumeradores.TypeAction.None);
                if (Funciones.StringToLong(Res) > 0)
                    ret = true;
                else
                {
                    _Response = "El Documento Fiscal NO Pudo ser Actualizado"
                            + Environment.NewLine + "IMPORTANTE: Copie este mensaje completo y reporte a su proveedor de sistemas."
                            + Environment.NewLine
                            + Environment.NewLine
                            + Res
                            + Environment.NewLine
                            + Environment.NewLine
                            + _Response;
                }
            }
            return ret;
        }

        protected bool GuardaTimbradoLog(Enumeradores.LogAction enLogAction, string Mensaje, string UUID)
        {
            bool ret = false;
            Entidades.TimbradoLog eTimLog = new Entidades.TimbradoLog();
            eTimLog.ACCION = Funciones.StringToInt16(enLogAction.GetHashCode().ToString());
            eTimLog.FECHA = DateTime.Now;
            eTimLog.IDDOCFISCAL = IdDocFiscal;
            eTimLog.MSG = Mensaje;
            eTimLog.NODOCUMENTO = UUID;
            string Res = Datos.Nuevo<Entidades.TimbradoLog>(eTimLog, null, Enumeradores.TypeAction.None, Conexiones.SqlServer.conexionTimbrado);
            if (Funciones.StringToLong(Res) > 0)
                ret = true;
            else
            {
                _Response = "El Log de Timbrado No se pudo Guardar"
                        + Environment.NewLine + "IMPORTANTE: Copie este mensaje completo y reporte a su proveedor de sistemas."
                        + Environment.NewLine
                        + Environment.NewLine
                        + Res
                        + Environment.NewLine
                        + Environment.NewLine
                        + _Response;
            }
            return ret;
        }

        #endregion

        
    }
}
