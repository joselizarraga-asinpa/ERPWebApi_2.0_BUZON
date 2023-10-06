using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using System.Xml;
using System.IO;
using SW.Services.Authentication;
using SW.Services.Stamp;
using SW.Services.Cancelation;
using SW.Tools.Entities;
using ERPWebApi.DAL;

namespace ERPWebApi.CFDI
{
    public class Cfdi_SWXml : CfdiBase
    {        
        private string url;        

        public Cfdi_SWXml(long _IdDocFiscal, string _userStamp, string _passwordStamp, string _url)
        {
            base.IdDocFiscal = _IdDocFiscal;
            base.User = _userStamp;
            base.Password = _passwordStamp;
            url = _url;            
        }

        public string GetXML()
        {
            string xml = "";                        
            if (base.LeeCfdiEncabezado())
            {
                if (base.eCfdiEnc.IDTIPOTIMBRADO == Enumeradores.TipoTimbrado.Recibo_de_Pagos.GetHashCode())                
                    xml = GetXMLPago();                
                else                
                    xml = GetXMLComprobante();                
            }
            return xml;
        }

        private string GetXMLComprobante()
        {
            string xml = "";            
            SW.Tools.Entities.Comprobante comprobante = new SW.Tools.Entities.Comprobante();
            comprobante.SetComprobante(base.eCfdiEnc.MONEDA, base.eCfdiEnc.TIPOCOMPROBANTE, base.eCfdiEnc.FORMAPAGO, base.eCfdiEnc.METODOPAGO, base.eCfdiEnc.LUGAREXPEDICION, base.eCfdiEnc.SERIE, base.eCfdiEnc.FOLIO.ToString(),null,base.eCfdiEnc.TIPOCAMBIO);
            comprobante.SetEmisor(base.eCfdiEnc.EMISORRFC, base.eCfdiEnc.EMISORNOMBRE, base.eCfdiEnc.EMISORREGIMENFISCAL);
            if(base.eCfdiEnc.RECEPTORRFC.ToUpper() == "XEXX010101000")
                comprobante.SetReceptor(base.eCfdiEnc.RECEPTORRFC, base.eCfdiEnc.RECEPTORNOMBRE, base.eCfdiEnc.USOCFDI, base.eCfdiEnc.RESIDENCIAFISCAL, base.eCfdiEnc.NUMREGIDTRIB);
            else
                comprobante.SetReceptor(base.eCfdiEnc.RECEPTORRFC, base.eCfdiEnc.RECEPTORNOMBRE, base.eCfdiEnc.USOCFDI);
            if (base.LeeCfdiComplemento())
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(@eComp.XML);                
                XmlElement addenda = doc.DocumentElement;
                comprobante.SetComplemento(addenda);
            }
            if (base.LeeCfdiDet())
            {
                foreach (Entidades.CFDIDet det in base.lCfdiDet)
                {
                    comprobante.SetConcepto(det.CANTIDAD, det.SATCLAVEPROD, det.SATCLAVEUNIDAD, det.DESCRIPCION, det.NOIDENTIFICACION, det.UNIDAD, det.VALORUNITARIO, det.IMPORTE, det.DESCUENTO);
                    //comprobante.SetConceptoImpuestoTraslado((det.TASA == (decimal)0.16 ? 0.160000m : det.TASA), det.TIPOFACTOR, det.IMPUESTO, det.BASE, Funciones.StringToDecimal(string.Format("{0:#########0.00}",det.IMPORTEIMPUESTO)));
                    comprobante.SetConceptoImpuestoTraslado((det.TASA == (decimal)0.16 ? 0.160000m : det.TASA), det.TIPOFACTOR, det.IMPUESTO, det.BASE, det.IMPORTEIMPUESTO);
                }
                if (base.LeeCfdiRelacion())
                {
                    foreach (Entidades.CFDIRelacion r in base.lCfdiRel)
                    {
                        comprobante.SetCFDIRelacionado(base.eCfdiEnc.TIPORELACION, r.NODOCUMENTO);
                    }
                }
                var invoice = comprobante.GetComprobante();
                xml = SW.Tools.Helpers.Serializer.SerializeDocument(invoice);
            }            
            return xml;
        }

