using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class Config: IEntidadBase
	{
		private Int16 Id;
		private string Variable;
		private string Valor;
		
		
		//Constructor
		public Config()
		{
			Id = 0; 
			Variable = ""; 
			Valor = ""; 
			
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
		public string VARIABLE
		{
			get{ return Variable.ToString().Trim(); }
			set
			{
				if(value!=Variable)
				{
					Variable = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string VALOR
		{
			get{ return Valor.ToString().Trim(); }
			set
			{
				if(value!=Valor)
				{
					Valor = value;
				}
			}
		}
	}
}
