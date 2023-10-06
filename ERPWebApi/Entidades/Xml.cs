using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class Xml: IEntidadBase
	{
		private Int64 Iddocfiscal;
		private string Archivoxml;
		
		
		//Constructor
		public Xml()
		{
			Iddocfiscal = 0; 
			Archivoxml = ""; 
			
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
		public string ARCHIVOXML
		{
			get{ return Archivoxml.ToString().Trim(); }
			set
			{
				if(value!=Archivoxml)
				{
					
					Archivoxml = value;
				}
			}
		}
	}
}
