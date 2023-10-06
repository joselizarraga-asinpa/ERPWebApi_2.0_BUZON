using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class CFDIRelacion: IEntidadBase
	{
		private Int64 Iddocfiscal;
		private string Nodocumento;
		
		
		//Constructor
		public CFDIRelacion()
		{
			Iddocfiscal = 0; 
			Nodocumento = ""; 
			
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
		public string NODOCUMENTO
		{
			get{ return Nodocumento.ToString().Trim(); }
			set
			{
				if(value!=Nodocumento)
				{
					Nodocumento = value;
				}
			}
		}
	}
}
