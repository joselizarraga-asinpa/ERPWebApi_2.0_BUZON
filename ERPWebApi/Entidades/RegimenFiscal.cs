using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class RegimenFiscal: IEntidadBase
	{
		private Int16 Id;
		private string Nombreregimenfiscal;
		private Int16 Clavesat;
		private bool Fisica;
		private bool Moral;
		
		
		//Constructor
		public RegimenFiscal()
		{
			Id = 0; 
			Nombreregimenfiscal = ""; 
			Clavesat = 0; 
			Fisica = false; 
			Moral = false; 
			
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
		public string NOMBREREGIMENFISCAL
		{
			get{ return Nombreregimenfiscal.ToString().Trim(); }
			set
			{
				if(value!=Nombreregimenfiscal)
				{
					Nombreregimenfiscal = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int16 CLAVESAT
		{
			get{ return Clavesat; }
			set
			{
				if(value!=Clavesat)
				{
					Clavesat = value;
				}
			}
		}
		public bool FISICA
		{
			get{ return Fisica; }
			set
			{
				if(value!=Fisica)
				{
					Fisica = value;
				}
			}
		}
		public bool MORAL
		{
			get{ return Moral; }
			set
			{
				if(value!=Moral)
				{
					Moral = value;
				}
			}
		}
	}
}
