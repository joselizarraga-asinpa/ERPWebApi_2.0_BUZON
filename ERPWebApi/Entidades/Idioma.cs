using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class Idioma: IEntidadBase
	{
		private Int16 Id;
		private string Nombreidioma;
		
		
		//Constructor
		public Idioma()
		{
			Id = 0; 
			Nombreidioma = ""; 
			
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
		public string NOMBREIDIOMA
		{
			get{ return Nombreidioma.ToString().Trim(); }
			set
			{
				if(value!=Nombreidioma)
				{
					
					Nombreidioma = value;
				}
			}
		}
	}
}
