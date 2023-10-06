using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class Caja: IEntidadBase
	{
		private Int16 Id;
		private Int16 Idsucursal;
		private Int16 Idstatus;
		private string Nombrecaja;
		private string Computadora;
		private decimal Saldo;
		private decimal Fondo;
		private bool Venta;
		private bool Cobranza;
		private bool Pagos;
		private bool Ingresos;
		private bool Egresos;
		private bool Requierepassword;
		private bool Forzarcomputadora;
		
		
		//Constructor
		public Caja()
		{
			Id = 0; 
			Idsucursal = 0; 
			Idstatus = 0; 
			Nombrecaja = ""; 
			Computadora = ""; 
			Saldo = 0; 
			Fondo = 0; 
			Venta = false; 
			Cobranza = false; 
			Pagos = false; 
			Ingresos = false; 
			Egresos = false; 
			Requierepassword = false; 
			Forzarcomputadora = false; 
			
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
		public string NOMBRECAJA
		{
			get{ return Nombrecaja.ToString().Trim(); }
			set
			{
				if(value!=Nombrecaja)
				{
					
					Nombrecaja = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string COMPUTADORA
		{
			get{ return Computadora.ToString().Trim(); }
			set
			{
				if(value!=Computadora)
				{
					
					Computadora = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
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
		[DataMember(IsRequired = true)]
		public decimal FONDO
		{
			get{ return Fondo; }
			set
			{
				if(value!=Fondo)
				{
					
					Fondo = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public bool VENTA
		{
			get{ return Venta; }
			set
			{
				if(value!=Venta)
				{
					
					Venta = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public bool COBRANZA
		{
			get{ return Cobranza; }
			set
			{
				if(value!=Cobranza)
				{
					
					Cobranza = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public bool PAGOS
		{
			get{ return Pagos; }
			set
			{
				if(value!=Pagos)
				{
					
					Pagos = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public bool INGRESOS
		{
			get{ return Ingresos; }
			set
			{
				if(value!=Ingresos)
				{
					
					Ingresos = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public bool EGRESOS
		{
			get{ return Egresos; }
			set
			{
				if(value!=Egresos)
				{
					
					Egresos = value;
				}
			}
		}
		public bool REQUIEREPASSWORD
		{
			get{ return Requierepassword; }
			set
			{
				if(value!=Requierepassword)
				{
					
					Requierepassword = value;
				}
			}
		}
		public bool FORZARCOMPUTADORA
		{
			get{ return Forzarcomputadora; }
			set
			{
				if(value!=Forzarcomputadora)
				{
					
					Forzarcomputadora = value;
				}
			}
		}
	}
}
