using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class Recordatorios: IEntidadBase
	{
		private Int32 Id;
		private Int32 Idref;
		private string Funcionalidad;
		private string Recordatorio;
		private string Aplicara;
		private DateTime Fecharecordatorio;
		
		
		//Constructor
		public Recordatorios()
		{
			Id = 0; 
			Idref = 0; 
			Funcionalidad = ""; 
			Recordatorio = ""; 
			Aplicara = ""; 
			Fecharecordatorio = System.DateTime.Today;
			
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
		public Int32 IDREF
		{
			get{ return Idref; }
			set
			{
				if(value!=Idref)
				{
					Idref = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string FUNCIONALIDAD
		{
			get{ return Funcionalidad.ToString().Trim(); }
			set
			{
				if(value!=Funcionalidad)
				{
					Funcionalidad = value;
				}
			}
		}
		public string RECORDATORIO
		{
			get{ return Recordatorio.ToString().Trim(); }
			set
			{
				if(value!=Recordatorio)
				{
					Recordatorio = value;
				}
			}
		}
		public string APLICARA
		{
			get{ return Aplicara.ToString().Trim(); }
			set
			{
				if(value!=Aplicara)
				{
					Aplicara = value;
				}
			}
		}
		public DateTime FECHARECORDATORIO
		{
			get{ return Fecharecordatorio; }
			set
			{
				if (value != null)
				{
					if(value!=Fecharecordatorio)
					{
						Fecharecordatorio = value;
					}
				}
			}
		}
	}
}
