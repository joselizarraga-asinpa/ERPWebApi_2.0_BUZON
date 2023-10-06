using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class Domicilio: IEntidadBase
	{
		private Int64 Id;
		private string Calle;
		private string Nointerior;
		private string Noexterior;
		private string Colonia;
		private string Codigopostal;
		private string Localidad;
		private string Municipio;
		private Int32 Idestado;
		private Int16 Idpais;
		private string Referencias;
        private string Contacto;


        //Constructor
        public Domicilio()
		{
			Id = 0; 
			Calle = ""; 
			Nointerior = ""; 
			Noexterior = ""; 
			Colonia = ""; 
			Codigopostal = ""; 
			Localidad = ""; 
			Municipio = ""; 
			Idestado = 0; 
			Idpais = 0; 
			Referencias = "";
            Contacto = "";

        }
		
		public Int64 ID
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
		public string CALLE
		{
			get{ return Calle.ToString().Trim(); }
			set
			{
				if(value!=Calle)
				{
					
					Calle = value;
				}
			}
		}
		public string NOINTERIOR
		{
			get{ return Nointerior.ToString().Trim(); }
			set
			{
				if(value!=Nointerior)
				{
					
					Nointerior = value;
				}
			}
		}
		public string NOEXTERIOR
		{
			get{ return Noexterior.ToString().Trim(); }
			set
			{
				if(value!=Noexterior)
				{
					
					Noexterior = value;
				}
			}
		}
		public string COLONIA
		{
			get{ return Colonia.ToString().Trim(); }
			set
			{
				if(value!=Colonia)
				{
					
					Colonia = value;
				}
			}
		}
		public string CODIGOPOSTAL
		{
			get{ return Codigopostal.ToString().Trim(); }
			set
			{
				if(value!=Codigopostal)
				{
					
					Codigopostal = value;
				}
			}
		}
		public string LOCALIDAD
		{
			get{ return Localidad.ToString().Trim(); }
			set
			{
				if(value!=Localidad)
				{
					
					Localidad = value;
				}
			}
		}
		public string MUNICIPIO
		{
			get{ return Municipio.ToString().Trim(); }
			set
			{
				if(value!=Municipio)
				{
					
					Municipio = value;
				}
			}
		}
		public Int32 IDESTADO
		{
			get{ return Idestado; }
			set
			{
				if(value!=Idestado)
				{
					
					Idestado = value;
				}
			}
		}
		public Int16 IDPAIS
		{
			get{ return Idpais; }
			set
			{
				if(value!=Idpais)
				{
					
					Idpais = value;
				}
			}
		}
		public string REFERENCIAS
		{
			get{ return Referencias.ToString().Trim(); }
			set
			{
				if(value!=Referencias)
				{
					
					Referencias = value;
				}
			}
		}
        public string CONTACTO
        {
            get { return Contacto.ToString().Trim(); }
            set
            {
                if (value != Contacto)
                {

                    Contacto = value;
                }
            }
        }
    }
}
