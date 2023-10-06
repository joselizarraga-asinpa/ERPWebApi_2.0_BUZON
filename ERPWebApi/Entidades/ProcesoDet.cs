using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class ProcesoDet: IEntidadBase
	{
		private Int16 Id;
		private Int16 Idproceso;
		private Int32 Idformula;
		private string Nombreprocesodet;
		private decimal Porcentaje;
		private Int16 Orden;
		
		
		//Constructor
		public ProcesoDet()
		{
			Id = 0; 
			Idproceso = 0; 
			Idformula = 0; 
			Nombreprocesodet = ""; 
			Porcentaje = 0; 
			Orden = 0; 
			
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
		public Int16 IDPROCESO
		{
			get{ return Idproceso; }
			set
			{
				if(value!=Idproceso)
				{
					
					Idproceso = value;
				}
			}
		}
		public Int32 IDFORMULA
		{
			get{ return Idformula; }
			set
			{
				if(value!=Idformula)
				{
					
					Idformula = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string NOMBREPROCESODET
		{
			get{ return Nombreprocesodet.ToString().Trim(); }
			set
			{
				if(value!=Nombreprocesodet)
				{
					
					Nombreprocesodet = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public decimal PORCENTAJE
		{
			get{ return Porcentaje; }
			set
			{
				if(value!=Porcentaje)
				{
					
					Porcentaje = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int16 ORDEN
		{
			get{ return Orden; }
			set
			{
				if(value!=Orden)
				{
					
					Orden = value;
				}
			}
		}
	}
}
