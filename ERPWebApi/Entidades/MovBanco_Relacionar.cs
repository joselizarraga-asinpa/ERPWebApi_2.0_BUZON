using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class MovBanco_Relacionar: IEntidadBase
	{
		private Int32 Id;
		private Int16 Idcuentabanco;
		private Int16 Idstatus;
		private Int16 Idfuncionalidad;
		private Int32 Idref;
		private string Referencia;
		private string Nombre;
		private string Concepto;
		private DateTime Fecha;
		private decimal Importe;
		private bool Deposito;
		
		
		//Constructor
		public MovBanco_Relacionar()
		{
			Id = 0; 
			Idcuentabanco = 0; 
			Idstatus = 0; 
			Idfuncionalidad = 0; 
			Idref = 0; 
			Referencia = ""; 
			Nombre = ""; 
			Concepto = ""; 
			Fecha = System.DateTime.Today;
			Importe = 0; 
			Deposito = false; 
			
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
		[DataMember(IsRequired = true)]
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
		[DataMember(IsRequired = true)]
		public decimal IMPORTE
		{
			get{ return Importe; }
			set
			{
				if(value!=Importe)
				{
					Importe = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public bool DEPOSITO
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
	}
}
