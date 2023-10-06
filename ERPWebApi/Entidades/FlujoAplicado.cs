using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class FlujoAplicado: IEntidadBase
	{
		private Int32 Id;
		private Int32 Idflujo;
		private long IdMovCaja;
		private Int16 Idfuncionalidad;
		private Int32 Idref;
		private decimal Importe;
		
		
		//Constructor
		public FlujoAplicado()
		{
			Id = 0; 
			Idflujo = 0;
			IdMovCaja = 0;
			Idfuncionalidad = 0; 
			Idref = 0; 
			Importe = 0; 
			
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
		public Int32 IDFLUJO
		{
			get{ return Idflujo; }
			set
			{
				if(value!=Idflujo)
				{
					Idflujo = value;
				}
			}
		}
		public long IDMOVCAJA
		{
			get { return IdMovCaja; }
			set
			{
				if (value != IdMovCaja)
				{
					IdMovCaja = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
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
		[DataMember(IsRequired = true)]
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
