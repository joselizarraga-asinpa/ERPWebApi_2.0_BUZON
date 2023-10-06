using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

    //Clase creada por generador de código

    public class DatosGenerales : IEntidadBase
    {
        private Int64 Id;
        private Int16 IdRegimenfiscal;
        private string Nombre;
        private string Apellidopaterno;
        private string Apellidomaterno;
        private string RazonSocial;
        private string NombreComercial;
        private string Rfc;
        private string Registropatronal;
        private string Tipopersona;
        private string Curp;        
        private DateTime Nacimiento;
        private string Identificacion;
        private string NumRegIdTrib;
        private string PaginaWeb;


        //Constructor
        public DatosGenerales()
        {
            Id = 0;
            IdRegimenfiscal = 0;
            Nombre = "";
            Apellidopaterno = "";
            Apellidomaterno = "";
            RazonSocial = "";
            NombreComercial = "";
            Rfc = "";
            Registropatronal = "";
            Tipopersona = "";
            Curp = "";            
            Nacimiento = DateTime.Today;
            Identificacion = "";
            NumRegIdTrib = "";
            PaginaWeb = "";
        }

        public Int64 ID
        {
            get { return Id; }
            set
            {
                if (value != Id)
                {

                    Id = value;
                }
            }
        }
        [DataMember(IsRequired = true)]
        public string NOMBRE
        {
            get { return Nombre.ToString().Trim(); }
            set
            {
                if (value != Nombre)
                {

                    Nombre = value;
                }
            }
        }
        public string APELLIDOPATERNO
        {
            get { return Apellidopaterno.ToString().Trim(); }
            set
            {
                if (value != Apellidopaterno)
                {

                    Apellidopaterno = value;
                }
            }
        }
        public string APELLIDOMATERNO
        {
            get { return Apellidomaterno.ToString().Trim(); }
            set
            {
                if (value != Apellidomaterno)
                {

                    Apellidomaterno = value;
                }
            }
        }
        public string RAZONSOCIAL
        {
            get { return RazonSocial.ToString().Trim(); }
            set
            {
                if (value != RazonSocial)
                {

                    RazonSocial = value;
                }
            }
        }
        public string NOMBRECOMERCIAL
        {
            get { return NombreComercial.ToString().Trim(); }
            set
            {
                if (value != NombreComercial)
                {

                    NombreComercial = value;
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
        public string REGISTROPATRONAL
        {
            get { return Registropatronal.ToString().Trim(); }
            set
            {
                if (value != Registropatronal)
                {

                    Registropatronal = value;
                }
            }
        }
        public string TIPOPERSONA
        {
            get { return Tipopersona.ToString().Trim(); }
            set
            {
                if (value != Tipopersona)
                {

                    Tipopersona = value;
                }
            }
        }
        public string CURP
        {
            get { return Curp.ToString().Trim(); }
            set
            {
                if (value != Curp)
                {

                    Curp = value;
                }
            }
        }
        public Int16 IDREGIMENFISCAL
        {
            get { return IdRegimenfiscal; }
            set
            {
                if (value != IdRegimenfiscal)
                {

                    IdRegimenfiscal = value;
                }
            }
        }
        public DateTime NACIMIENTO
        {
            get { return Nacimiento; }
            set
            {
                if (value != null)
                {
                    if (value != Nacimiento)
                    {

                        Nacimiento = value;
                    }
                }
            }
        }
        public string IDENTIFICACION
        {
            get { return Identificacion.ToString().Trim(); }
            set
            {
                if (value != Identificacion)
                {

                    Identificacion = value;
                }
            }
        }
        public string NUMREGIDTRIB
        {
            get { return NumRegIdTrib.ToString().Trim(); }
            set
            {
                if (value != NumRegIdTrib)
                {
                    NumRegIdTrib = value;
                }
            }
        }
        public string PAGINAWEB
        {
            get { return PaginaWeb.ToString().Trim(); }
            set
            {
                if (value != PaginaWeb)
                {
                    PaginaWeb = value;
                }
            }
        }
    }
}
