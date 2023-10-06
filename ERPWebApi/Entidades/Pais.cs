using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class Pais: IEntidadBase
	{
		private Int16 Id;
		private string Nombrepais;
		
		
		//Constructor
		public Pais()
		{
			Id = 0; 
			Nombrepais = ""; 
			
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
		public string NOMBREPAIS
		{
			get{ return Nombrepais.ToString().Trim(); }
			set
			{
				if(value!=Nombrepais)
				{
					
					Nombrepais = value;
				}
			}
		}
	}
}
