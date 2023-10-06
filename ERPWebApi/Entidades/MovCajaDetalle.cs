using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class MovCajaDetalle: IEntidadBase
	{
		private Int64 Id;
		private Int64 Idmovcaja;
		private Int64 Iddocaplicado;
		private decimal Importe;
		
		
		//Constructor
		public MovCajaDetalle()
		{
			Id = 0; 
			Idmovcaja = 0; 
			Iddocaplicado = 0; 
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
		public Int64 IDMOVCAJA
		{
			get{ return Idmovcaja; }
			set
			{
				if(value!=Idmovcaja)
				{
					
					Idmovcaja = value;
				}
			}
		}
		public Int64 IDDOCAPLICADO
		{
			get{ return Iddocaplicado; }
			set
			{
				if(value!=Iddocaplicado)
				{
					
					Iddocaplicado = value;
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
