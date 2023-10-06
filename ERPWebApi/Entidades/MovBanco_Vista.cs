using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class MovBanco_Vista: IEntidadBase
	{
		private Int32 Id;
		private Int16 Idcuentabanco;
		private Int16 Idstatus;
		private Int16 Idfuncionalidad;
		private Int32 Idref;
        private string Codigo;
        private string Referencia;
		private string Nombre;
		private string Concepto;
		private DateTime Fecha;
		private decimal Deposito;
		private decimal Retiro;
		private decimal Saldo;
		private DateTime Desde;
		private DateTime Hasta;
		
		
		//Constructor
		public MovBanco_Vista()
		{
			Id = 0; 
			Idcuentabanco = 0; 
			Idstatus = 0; 
			Idfuncionalidad = 0; 
			Idref = 0;
            Codigo = "";
            Referencia = ""; 
			Nombre = ""; 
			Concepto = ""; 
			Fecha = System.DateTime.Today;
			Deposito = 0; 
			Retiro = 0; 
			Saldo = 0; 
			Desde = System.DateTime.Today;
			Hasta = System.DateTime.Today;
			
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
		public Int16 IDCUENTABANCO
		{
			get{ return Idcuentabanco; }
			set
			{
				if(value!=Idcuentabanco)
				{
					Idcuentabanco = value;
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
		public Int16 IDFUNCIONALIDAD
		{
			get{ return Idfuncionalidad; }
			set
			{
				if(value!=Idfuncionalidad)
				{
					Idfuncionalidad = value;
				}
			}
		}
		public Int32 IDREF
		{
			get{ return Idref; }
			set
			{
				if(value!=Idref)
				{
					Idref = value;
				}
			}
		}
        public string CODIGO
        {
            get { return Codigo.ToString().Trim(); }
            set
            {
                if (value != Codigo)
                {
                    Codigo = value;
                }
            }
        }
        public string REFERENCIA
		{
			get{ return Referencia.ToString().Trim(); }
			set
			{
				if(value!=Referencia)
				{
					Referencia = value;
				}
			}
		}
		public string NOMBRE
		{
			get{ return Nombre.ToString().Trim(); }
			set
			{
				if(value!=Nombre)
				{
					Nombre = value;
				}
			}
		}
		public string CONCEPTO
		{
			get{ return Concepto.ToString().Trim(); }
			set
			{
				if(value!=Concepto)
				{
					Concepto = value;
				}
			}
		}
		public DateTime FECHA
		{
			get{ return Fecha; }
			set
			{
				if (value != null)
				{
					if(value!=Fecha)
					{
						Fecha = value;
					}
				}
			}
		}
		public decimal DEPOSITO
		{
			get{ return Deposito; }
			set
			{
				if(value!=Deposito)
				{
					Deposito = value;
				}
			}
		}
		public decimal RETIRO
		{
			get{ return Retiro; }
			set
			{
				if(value!=Retiro)
				{
					Retiro = value;
				}
			}
		}
		public decimal SALDO
		{
			get{ return Saldo; }
			set
			{
				if(value!=Saldo)
				{
					Saldo = value;
				}
			}
		}
		public DateTime DESDE
		{
			get{ return Desde; }
			set
			{
				if (value != null)
				{
					if(value!=Desde)
					{
						Desde = value;
					}
				}
			}
		}
		public DateTime HASTA
		{
			get{ return Hasta; }
			set
			{
				if (value != null)
				{
					if(value!=Hasta)
					{
						Hasta = value;
					}
				}
			}
		}
	}
}
