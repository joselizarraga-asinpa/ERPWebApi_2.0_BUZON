using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class Empresa: IEntidadBase
	{
		private Int16 Id;
		private Int16 Idpincliente;
		private Int64 Iddomicilio;
		private Int64 Iddatosgenerales;
        private Int16 Idstatus;
		private byte[] Logo;
        private byte[] Icono;
        private string NombreEmpresa;
        private string AccesoDefault;

        [DataMember(IsRequired = true)]
        public virtual Domicilio eDomicilio { get; set; }

        [DataMember(IsRequired = true)]
        public virtual DatosGenerales eDatosGenerales { get; set; }

        //Constructor
        public Empresa()
		{
			Id = 0; 
			Idpincliente = 0; 
			Iddomicilio = 0; 
			Iddatosgenerales = 0;
            Idstatus = 0;
            Logo = Array.Empty<byte>();
            Icono = Array.Empty<byte>();
            NombreEmpresa = "";
            AccesoDefault = "";


        }
		
		public Int16 ID
		{
			get{ return Id; }
			set
			{
				if(value!=Id)
				{
					Id = value;
				}
			}
		}
		public Int16 IDPINCLIENTE
		{
			get{ return Idpincliente; }
			set
			{
				if(value!=Idpincliente)
				{
					Idpincliente = value;
				}
			}
		}
		public Int64 IDDOMICILIO
		{
			get{ return Iddomicilio; }
			set
			{
				if(value!=Iddomicilio)
				{
					Iddomicilio = value;
				}
			}
		}
		public Int64 IDDATOSGENERALES
		{
			get{ return Iddatosgenerales; }
			set
			{
				if(value!=Iddatosgenerales)
				{
					Iddatosgenerales = value;
				}
			}
		}
        public Int16 IDSTATUS
        {
            get { return Idstatus; }
            set
            {
                if (value != Idstatus)
                {
                    Idstatus = value;
                }
            }
        }
        public byte[] LOGO
		{
			get{ return Logo; }
			set
			{
				if(value!=Logo)
				{
					Logo = value;
				}
			}
		}
        public byte[] ICONO
        {
            get { return Icono; }
            set
            {
                if (value != Icono)
                {
                    Icono = value;
                }
            }
        }
        public string NOMBREEMPRESA
		{
			get{ return NombreEmpresa.ToString().Trim(); }
			set
			{
				if(value!= NombreEmpresa)
				{
                    NombreEmpresa = value;
				}
			}
		}
        public string ACCESODEFAULT
        {
            get { return AccesoDefault.ToString().Trim(); }
            set
            {
                if (value != AccesoDefault)
                {
                    AccesoDefault = value;
                }
            }
        }
    }
}
