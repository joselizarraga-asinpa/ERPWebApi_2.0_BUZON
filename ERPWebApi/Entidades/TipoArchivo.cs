using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class TipoArchivo: IEntidadBase
	{
		private Int16 Id;
		private string Nombretipoarchivo;
		private string Extensiones;
		
		
		//Constructor
		public TipoArchivo()
		{
			Id = 0; 
			Nombretipoarchivo = ""; 
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
		public string NOMBRETIPOARCHIVO
		{
			get{ return Nombretipoarchivo.ToString().Trim(); }
			set
			{
				if(value!=Nombretipoarchivo)
				{
					Nombretipoarchivo = value;
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
