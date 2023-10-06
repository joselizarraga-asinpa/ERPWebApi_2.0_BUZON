using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class Imagen: IEntidadBase
	{
		private Int32 Id;
		private string Nombreimagen;
		private byte[] Contenidoimagen;
		
		
		//Constructor
		public Imagen()
		{
			Id = 0; 
			Nombreimagen = ""; 
			Contenidoimagen = Array.Empty<byte>(); 
			
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
		public string NOMBREIMAGEN
		{
			get{ return Nombreimagen.ToString().Trim(); }
			set
			{
				if(value!=Nombreimagen)
				{
					Nombreimagen = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public byte[] CONTENIDOIMAGEN
		{
			get{ return Contenidoimagen; }
			set
			{
				if(value!=Contenidoimagen)
				{
					Contenidoimagen = value;
				}
			}
		}
	}
}
