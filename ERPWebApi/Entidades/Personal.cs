using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class Personal: IEntidadBase
	{
		private Int16 Id;
		private Int16 Idpincliente;
		private Int64 Iddatosgenerales;
		private Int64 Iddomicilio;
		private Int16 Idstatus;
		private DateTime Fechaalta;
		private DateTime Fechabaja;
		private string Obs;
        private string Nombre;


        //Constructor
        public Personal()
		{
			Id = 0; 
			Idpincliente = 0; 
			Iddatosgenerales = 0; 
			Iddomicilio = 0; 
			Idstatus = 0; 
			Fechaalta = System.DateTime.Today;
			Fechabaja = System.DateTime.Today;
			Obs = "";
            Nombre = "";


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
		[DataMember(IsRequired = true)]
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
		public Int16 IDSTATUS
		{
			get{ return Idstatus; }
			set
			{
				if(value!=Idstatus)
				{
					
					Idstatus = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public DateTime FECHAALTA
		{
			get{ return Fechaalta; }
			set
			{
				if (value != null)
				{
					if(value!=Fechaalta)
					{
						
						Fechaalta = value;
					}
				}
			}
		}
		[DataMember(IsRequired = true)]
		public DateTime FECHABAJA
		{
			get{ return Fechabaja; }
			set
			{
				if (value != null)
				{
					if(value!=Fechabaja)
					{
						
						Fechabaja = value;
					}
				}
			}
		}
		public string OBS
		{
			get{ return Obs.ToString().Trim(); }
			set
			{
				if(value!=Obs)
				{
					
					Obs = value;
				}
			}
		}
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
    }
}
