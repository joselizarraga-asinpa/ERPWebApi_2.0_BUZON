using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class TipoRelacionCFDI: IEntidadBase
	{
		private Int16 Id;
		private string Nombretiporelacioncfdi;
		private string Clavesat;
		private string Ingreso;
		
		
		//Constructor
		public TipoRelacionCFDI()
		{
			Id = 0; 
			Nombretiporelacioncfdi = ""; 
			Clavesat = ""; 
			Ingreso = ""; 
			
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
		public string NOMBRETIPORELACIONCFDI
		{
			get{ return Nombretiporelacioncfdi.ToString().Trim(); }
			set
			{
				if(value!=Nombretiporelacioncfdi)
				{
					Nombretiporelacioncfdi = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string CLAVESAT
		{
			get{ return Clavesat.ToString().Trim(); }
			set
			{
				if(value!=Clavesat)
				{
					Clavesat = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string INGRESO
		{
			get{ return Ingreso.ToString().Trim(); }
			set
			{
				if(value!=Ingreso)
				{
					Ingreso = value;
				}
			}
		}
	}
}
