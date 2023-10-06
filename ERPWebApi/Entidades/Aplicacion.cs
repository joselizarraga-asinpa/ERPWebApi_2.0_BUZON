using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class Aplicacion: IEntidadBase
	{
		private Int64 Id;
		private Int16 Idtipoaplicacion;
		private Int64 Idaplicacionfuente;
		private Int64 Idreferencia;
		private Int64 Folio;
		private DateTime Fecha;
		private string Obs;
		
		
		//Constructor
		public Aplicacion()
		{
			Id = 0; 
			Idtipoaplicacion = 0; 
			Idaplicacionfuente = 0; 
			Idreferencia = 0; 
			Folio = 0; 
			Fecha = System.DateTime.Today;
			Obs = ""; 
			
		}
		
		public Int64 ID
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
		public Int64 IDAPLICACIONFUENTE
		{
			get{ return Idaplicacionfuente; }
			set
			{
				if(value!=Idaplicacionfuente)
				{
					Idaplicacionfuente = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int64 IDREFERENCIA
		{
			get{ return Idreferencia; }
			set
			{
				if(value!=Idreferencia)
				{
					Idreferencia = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int64 FOLIO
		{
			get{ return Folio; }
			set
			{
				if(value!=Folio)
				{
					Folio = value;
				}
			}
		}
		public DateTime FECHA
		{
			get{ return Fecha; }
			set
			{
				if (value != null)
				{
					if(value!=Fecha)
					{
						Fecha = value;
					}
				}
			}
		}
		public string OBS
		{
			get{ return Obs.ToString().Trim(); }
			set
			{
				if(value!=Obs)
				{
					Obs = value;
				}
			}
		}
	}
}
