using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class InformeObjeto: IEntidadBase
	{
		private Int32 Id;
		private Int32 Idinforme;
		private string Objeto;
		private string Entidad;
		
		
		//Constructor
		public InformeObjeto()
		{
			Id = 0; 
			Idinforme = 0; 
			Objeto = ""; 
			Entidad = ""; 
			
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
		public Int32 IDINFORME
		{
			get{ return Idinforme; }
			set
			{
				if(value!=Idinforme)
				{
					Idinforme = value;
				}
			}
		}
		public string OBJETO
		{
			get{ return Objeto.ToString().Trim(); }
			set
			{
				if(value!=Objeto)
				{
					Objeto = value;
				}
			}
		}
		public string ENTIDAD
		{
			get{ return Entidad.ToString().Trim(); }
			set
			{
				if(value!=Entidad)
				{
					Entidad = value;
				}
			}
		}
	}
}
