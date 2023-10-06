using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class DocFiscalCompDet: IEntidadBase
	{
		private Int64 Id;
		private Int64 Iddocfiscal;
		private Int32 Iddocfiscalcomp;
		private string Valor;
		
		
		//Constructor
		public DocFiscalCompDet()
		{
			Id = 0; 
			Iddocfiscal = 0; 
			Iddocfiscalcomp = 0; 
			Valor = ""; 
			
		}
		
		public Int64 ID
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
		public Int32 IDDOCFISCALCOMP
		{
			get{ return Iddocfiscalcomp; }
			set
			{
				if(value!=Iddocfiscalcomp)
				{
					Iddocfiscalcomp = value;
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
