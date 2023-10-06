using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class TipoCambio: IEntidadBase
	{
		private Int64 Id;
		private Int16 Idmoneda;
		private DateTime Fecha;
		private decimal Importe;
		
		
		//Constructor
		public TipoCambio()
		{
			Id = 0; 
			Idmoneda = 0; 
			Fecha = System.DateTime.Today;
			Importe = 0; 
			
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
		public Int16 IDMONEDA
		{
			get{ return Idmoneda; }
			set
			{
				if(value!=Idmoneda)
				{
					Idmoneda = value;
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
	}
}
