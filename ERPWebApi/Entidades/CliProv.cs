using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class CliProv: IEntidadBase
	{
		private Int32 Id;
		private Int16 Idpincliente;
		private Int64 Iddatosgenerales;
		private Int64 Iddomicilio;
		private Int64 Iddomicilioentrega;
		private Int16 Idstatus;
        private Int16 IdUsoCfdi;
        private DateTime Fechaalta;
		private bool Cliente;
		private decimal Limitecredito;
		private Int16 Diascredito;
		private string Obs;
        private string Nombre;


        //Constructor
        public CliProv()
		{
			Id = 0; 
			Idpincliente = 0; 
			Iddatosgenerales = 0; 
			Iddomicilio = 0; 
			Iddomicilioentrega = 0; 
			Idstatus = 0;
            IdUsoCfdi = 0;
            Fechaalta = System.DateTime.Today;
			Cliente = false; 
			Limitecredito = 0; 
			Diascredito = 0; 
			Obs = "";
            Nombre = "";


        }
		
		public Int32 ID
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
		public Int64 IDDOMICILIOENTREGA
		{
			get{ return Iddomicilioentrega; }
			set
			{
				if(value!=Iddomicilioentrega)
				{
					
					Iddomicilioentrega = value;
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
        public Int16 IDUSOCFDI
        {
            get { return IdUsoCfdi; }
            set
            {
                if (value != IdUsoCfdi)
                {

                    IdUsoCfdi = value;
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
		public bool CLIENTE
		{
			get{ return Cliente; }
			set
			{
				if(value!=Cliente)
				{
					
					Cliente = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public decimal LIMITECREDITO
		{
			get{ return Limitecredito; }
			set
			{
				if(value!=Limitecredito)
				{
					
					Limitecredito = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int16 DIASCREDITO
		{
			get{ return Diascredito; }
			set
			{
				if(value!=Diascredito)
				{
					
					Diascredito = value;
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
