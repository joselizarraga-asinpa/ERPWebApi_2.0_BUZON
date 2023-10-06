using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class Banco: IEntidadBase
	{
		private Int16 Id;
		private string Nombrebanco;
		private string Rfc;
		
		
		//Constructor
		public Banco()
		{
			Id = 0; 
			Nombrebanco = ""; 
			Rfc = ""; 
			
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
		public string NOMBREBANCO
		{
			get{ return Nombrebanco.ToString().Trim(); }
			set
			{
				if(value!=Nombrebanco)
				{
					
					Nombrebanco = value;
				}
			}
		}
		public string RFC
		{
			get{ return Rfc.ToString().Trim(); }
			set
			{
				if(value!=Rfc)
				{
					
					Rfc = value;
				}
			}
		}
	}
}
