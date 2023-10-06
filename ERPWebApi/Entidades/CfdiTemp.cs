using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class CfdiTemp: IEntidadBase
	{
		private Int64 Iddocfiscal;
		private string Xmlsellado;
				
		//Constructor
		public CfdiTemp()
		{
			Iddocfiscal = 0; 
			Xmlsellado = ""; 
			
		}
		
		[DataMember(IsRequired = true)]
		public Int64 IDDOCFISCAL
		{
			get{ return Iddocfiscal; }
			set
			{
				if(value!=Iddocfiscal)
				{
					
					Iddocfiscal = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string XMLSELLADO
		{
			get{ return Xmlsellado; }
			set
			{
				if(value!=Xmlsellado)
				{
					
					Xmlsellado = value;
				}
			}
		}
	}
}
