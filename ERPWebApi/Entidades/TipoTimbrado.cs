using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class TipoTimbrado: IEntidadBase
	{
		private Int16 Id;
		private string Nombretipotimbrado;
		private string Ingreso;
		
		
		//Constructor
		public TipoTimbrado()
		{
			Id = 0; 
			Nombretipotimbrado = ""; 
			Ingreso = ""; 
			
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
		public string NOMBRETIPOTIMBRADO
		{
			get{ return Nombretipotimbrado.ToString().Trim(); }
			set
			{
				if(value!=Nombretipotimbrado)
				{
					Nombretipotimbrado = value;
				}
			}
		}
		public string INGRESO
		{
			get{ return Ingreso.ToString().Trim(); }
			set
			{
				if(value!=Ingreso)
				{
					Ingreso = value;
				}
			}
		}
	}
}
