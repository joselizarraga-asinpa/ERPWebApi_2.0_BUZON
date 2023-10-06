using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SW.Helpers;

namespace ERPWebApi.CFDI
{
    public class Timbrado
    {
        private PACTimbrado enPACTim = PACTimbrado.SW;
        private bool _HasError;
        private string _Response;

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

        public enum PACTimbrado
        {
            SW = 0
        }

        public Timbrado()
        {            
        }

        public Entidades.Timbrado GetCFDI(long IdDocFiscal)
        {                        
            Entidades.Timbrado eTim = new Entidades.Timbrado();
            try
            {
                eTim.HasError = true;
                eTim.IDDOCFISCAL = IdDocFiscal;
                if (enPACTim == PACTimbrado.SW)
                {
                    CFDI.Cfdi_SW Tim = new CFDI.Cfdi_SW(IdDocFiscal);
                    if (Tim.GetCFDI())
                    {
                        eTim.HasError = Tim.HasError;
                        eTim.Error = Tim.Response;
                        eTim.CFDISTATUS = Tim.enStatus;
                        eTim.CANCELABLE = Tim.enCancelable;                        
                        eTim.ARCHIVOXML = Tim.Xml;                        
                    }
                    else
                        eTim.Error = Tim.Response;
                }
                else
                {
                    eTim.Error = "No se especificó el PAC de Timbrado";
                }
            }
            catch (Exception ex)
            {
                eTim.Error = ex.Message;
            }            
            return eTim;
        }

        public Entidades.Timbrado CancelCFDI(long IdDocFiscal)
        {
            Entidades.Timbrado eTim = new Entidades.Timbrado();
            try
            {
                eTim.HasError = true;
                eTim.IDDOCFISCAL = IdDocFiscal;
                if (enPACTim == PACTimbrado.SW)
                {
                    CFDI.Cfdi_SW Tim = new CFDI.Cfdi_SW(IdDocFiscal);
                    if (Tim.CancelCFDI())
                    {
                        eTim.HasError = Tim.HasError;
                        eTim.Error = Tim.Response;
                        eTim.CFDISTATUS = Tim.enStatus;
                        eTim.CANCELABLE = Tim.enCancelable;
                        eTim.STATUS = Tim.Response;
                        eTim.ARCHIVOXML = Tim.Xml;
                    }
                    else
                        eTim.Error = Tim.Response;
                }
                else
                {
                    eTim.Error = "No se especificó el PAC de Timbrado";
                }
            }
            catch (Exception ex)
            {
                eTim.Error = ex.Message;
            }
            return eTim;
        }

        public Entidades.Timbrado GetStatusCFDI(long IdDocFiscal)
        {
            Entidades.Timbrado eTim = new Entidades.Timbrado();
            try
            {
                eTim.HasError = true;
                eTim.IDDOCFISCAL = IdDocFiscal;
                if (enPACTim == PACTimbrado.SW)
                {
                    CFDI.Cfdi_SW Tim = new CFDI.Cfdi_SW(IdDocFiscal);
                    if (Tim.GetStatusCFDI())
                    {
                        eTim.HasError = Tim.HasError;
                        eTim.Error = Tim.Response;
                        eTim.CFDISTATUS = Tim.enStatus;
                        eTim.CANCELABLE = Tim.enCancelable;                        
                        eTim.STATUS = Tim.Response;
                        eTim.ARCHIVOXML = Tim.Xml;
                    }
                    else
                        eTim.Error = Tim.Response;
                }
                else
                {
                    eTim.Error = "No se especificó el PAC de Timbrado";
                }
            }
            catch (Exception ex)
            {
                eTim.Error = ex.Message;
            }
            return eTim;
        }

        public Entidades.Timbrado GetSolicitudesPendientes(Int16 _IdSucursal)
        {
            Entidades.Timbrado eTim = new Entidades.Timbrado();
            try
            {
                eTim.HasError = true;
                if (enPACTim == PACTimbrado.SW)
                {
                    CFDI.Cfdi_SW Tim = new CFDI.Cfdi_SW(0, _IdSucursal);
                    Tim.SolicitudesPendientes();
                    eTim.HasError = Tim.HasError;
                    eTim.Error = Tim.Response;
                    eTim.lSolicitudesPendientes = Tim.lSolPendientes;
                    eTim.STATUS = Tim.Response;
                    eTim.ARCHIVOXML = Tim.Xml;
                }
                else
                {
                    eTim.Error = "No se especificó el PAC de Timbrado";                    
                }
            }
            catch (Exception ex)
            {
                eTim.Error = ex.Message;
            }
            return eTim;
        }

