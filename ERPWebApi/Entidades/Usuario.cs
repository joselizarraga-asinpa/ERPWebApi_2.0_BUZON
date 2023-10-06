using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class Usuario: IEntidadBase
	{
		private Int16 Id;
		private Int16 Idpincliente;
		private Int16 Idusuariocreacion;
		private Int16 Idperfilusuario;
		private Int16 Idstatus;
		private Int16 Idpersonal;		
		private string Nombreusuario;
		private string Email;
		private string Password;
		
		
		//Constructor
		public Usuario()
		{
			Id = 0; 
			Idpincliente = 0; 
			Idusuariocreacion = 0; 
			Idperfilusuario = 0; 
			Idstatus = 0; 
			Idpersonal = 0; 			
			Nombreusuario = ""; 
			Email = ""; 
			Password = ""; 
			
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
		public Int16 IDUSUARIOCREACION
		{
			get{ return Idusuariocreacion; }
			set
			{
				if(value!=Idusuariocreacion)
				{
					
					Idusuariocreacion = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int16 IDPERFILUSUARIO
		{
			get{ return Idperfilusuario; }
			set
			{
				if(value!=Idperfilusuario)
				{
					
					Idperfilusuario = value;
				}
			}
		}
		public Int16 IDSTATUS
		{
			get{ return Idstatus; }
			set
			{
				if(value!=Idstatus)
				{
					
					Idstatus = value;
				}
			}
		}
		public Int16 IDPERSONAL
		{
			get{ return Idpersonal; }
			set
			{
				if(value!=Idpersonal)
				{
					
					Idpersonal = value;
				}
			}
		}		
		[DataMember(IsRequired = true)]
		public string NOMBREUSUARIO
		{
			get{ return Nombreusuario.ToString().Trim(); }
			set
			{
				if(value!=Nombreusuario)
				{
					
					Nombreusuario = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string EMAIL
		{
			get{ return Email.ToString().Trim(); }
			set
			{
				if(value!=Email)
				{
					
					Email = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string PASSWORD
		{
			get{ return Password.ToString().Trim(); }
			set
			{
				if(value!=Password)
				{
					
					Password = value;
				}
			}
		}
	}
}
