using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class TimbradoLog: IEntidadBase
	{
		private Int64 Id;
		private Int64 Iddocfiscal;
		private string Msg;
		private DateTime Fecha;
		private Int16 Accion;
		private string Nodocumento;
		
		
		//Constructor
		public TimbradoLog()
		{
			Id = 0; 
			Iddocfiscal = 0; 
			Msg = ""; 
			Fecha = System.DateTime.Today;
			Accion = 1; 
			Nodocumento = ""; 
			
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
		public Int64 IDDOCFISCAL
		{
			get{ return Iddocfiscal; }
			set
			{
				if(value!=Iddocfiscal)
				{
					
					Iddocfiscal = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string MSG
		{
			get{ return Msg.ToString().Trim(); }
			set
			{
				if(value!=Msg)
				{
					
					Msg = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
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
		public Int16 ACCION
		{
			get{ return Accion; }
			set
			{
				if(value!=Accion)
				{
					
					Accion = value;
				}
			}
		}
		public string NODOCUMENTO
		{
			get{ return Nodocumento.ToString().Trim(); }
			set
			{
				if(value!=Nodocumento)
				{
					
					Nodocumento = value;
				}
			}
		}
	}
}
