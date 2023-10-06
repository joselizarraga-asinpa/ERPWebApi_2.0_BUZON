using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class Archivo: IEntidadBase
	{
		private Int32 Id;
		private string Nombrearchivo;
		private byte[] Contenidoarchivo;
		
		
		//Constructor
		public Archivo()
		{
			Id = 0; 
			Nombrearchivo = ""; 
			Contenidoarchivo = Array.Empty<byte>(); 
			
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
		public string NOMBREARCHIVO
		{
			get{ return Nombrearchivo.ToString().Trim(); }
			set
			{
				if(value!=Nombrearchivo)
				{
					Nombrearchivo = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public byte[] CONTENIDOARCHIVO
		{
			get{ return Contenidoarchivo; }
			set
			{
				if(value!=Contenidoarchivo)
				{
					Contenidoarchivo = value;
				}
			}
		}
	}
}
