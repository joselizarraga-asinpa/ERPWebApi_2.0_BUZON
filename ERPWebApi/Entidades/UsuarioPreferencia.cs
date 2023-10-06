using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class UsuarioPreferencia: IEntidadBase
	{
		private Int16 Idusuario;
		private Int16 Idpreferencia;
		private string Valor;
		
		
		//Constructor
		public UsuarioPreferencia()
		{
			Idusuario = 0; 
			Idpreferencia = 0; 
			Valor = ""; 
			
		}
		
		[DataMember(IsRequired = true)]
		public Int16 IDUSUARIO
		{
			get{ return Idusuario; }
			set
			{
				if(value!=Idusuario)
				{
					Idusuario = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int16 IDPREFERENCIA
		{
			get{ return Idpreferencia; }
			set
			{
				if(value!=Idpreferencia)
				{
					Idpreferencia = value;
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
