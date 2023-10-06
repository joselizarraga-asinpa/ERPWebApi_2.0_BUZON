using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class SucursalConfig: IEntidadBase
	{
		private Int64 Id;
		private Int16 Idempresa;
		private Int16 Idsucursal;
		private string Variable;
		private string Valor;
		
		
		//Constructor
		public SucursalConfig()
		{
			Id = 0; 
			Idempresa = 0; 
			Idsucursal = 0; 
			Variable = ""; 
			Valor = ""; 
			
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
		public Int16 IDEMPRESA
		{
			get{ return Idempresa; }
			set
			{
				if(value!=Idempresa)
				{
					Idempresa = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int16 IDSUCURSAL
		{
			get{ return Idsucursal; }
			set
			{
				if(value!=Idsucursal)
				{
					Idsucursal = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string VARIABLE
		{
			get{ return Variable.ToString().Trim(); }
			set
			{
				if(value!=Variable)
				{
					Variable = value;
				}
			}
		}
		public string VALOR
		{
			get{ return Valor.ToString().Trim(); }
			set
			{
				if(value!=Valor)
				{
					Valor = value;
				}
			}
		}
	}
}
