using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class Tema: IEntidadBase
	{
		private Int16 Id;
		private Int16 Idpincliente;
		private string Nombretema;
		
		
		//Constructor
		public Tema()
		{
			Id = 0; 
			Idpincliente = 0; 
			Nombretema = ""; 
			
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
		[DataMember(IsRequired = true)]
		public string NOMBRETEMA
		{
			get{ return Nombretema.ToString().Trim(); }
			set
			{
				if(value!=Nombretema)
				{
					
					Nombretema = value;
				}
			}
		}
	}
}
