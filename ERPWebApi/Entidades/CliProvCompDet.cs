using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class CliProvCompDet: IEntidadBase
	{
		private Int32 Id;
		private Int32 Idcliprov;
		private Int32 Iddocfiscalcomp;
		private string Valor;
		
		
		//Constructor
		public CliProvCompDet()
		{
			Id = 0; 
			Idcliprov = 0; 
			Iddocfiscalcomp = 0; 
			Valor = ""; 
			
		}
		
		public Int32 ID
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
		public Int32 IDCLIPROV
		{
			get{ return Idcliprov; }
			set
			{
				if(value!=Idcliprov)
				{
					Idcliprov = value;
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
