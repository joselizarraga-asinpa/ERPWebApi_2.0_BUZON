using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class Modulo: IEntidadBase
	{
		private Int16 Id;
		private string Nombremodulo;
		
		
		//Constructor
		public Modulo()
		{
			Id = 0; 
			Nombremodulo = ""; 
			
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
		public string NOMBREMODULO
		{
			get{ return Nombremodulo.ToString().Trim(); }
			set
			{
				if(value!=Nombremodulo)
				{
					
					Nombremodulo = value;
				}
			}
		}
	}
}
