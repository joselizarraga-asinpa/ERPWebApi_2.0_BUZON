using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class DocFiscalRel: IEntidadBase
	{
		private Int64 Iddocfiscal;
		private Int64 Iddocfiscalrel;
		
		
		//Constructor
		public DocFiscalRel()
		{
			Iddocfiscal = 0; 
			Iddocfiscalrel = 0; 
			
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
		public Int64 IDDOCFISCALREL
		{
			get{ return Iddocfiscalrel; }
			set
			{
				if(value!=Iddocfiscalrel)
				{
					Iddocfiscalrel = value;
				}
			}
		}
	}
}