        private string GetXMLPago()
        {
            string xml = "";            
            SW.Tools.Entities.Pagos pago = new SW.Tools.Entities.Pagos();
            pago.SetEmisor(base.eCfdiEnc.EMISORRFC, base.eCfdiEnc.EMISORNOMBRE, base.eCfdiEnc.EMISORREGIMENFISCAL);
            if (base.eCfdiEnc.RECEPTORRFC.ToUpper() == "XAXX010101000" || base.eCfdiEnc.RECEPTORRFC.ToUpper() == "XEXX010101000")
                pago.SetReceptor(base.eCfdiEnc.RECEPTORRFC, base.eCfdiEnc.RECEPTORNOMBRE, base.eCfdiEnc.RESIDENCIAFISCAL, base.eCfdiEnc.NUMREGIDTRIB);
            else
                pago.SetReceptor(base.eCfdiEnc.RECEPTORRFC, base.eCfdiEnc.RECEPTORNOMBRE);
            if (base.LeeCfdiPagos())
            {
                foreach (Entidades.CFDIPagos cp in base.lCfdiPagos)
                {                    
                    pago.SetPago(cp.SATFORMAPAGO, cp.NOCUENTABENEFICIARIO, cp.FECHAPAGO, null, cp.MONEDA, cp.MONTO, cp.BANCOORDENANTE, cp.NOOPERACION, null, null, cp.TIPOCAMBIO);
                    if (base.LeeCfdiPagosDocs(cp.IDPAGO))
                    {
                        foreach (Entidades.CFDIPagosDocs pd in base.lCfdiPagosDocs)
                        {
                            if (cp.MONEDA == "MXN")
                                pago.SetDoctoRelacionado(pd.SERIE, pd.FOLIO.ToString(), pd.NODOCUMENTO,pd.METODOPAGO, pd.MONEDA,pd.PARCIALIDAD.ToString(), -1, pd.SALDOANTERIOR, pd.PAGADO, pd.SALDOINSOLUTO);
                            else
                                pago.SetDoctoRelacionado(pd.SERIE, pd.FOLIO.ToString(), pd.NODOCUMENTO, pd.METODOPAGO, pd.MONEDA, pd.PARCIALIDAD.ToString(), -1, pd.SALDOANTERIOR, pd.PAGADO, pd.SALDOINSOLUTO);
                        }                        
                    }
                }
                var invoice = pago.GetInvoice(base.eCfdiEnc.LUGAREXPEDICION, base.eCfdiEnc.SERIE, base.eCfdiEnc.FOLIO.ToString());
                xml = SW.Tools.Helpers.Serializer.SerializeDocument(invoice);
            }
            return xml;
        }








        #region Funciones Demo

        private string SignInvoice(string xmlInvoice)
        {
            byte[] bytesCer = File.ReadAllBytes(@"Certificados\ArchivosPrueba\CSD_Prueba_CFDI_LAN8507268IA.cer");
            byte[] bytesKey = File.ReadAllBytes(@"Certificados\ArchivosPrueba\CSD_Prueba_CFDI_LAN8507268IA.key");
            string password = "12345678a";
            var pfx = SW.Tools.Sign.CrearPFX(bytesCer, bytesKey, password);
            var xmlResult = SW.Tools.Sign.SellarCFDIv33(pfx, password, xmlInvoice);
            return xmlResult;
        }

        public void DeserailizeXml()
        {
            var xml = SW.Tools.Fiscal.RemoverCaracteresInvalidosXml(Encoding.UTF8.GetString(File.ReadAllBytes(@"ArchivosPrueba\cfdi33Invoice.xml")));
            var xmlInvoicess = SW.Tools.Helpers.Serializer.DeserealizeDocument<SW.Tools.Entities.Comprobante>(xml);
        }       

