using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class Pdf: IEntidadBase
	{
		private Int64 Iddocfiscal;
		private byte[] Archivopdf;
		
		
		//Constructor
		public Pdf()
		{
			Iddocfiscal = 0; 
			Archivopdf = null; 
			
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
		public byte[] ARCHIVOPDF
		{
			get{ return Archivopdf; }
			set
			{
				if(value!=Archivopdf)
				{
					
					Archivopdf = value;
				}
			}
		}
	}
}
