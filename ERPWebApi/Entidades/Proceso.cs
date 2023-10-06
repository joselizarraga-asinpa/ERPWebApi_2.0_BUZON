using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class Proceso: IEntidadBase
	{
		private Int16 Id;
		private Int16 Idpincliente;
		private Int16 Idmodulo;
		private Int16 Iddiagramaproceso;
		private string Nombreproceso;
		
		
		//Constructor
		public Proceso()
		{
			Id = 0; 
			Idpincliente = 0; 
			Idmodulo = 0; 
			Iddiagramaproceso = 0; 
			Nombreproceso = ""; 
			
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
		public Int16 IDPINCLIENTE
		{
			get{ return Idpincliente; }
			set
			{
				if(value!=Idpincliente)
				{
					
					Idpincliente = value;
				}
			}
		}
		public Int16 IDMODULO
		{
			get{ return Idmodulo; }
			set
			{
				if(value!=Idmodulo)
				{
					
					Idmodulo = value;
				}
			}
		}
		public Int16 IDDIAGRAMAPROCESO
		{
			get{ return Iddiagramaproceso; }
			set
			{
				if(value!=Iddiagramaproceso)
				{
					
					Iddiagramaproceso = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string NOMBREPROCESO
		{
			get{ return Nombreproceso.ToString().Trim(); }
			set
			{
				if(value!=Nombreproceso)
				{
					
					Nombreproceso = value;
				}
			}
		}
	}
}
