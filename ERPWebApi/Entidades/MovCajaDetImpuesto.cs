using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class MovCajaDetImpuesto: IEntidadBase
	{
		private Int64 Id;
		private Int64 Idmovcajadetalle;
		private string Tipoimpuesto;
		private decimal Importe;
		private bool Retencion;
		
		
		//Constructor
		public MovCajaDetImpuesto()
		{
			Id = 0; 
			Idmovcajadetalle = 0; 
			Tipoimpuesto = ""; 
			Importe = 0; 
			Retencion = false; 
			
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
		[DataMember(IsRequired = true)]
		public Int64 IDMOVCAJADETALLE
		{
			get{ return Idmovcajadetalle; }
			set
			{
				if(value!=Idmovcajadetalle)
				{
					
					Idmovcajadetalle = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string TIPOIMPUESTO
		{
			get{ return Tipoimpuesto.ToString().Trim(); }
			set
			{
				if(value!=Tipoimpuesto)
				{
					
					Tipoimpuesto = value;
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
		public bool RETENCION
		{
			get{ return Retencion; }
			set
			{
				if(value!=Retencion)
				{
					
					Retencion = value;
				}
			}
		}
	}
}