        public string GetInvoiceDemo()
        {
            //          XmlDocument doc = new XmlDocument();
            //          doc.LoadXml(@"<PSG:Factura division='VW' tipoDocumentoFiscal='FA' tipoDocumentoVWM='PSG' version='1.0' xmlns:PSG='http://www.vwnovedades.com/volkswagen/kanseilab/shcp/2009/Addenda/PSG'>
            //	<PSG:Moneda codigoImpuesto='1A' tipoCambio='1.00' tipoMoneda='MXN'/>
            //	<PSG:Proveedor correoContacto=''/>
            //	<PSG:Referencias/>
            //	<PSG:Solicitante/>
            //	<PSG:Archivo datos='' tipo='PDF'/>
            //	<PSG:Partes>
            //		<PSG:Parte cantidadMaterial='1.0000' codigoImpuesto='1A' descripcionMaterial='DERECHO DE POLIZA' montoLinea='550.0000' posicion='1' precioUnitario='550.0000' unidadMedida=''/>
            //		<PSG:Parte cantidadMaterial='1.0000' codigoImpuesto='1A' descripcionMaterial='DERECHO DE POLIZA' montoLinea='550.0000' posicion='1' precioUnitario='550.0000' unidadMedida=''/>
            //		<PSG:Parte cantidadMaterial='1.0000' codigoImpuesto='1A' descripcionMaterial='DERECHO DE POLIZA' montoLinea='550.0000' posicion='1' precioUnitario='550.0000' unidadMedida=''/>
            //	</PSG:Partes>
            //</PSG:Factura>");
            //          XmlElement addenda = doc.DocumentElement;            
            SW.Tools.Entities.Comprobante comprobante = new SW.Tools.Entities.Comprobante();
            //comprobante.SetAddenda(addenda);
            comprobante.SetComprobante("MXN", "I", "01", "PPD", "45130","G","1");
            comprobante.SetConcepto(1, "84131500", "ZZ", "Prima neta1", "1", "NO APLICA", 3592.83m);
            comprobante.SetConcepto(1, "84131500", "ZZ", "Prima neta1", "1", "NO APLICA", 3592.83m);
            comprobante.SetConceptoImpuestoTraslado(0.160000m, c_TipoFactor.Tasa.ToString(), "002", 3592.83m);
            comprobante.SetConcepto(1, "84131500", "ZZ", "Prima neta1", "1", "NO APLICA", 3592.83m);
            comprobante.SetConceptoImpuestoTraslado(0.160000m, c_TipoFactor.Tasa.ToString(), "002", 258.68m);
            comprobante.SetConcepto(1, "84131500", "ZZ", "Prima neta1", "1", "NO APLICA", 3592.83m);
            comprobante.SetConceptoImpuestoTraslado(0.160000m, c_TipoFactor.Tasa.ToString(), "002", 550.00m);            
            comprobante.SetEmisor("WSI170221BB7", "WALLACE SISTEMAS INTELIGENTES SA DE CV", "601");
            //comprobante.SetEmisor("AAA010101AAA", "ACCEM SERVICIOS EMPRESARIALES SC", "601");
            comprobante.SetReceptor("XAXX010101000", "MIGUEL LANGARKA GENESTA", "G03");
            var invoice = comprobante.GetComprobante();
            var xmlInvoice = SW.Tools.Helpers.Serializer.SerializeDocument(invoice);
            //xmlInvoice = SignInvoice(xmlInvoice);
            return xmlInvoice;
        }
        
        public string GetInvoiceWithXmlComplementDemo()
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(@"<cce11:ComercioExterior CertificadoOrigen='0' ClaveDePedimento='A1' Incoterm='DDP' Subdivision='0' TipoCambioUSD='18.5000' TipoOperacion='2' TotalUSD='100.73' Version='1.1' xmlns:cce11='http://www.sat.gob.mx/ComercioExterior11'>
      <cce11:Emisor>
        <cce11:Domicilio Calle='AV PROLONGACION COLON' CodigoPostal='45610' Estado='JAL' Localidad='09' Municipio='098' NumeroExterior='6013' Pais='MEX'/>
      </cce11:Emisor>
      <cce11:Receptor>
        <cce11:Domicilio Calle='1320 S MAIN ST' CodigoPostal='19044-0000' Estado='OH' Municipio='MANSFIELD' NumeroExterior='123' Pais='USA'/>
      </cce11:Receptor>
      <cce11:Destinatario>
        <cce11:Domicilio Calle='2905 Miller Park North ' CodigoPostal='19044-0000' Estado='TX' Municipio='Garland' Pais='USA'/>
      </cce11:Destinatario>
      <cce11:Mercancias>
        <cce11:Mercancia FraccionArancelaria='48191001' NoIdentificacion='CHI-ESU9000' ValorDolares='100.73'/>
      </cce11:Mercancias></cce11:ComercioExterior>");
            XmlElement addenda = doc.DocumentElement;
            SW.Tools.Entities.Comprobante comprobante = new SW.Tools.Entities.Comprobante();
            comprobante.SetComplemento(addenda);
            comprobante.SetComprobante("MXN", "I", "01", "PPD", "2000");
            comprobante.SetConcepto(1, "84131500", "ZZ", "Prima neta", "1", "NO APLICA", 3592.83m, null, 0);
            comprobante.SetConceptoImpuestoTraslado(0.1600000m, "Tasa", "002", 3592.83m, null);
            comprobante.SetConcepto(1, "84131500", "ZZ", "Recargo por pago fraccionado", "1", "NO APLICA", 258.68m, 258.68m);
            comprobante.SetConceptoImpuestoTraslado(0.1600000m, "Tasa", "002", 258.68m, 20.20m);
            comprobante.SetConcepto(1, "84131500", "ZZ", "derecho de poliza", "1", "NO APLICA", 550.00m);
            comprobante.SetConceptoImpuestoTraslado(0.1600000m, "Tasa", "002", 550.00m);            
            comprobante.SetEmisor("WSI170221BB7", "WALLACE SISTEMAS INTELIGENTES SA DE CV", "601");
            comprobante.SetReceptor("XAXX010101000", "MIGUEL LANGARKA GENESTA", "G03");
            var invoice = comprobante.GetComprobante();
            var xmlInvoice = SW.Tools.Helpers.Serializer.SerializeDocument(invoice);
            xmlInvoice = SignInvoice(xmlInvoice);
            return xmlInvoice;
        }
                
