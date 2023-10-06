using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class Funcionalidad: IEntidadBase
	{
		private Int16 Id;
		private string Nombrefuncionalidad;
		
		
		//Constructor
		public Funcionalidad()
		{
			Id = 0; 
			Nombrefuncionalidad = ""; 
			
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
		public string NOMBREFUNCIONALIDAD
		{
			get{ return Nombrefuncionalidad.ToString().Trim(); }
			set
			{
				if(value!=Nombrefuncionalidad)
				{
					Nombrefuncionalidad = value;
				}
			}
		}
	}
}
