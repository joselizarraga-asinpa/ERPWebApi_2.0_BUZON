using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class TemaComponente: IEntidadBase
	{
		private Int16 Id;
		private string Nombretemacomponente;
		
		
		//Constructor
		public TemaComponente()
		{
			Id = 0; 
			Nombretemacomponente = ""; 
			
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
		public string NOMBRETEMACOMPONENTE
		{
			get{ return Nombretemacomponente.ToString().Trim(); }
			set
			{
				if(value!=Nombretemacomponente)
				{
					
					Nombretemacomponente = value;
				}
			}
		}
	}
}