        public string GetInvoicePagos10Demo()
        {
            SW.Tools.Entities.Pagos pago = new SW.Tools.Entities.Pagos();
            pago.SetPago("01", null, DateTime.Now, null, "USD", 15000.00m, null, "1", null, null, 21.5m);
            pago.SetDoctoRelacionado("RogueOne", "Folio1", "0aded095-b84d-4364-8f8e-59c3f650e530",
                "PPD", "MXN", "1", 30000, 15000, 15000);
            pago.SetEmisor("WSI170221BB7", "WALLACE SISTEMAS INTELIGENTES SA DE CV", "601");
            pago.SetReceptor("AAQM610917QJA", "EMPLEADO SMARTERWEB");
            var invoice = pago.GetInvoice("99056", "A", "1");
            var xmlInvoice = SW.Tools.Helpers.Serializer.SerializeDocument(invoice);
            return xmlInvoice;
        }
                
        public SW.Tools.Entities.Comprobante StampInvoicePagos10Demo()
        {
            SW.Tools.Entities.Pagos pago = new SW.Tools.Entities.Pagos();
            pago.SetPago("01", null, DateTime.Now, null, "USD", 15000.00m, null, "1", null, null, 21.5m);
            pago.SetDoctoRelacionado("RogueOne", "Folio1", "0aded095-b84d-4364-8f8e-59c3f650e530",
                "PPD", "MXN", "1", 1.0000000m, 30000.0000000m, 15000.000000000000m, 15000.000000m);
            pago.SetEmisor("WSI170221BB7", "WALLACE SISTEMAS INTELIGENTES SA DE CV", "601");
            pago.SetReceptor("AAQM610917QJA", "EMPLEADO SMARTERWEB");
            var invoice = pago.GetInvoice("99056", "A", "1");
            var xmlInvoice = SW.Tools.Helpers.Serializer.SerializeDocument(invoice);
            xmlInvoice = SignInvoice(xmlInvoice);
            Stamp stamp = new Stamp(this.url, base.User, base.Password);
            StampResponseV2 response = stamp.TimbrarV2(xmlInvoice);
            var invoiceResultStamp = SW.Tools.Helpers.Serializer.DeserealizeDocument<SW.Tools.Entities.Comprobante>(response.data.cfdi);
            return invoiceResultStamp;
        }   
        
        public string StampInvoiceDemo()
        {
            SW.Tools.Entities.Comprobante comprobante = new SW.Tools.Entities.Comprobante();
            comprobante.SetComprobante("MXN", "I", "01", "PPD", "20000");
            comprobante.SetConcepto(1, "84131500", "ZZ", "Prima neta", "1", "NO APLICA", 3592.83m);
            comprobante.SetConceptoImpuestoTraslado(0.1600000m, "Tasa", "002", 3592.83m);
            comprobante.SetConcepto(1, "84131500", "ZZ", "Recargo por pago fraccionado", "1", "NO APLICA", 258.68m);
            comprobante.SetConceptoImpuestoTraslado(0.1600000m, "Tasa", "002", 258.68m);
            comprobante.SetConcepto(1, "84131500", "ZZ", "derecho de poliza", "1", "NO APLICA", 550.00m);
            comprobante.SetConceptoImpuestoTraslado(0.1600000m, "Tasa", "002", 550.00m);
            comprobante.SetEmisor("WSI170221BB7", "WALLACE SISTEMAS INTELIGENTES SA DE CV", "601");
            comprobante.SetReceptor("XAXX010101000", "MIGUEL LANGARKA GENESTA", "G03");
            var invoice = comprobante.GetComprobante();
            var xmlInvoice = SW.Tools.Helpers.Serializer.SerializeDocument(invoice);
            xmlInvoice = SignInvoice(xmlInvoice);
            Stamp stamp = new Stamp(this.url, base.User, base.Password);
            StampResponseV2 response = stamp.TimbrarV2(xmlInvoice);
            return response.messageDetail;
        }

        #endregion


    }
}
