using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class UsoCFDI: IEntidadBase
	{
		private Int16 Id;
		private string Claveusocfdi;
		private string Nombreusocfdi;
		private bool Aplicafisica;
		private bool Aplicamoral;
		
		
		//Constructor
		public UsoCFDI()
		{
			Id = 0; 
			Claveusocfdi = ""; 
			Nombreusocfdi = ""; 
			Aplicafisica = false; 
			Aplicamoral = false; 
			
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
		public string CLAVEUSOCFDI
		{
			get{ return Claveusocfdi.ToString().Trim(); }
			set
			{
				if(value!=Claveusocfdi)
				{
					Claveusocfdi = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string NOMBREUSOCFDI
		{
			get{ return Nombreusocfdi.ToString().Trim(); }
			set
			{
				if(value!=Nombreusocfdi)
				{
					Nombreusocfdi = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public bool APLICAFISICA
		{
			get{ return Aplicafisica; }
			set
			{
				if(value!=Aplicafisica)
				{
					Aplicafisica = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public bool APLICAMORAL
		{
			get{ return Aplicamoral; }
			set
			{
				if(value!=Aplicamoral)
				{
					Aplicamoral = value;
				}
			}
		}
	}
}
