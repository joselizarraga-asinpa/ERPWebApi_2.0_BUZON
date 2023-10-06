using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class RepCfdiTotales: IEntidadBase
	{
		private Int64 Iddocfiscal;
		private decimal Subtotal;
		private decimal Totaldescuento;
		private decimal Impuestosretenidos;
		private decimal Impuestostrasladados;
		private decimal Total;
		private string Impuesto;
		private string Tipofactor;
		private decimal Tasa;

        //Constructor
        public RepCfdiTotales()
		{
			Iddocfiscal = 0; 
			Subtotal = 0; 
			Totaldescuento = 0; 
			Impuestosretenidos = 0; 
			Impuestostrasladados = 0; 
			Total = 0; 
			Impuesto = ""; 
			Tipofactor = ""; 
			Tasa = 0; 
        }
		
		[DataMember(IsRequired = true)]
		public Int64 IDDOCFISCAL
		{
			get{ return Iddocfiscal; }
			set
			{
				if(value!=Iddocfiscal)
				{
					Iddocfiscal = value;
				}
			}
		}
		public decimal SUBTOTAL
		{
			get{ return Subtotal; }
			set
			{
				if(value!=Subtotal)
				{
					Subtotal = value;
				}
			}
		}
		public decimal TOTALDESCUENTO
		{
			get{ return Totaldescuento; }
			set
			{
				if(value!=Totaldescuento)
				{
					Totaldescuento = value;
				}
			}
		}
		public decimal IMPUESTOSRETENIDOS
		{
			get{ return Impuestosretenidos; }
			set
			{
				if(value!=Impuestosretenidos)
				{
					Impuestosretenidos = value;
				}
			}
		}
		public decimal IMPUESTOSTRASLADADOS
		{
			get{ return Impuestostrasladados; }
			set
			{
				if(value!=Impuestostrasladados)
				{
					Impuestostrasladados = value;
				}
			}
		}
		public decimal TOTAL
		{
			get{ return Total; }
			set
			{
				if(value!=Total)
				{
					Total = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string IMPUESTO
		{
			get{ return Impuesto.ToString().Trim(); }
			set
			{
				if(value!=Impuesto)
				{
					Impuesto = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string TIPOFACTOR
		{
			get{ return Tipofactor.ToString().Trim(); }
			set
			{
				if(value!=Tipofactor)
				{
					Tipofactor = value;
				}
			}
		}
		public decimal TASA
		{
			get{ return Tasa; }
			set
			{
				if(value!=Tasa)
				{
					Tasa = value;
				}
			}
		}
    }
}
