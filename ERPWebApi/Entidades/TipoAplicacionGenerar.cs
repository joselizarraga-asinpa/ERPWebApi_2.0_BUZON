using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class TipoAplicacionGenerar: IEntidadBase
	{
		private Int16 Id;
		private Int16 Idtipoaplicacion;
		private Int16 Idtipoaplicaciongenerar;
		
		
		//Constructor
		public TipoAplicacionGenerar()
		{
			Id = 0; 
			Idtipoaplicacion = 0; 
			Idtipoaplicaciongenerar = 0; 
			
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
		public Int16 IDTIPOAPLICACION
		{
			get{ return Idtipoaplicacion; }
			set
			{
				if(value!=Idtipoaplicacion)
				{
					Idtipoaplicacion = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int16 IDTIPOAPLICACIONGENERAR
		{
			get{ return Idtipoaplicaciongenerar; }
			set
			{
				if(value!=Idtipoaplicaciongenerar)
				{
					Idtipoaplicaciongenerar = value;
				}
			}
		}
	}
}
