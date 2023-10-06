using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class CuentaBanco: IEntidadBase
	{
		private Int16 Id;
		private Int16 Idsucursal;
		private Int16 Idbanco;
		private Int16 Idstatus;
        private Int16 Idmoneda;
        private string Alias;
		private string Numerocuenta;
		private string Cuentahabiente;
		private string Clabe;
		private string Sucursal;
		private string Refbancaria;
		
		
		//Constructor
		public CuentaBanco()
		{
			Id = 0; 
			Idsucursal = 0; 
			Idbanco = 0; 
			Idstatus = 0;
            Idmoneda = 0;
            Alias = ""; 
			Numerocuenta = ""; 
			Cuentahabiente = ""; 
			Clabe = ""; 
			Sucursal = ""; 
			Refbancaria = ""; 
			
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
		public Int16 IDSUCURSAL
		{
			get{ return Idsucursal; }
			set
			{
				if(value!=Idsucursal)
				{
					
					Idsucursal = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int16 IDBANCO
		{
			get{ return Idbanco; }
			set
			{
				if(value!=Idbanco)
				{
					
					Idbanco = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
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
        public Int16 IDMONEDA
        {
            get { return Idmoneda; }
            set
            {
                if (value != Idmoneda)
                {

                    Idmoneda = value;
                }
            }
        }
        [DataMember(IsRequired = true)]
		public string ALIAS
		{
			get{ return Alias.ToString().Trim(); }
			set
			{
				if(value!=Alias)
				{
					
					Alias = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string NUMEROCUENTA
		{
			get{ return Numerocuenta.ToString().Trim(); }
			set
			{
				if(value!=Numerocuenta)
				{
					
					Numerocuenta = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string CUENTAHABIENTE
		{
			get{ return Cuentahabiente.ToString().Trim(); }
			set
			{
				if(value!=Cuentahabiente)
				{
					
					Cuentahabiente = value;
				}
			}
		}
		public string CLABE
		{
			get{ return Clabe.ToString().Trim(); }
			set
			{
				if(value!=Clabe)
				{
					
					Clabe = value;
				}
			}
		}
		public string SUCURSAL
		{
			get{ return Sucursal.ToString().Trim(); }
			set
			{
				if(value!=Sucursal)
				{
					
					Sucursal = value;
				}
			}
		}
		public string REFBANCARIA
		{
			get{ return Refbancaria.ToString().Trim(); }
			set
			{
				if(value!=Refbancaria)
				{
					
					Refbancaria = value;
				}
			}
		}
	}
}
