using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class EstadoPais: IEntidadBase
	{
		private Int32 Id;
		private Int16 Idpais;
		private string Nombreestadopais;
		
		
		//Constructor
		public EstadoPais()
		{
			Id = 0; 
			Idpais = 0; 
			Nombreestadopais = ""; 
			
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
		public Int16 IDPAIS
		{
			get{ return Idpais; }
			set
			{
				if(value!=Idpais)
				{
					
					Idpais = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string NOMBREESTADOPAIS
		{
			get{ return Nombreestadopais.ToString().Trim(); }
			set
			{
				if(value!=Nombreestadopais)
				{
					
					Nombreestadopais = value;
				}
			}
		}
	}
}
