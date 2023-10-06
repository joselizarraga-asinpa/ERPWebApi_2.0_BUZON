using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class PerfilUsuarioTipoDoc: IEntidadBase
	{
		private Int16 Id;
		private Int16 Idperfilusuario;
		private Int16 Idtipodocumento;
		private string Permiso;
		
		
		//Constructor
		public PerfilUsuarioTipoDoc()
		{
			Id = 0; 
			Idperfilusuario = 0; 
			Idtipodocumento = 0; 
			Permiso = ""; 
			
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
		[DataMember(IsRequired = true)]
		public Int16 IDTIPODOCUMENTO
		{
			get{ return Idtipodocumento; }
			set
			{
				if(value!=Idtipodocumento)
				{
					
					Idtipodocumento = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string PERMISO
		{
			get{ return Permiso.ToString().Trim(); }
			set
			{
				if(value!=Permiso)
				{
					
					Permiso = value;
				}
			}
		}
	}
}
