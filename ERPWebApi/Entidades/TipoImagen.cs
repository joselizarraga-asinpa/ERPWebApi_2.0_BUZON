using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class TipoImagen: IEntidadBase
	{
		private Int16 Id;
		private string Nombretipoimagen;
		private string Extensiones;
		
		
		//Constructor
		public TipoImagen()
		{
			Id = 0; 
			Nombretipoimagen = ""; 
			Extensiones = ""; 
			
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
		public string NOMBRETIPOIMAGEN
		{
			get{ return Nombretipoimagen.ToString().Trim(); }
			set
			{
				if(value!=Nombretipoimagen)
				{
					Nombretipoimagen = value;
				}
			}
		}
		public string EXTENSIONES
		{
			get{ return Extensiones.ToString().Trim(); }
			set
			{
				if(value!=Extensiones)
				{
					Extensiones = value;
				}
			}
		}
	}
}
