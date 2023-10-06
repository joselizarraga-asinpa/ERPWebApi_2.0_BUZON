using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class GrupoGrafica: IEntidadBase
	{
		private Int16 Id;
		private string Nombregrupografica;
		
		
		//Constructor
		public GrupoGrafica()
		{
			Id = 0; 
			Nombregrupografica = ""; 
			
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
		public string NOMBREGRUPOGRAFICA
		{
			get{ return Nombregrupografica.ToString().Trim(); }
			set
			{
				if(value!=Nombregrupografica)
				{
					Nombregrupografica = value;
				}
			}
		}
	}
}
