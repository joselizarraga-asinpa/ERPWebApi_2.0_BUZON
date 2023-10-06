using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class GrupoAplicacion: IEntidadBase
	{
		private Int16 Id;
		private Int16 Idpincliente;
		private string Nombregrupoapl;
		
		
		//Constructor
		public GrupoAplicacion()
		{
			Id = 0; 
			Idpincliente = 0; 
			Nombregrupoapl = ""; 
			
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
		public Int16 IDPINCLIENTE
		{
			get{ return Idpincliente; }
			set
			{
				if(value!=Idpincliente)
				{
					Idpincliente = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string NOMBREGRUPOAPL
		{
			get{ return Nombregrupoapl.ToString().Trim(); }
			set
			{
				if(value!=Nombregrupoapl)
				{
					Nombregrupoapl = value;
				}
			}
		}
	}
}
