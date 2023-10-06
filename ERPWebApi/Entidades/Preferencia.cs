using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class Preferencia: IEntidadBase
	{
		private Int16 Id;
		private string Nombrepreferencia;
		
		
		//Constructor
		public Preferencia()
		{
			Id = 0; 
			Nombrepreferencia = ""; 
			
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
		public string NOMBREPREFERENCIA
		{
			get{ return Nombrepreferencia.ToString().Trim(); }
			set
			{
				if(value!=Nombrepreferencia)
				{
					Nombrepreferencia = value;
				}
			}
		}
	}
}
