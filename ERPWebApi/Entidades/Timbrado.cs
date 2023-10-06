using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{
    public class Timbrado : IEntidadBase
    {
        private long Iddocfiscal;
        private Int16 IdSucursal;
        private string Archivoxml= "";
        private string Rfc = "";
        private string FolioFiscal = "";
        private string Status = "";
        private Enumeradores.CFDIStatus CfdiStatus;
        private Enumeradores.CFDICancelable Cancelable;
        private bool AceptarRechazar;
             

        public List<string> lSolicitudesPendientes = new List<string>();
        public Enumeradores.LogAction enTimbradoAccion;

        //Constructor
        public Timbrado()
        {
            Iddocfiscal = 0;
            IdSucursal = 0;
            Archivoxml = "";
            Rfc = "";
            FolioFiscal = "";
            Status = "";
            CfdiStatus = Enumeradores.CFDIStatus.No_Especificado;
            Cancelable = Enumeradores.CFDICancelable.No_Especificado;
            lSolicitudesPendientes = new List<string>();
            AceptarRechazar = false;
            enTimbradoAccion = Enumeradores.LogAction.Timbrar;            
        }
        
        public long IDDOCFISCAL
        {
            get { return Iddocfiscal; }
            set
            {
                if (value != Iddocfiscal)
                {

                    Iddocfiscal = value;
                }
            }
        }
        
        public Int16 IDSUCURSAL
        {
            get { return IdSucursal; }
            set
            {
                if (value != IdSucursal)
                {
                    IdSucursal = value;
                }
            }
        }

        public string ARCHIVOXML
        {
            get { return Archivoxml.ToString().Trim(); }
            set
            {
                if (value != Archivoxml)
                {

                    Archivoxml = value;
                }
            }
        }
        public string RFC
        {
            get { return Rfc.ToString().Trim(); }
            set
            {
                if (value != Rfc)
                {
                    Rfc = value;
                }
            }
        }
        public string FOLIOFISCAL
        {
            get { return FolioFiscal.ToString().Trim(); }
            set
            {
                if (value != FolioFiscal)
                {
                    FolioFiscal = value;
                }
            }
        }

        public string STATUS
        {
            get { return Status; }
            set
            {
                if (value != Status)
                {
                    Status = value;
                }
            }
        }

        public Enumeradores.CFDIStatus CFDISTATUS
        {
            get { return CfdiStatus; }
            set
            {
                if (value != CfdiStatus)
                {

                    CfdiStatus = value;
                }
            }
        }
        public Enumeradores.CFDICancelable CANCELABLE
        {
            get { return Cancelable; }
            set
            {
                if (value != Cancelable)
                {
                    Cancelable = value;
                }
            }
        }

        public bool ACEPTARRECHAZAR
        {
            get { return AceptarRechazar; }
            set
            {
                if(value != AceptarRechazar)
                {
                    AceptarRechazar = value;
                }
            }
        }


    }
}
