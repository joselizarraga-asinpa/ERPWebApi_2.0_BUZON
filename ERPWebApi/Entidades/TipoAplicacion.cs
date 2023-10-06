using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class TipoAplicacion: IEntidadBase
	{
		private Int16 Id;
		private Int16 Idpincliente;
		private Int16 Idgrupoaplicacion;
		private Int16 Idfuncionalidad;
		private Int16 Idtipodocumento;
		private string Nombretipoaplicacion;
		private byte[] Icono;
		private string Menu;
		private bool Multiplesregistros;
		private string Xml;
		
		
		//Constructor
		public TipoAplicacion()
		{
			Id = 0; 
			Idpincliente = 0; 
			Idgrupoaplicacion = 0; 
			Idfuncionalidad = 0; 
			Idtipodocumento = 0; 
			Nombretipoaplicacion = "";
            Icono = Array.Empty<byte>();
            Menu = ""; 
			Multiplesregistros = false; 
			Xml = ""; 
			
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
		public Int16 IDGRUPOAPLICACION
		{
			get{ return Idgrupoaplicacion; }
			set
			{
				if(value!=Idgrupoaplicacion)
				{
					Idgrupoaplicacion = value;
				}
			}
		}
		public Int16 IDFUNCIONALIDAD
		{
			get{ return Idfuncionalidad; }
			set
			{
				if(value!=Idfuncionalidad)
				{
					Idfuncionalidad = value;
				}
			}
		}
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
		public string NOMBRETIPOAPLICACION
		{
			get{ return Nombretipoaplicacion.ToString().Trim(); }
			set
			{
				if(value!=Nombretipoaplicacion)
				{
					Nombretipoaplicacion = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public byte[] ICONO
		{
			get{ return Icono; }
			set
			{
				if(value!=Icono)
				{
					Icono = value;
				}
			}
		}
		public string MENU
		{
			get{ return Menu.ToString().Trim(); }
			set
			{
				if(value!=Menu)
				{
					Menu = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public bool MULTIPLESREGISTROS
		{
			get{ return Multiplesregistros; }
			set
			{
				if(value!=Multiplesregistros)
				{
					Multiplesregistros = value;
				}
			}
		}
		public string XML
		{
			get{ return Xml.ToString().Trim(); }
			set
			{
				if(value!=Xml)
				{
					Xml = value;
				}
			}
		}
	}
}
