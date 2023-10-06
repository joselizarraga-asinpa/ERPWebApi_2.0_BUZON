using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class CondicionPago: IEntidadBase
	{
		private Int16 Id;
		private string Nombrecondicionpago;
		private string Condiciones;
		private string Clavesat;
		
		
		//Constructor
		public CondicionPago()
		{
			Id = 0; 
			Nombrecondicionpago = ""; 
			Condiciones = ""; 
			Clavesat = ""; 
			
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
		public string NOMBRECONDICIONPAGO
		{
			get{ return Nombrecondicionpago.ToString().Trim(); }
			set
			{
				if(value!=Nombrecondicionpago)
				{
					Nombrecondicionpago = value;
				}
			}
		}
		public string CONDICIONES
		{
			get{ return Condiciones.ToString().Trim(); }
			set
			{
				if(value!=Condiciones)
				{
					Condiciones = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string CLAVESAT
		{
			get{ return Clavesat.ToString().Trim(); }
			set
			{
				if(value!=Clavesat)
				{
					Clavesat = value;
				}
			}
		}
	}
}