        public Entidades.Timbrado AceptarRechazarCFDI(Int16 _IdSucursal, string UUID, bool AceptarRechazar)
        {
            Entidades.Timbrado eTim = new Entidades.Timbrado();
            EnumAcceptReject enAceptarRechazar = AceptarRechazar ? EnumAcceptReject.Aceptacion: EnumAcceptReject.Rechazo;
            try
            {
                eTim.HasError = true;
                eTim.IDDOCFISCAL = 0;
                if (enPACTim == PACTimbrado.SW)
                {
                    CFDI.Cfdi_SW Tim = new CFDI.Cfdi_SW(0, _IdSucursal);
                    if (Tim.AceptarRechazarCFDI(UUID,enAceptarRechazar))
                        eTim.STATUS = Tim.Response;
                    eTim.HasError = Tim.HasError;
                    eTim.Error = Tim.Response;
                }
                else
                {
                    eTim.Error = "No se especificó el PAC de Timbrado";
                }
            }
            catch (Exception ex)
            {
                eTim.Error = ex.Message;
            }
            return eTim;
        }

        public Entidades.Timbrado SaldoTimbres(Int16 _IdSucursal)
        {
            Entidades.Timbrado eTim = new Entidades.Timbrado();
            try
            {
                eTim.HasError = true;
                eTim.IDDOCFISCAL = 0;                
                if (enPACTim == PACTimbrado.SW)
                {
                    CFDI.Cfdi_SW Tim = new CFDI.Cfdi_SW(0, _IdSucursal);
                    if (Tim.SaldoTimbres())
                        eTim.STATUS = Tim.Response;
                    eTim.HasError = Tim.HasError;
                    eTim.Error = Tim.Response;
                }
                else
                {
                    eTim.Error = "No se especificó el PAC de Timbrado";
                }
            }
            catch (Exception ex)
            {
                eTim.Error = ex.Message;
            }
            return eTim;
        }

        public Entidades.Timbrado ValidaRFC(Int16 _IdSucursal, string rfc)
        {
            Entidades.Timbrado eTim = new Entidades.Timbrado();            
            try
            {
                eTim.HasError = true;
                eTim.IDDOCFISCAL = 0;
                eTim.RFC = rfc;
                if (enPACTim == PACTimbrado.SW)
                {
                    CFDI.Cfdi_SW Tim = new CFDI.Cfdi_SW(0, _IdSucursal);
                    if (Tim.ValidaRFC(rfc))                                            
                        eTim.STATUS = Tim.Response;
                    eTim.HasError = Tim.HasError;
                    eTim.Error = Tim.Response;
                }
                else
                {
                    eTim.Error = "No se especificó el PAC de Timbrado";
                }
            }
            catch (Exception ex)
            {
                eTim.Error = ex.Message;
            }
            return eTim;
        }

        public Entidades.Timbrado ValidaXML(Int16 _IdSucursal, string xml)
        {
            Entidades.Timbrado eTim = new Entidades.Timbrado();
            try
            {
                eTim.HasError = true;
                eTim.IDDOCFISCAL = 0;
                eTim.ARCHIVOXML = xml;
                if (enPACTim == PACTimbrado.SW)
                {
                    CFDI.Cfdi_SW Tim = new CFDI.Cfdi_SW(0, _IdSucursal);
                    if (Tim.ValidaXML(xml))
                        eTim.STATUS = Tim.Response;
                    eTim.HasError = Tim.HasError;
                    eTim.Error = Tim.Response;
                }
                else
                {
                    eTim.Error = "No se especificó el PAC de Timbrado";
                }
            }
            catch (Exception ex)
            {
                eTim.Error = ex.Message;
            }
            return eTim;
        }
    }
}
