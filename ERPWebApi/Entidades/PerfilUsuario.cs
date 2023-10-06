using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class PerfilUsuario: IEntidadBase
	{
		private Int16 Id;
		private Int16 Idpincliente;
		private string Nombreperfilusuario;
		
		
		//Constructor
		public PerfilUsuario()
		{
			Id = 0; 
			Idpincliente = 0; 
			Nombreperfilusuario = ""; 
			
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
		public string NOMBREPERFILUSUARIO
		{
			get{ return Nombreperfilusuario.ToString().Trim(); }
			set
			{
				if(value!=Nombreperfilusuario)
				{
					
					Nombreperfilusuario = value;
				}
			}
		}
	}
}
