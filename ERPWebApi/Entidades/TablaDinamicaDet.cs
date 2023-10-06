using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class TablaDinamicaDet: IEntidadBase
	{
		private Int16 Id;
		private Int16 Idtabladinamica;
		private Int32 Idtipodato;
		private string Campo;
		private string Alias;
		private Int32 Localizacion;
		private Int16 Ancho;
		private string Formato;
		private Int16 Tipototal;
		private string Totalencabezado;
		
		
		//Constructor
		public TablaDinamicaDet()
		{
			Id = 0; 
			Idtabladinamica = 0; 
			Idtipodato = 0; 
			Campo = ""; 
			Alias = ""; 
			Localizacion = 0; 
			Ancho = 0; 
			Formato = ""; 
			Tipototal = 0; 
			Totalencabezado = ""; 
			
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
		public Int16 IDTABLADINAMICA
		{
			get{ return Idtabladinamica; }
			set
			{
				if(value!=Idtabladinamica)
				{
					Idtabladinamica = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int32 IDTIPODATO
		{
			get{ return Idtipodato; }
			set
			{
				if(value!=Idtipodato)
				{
					Idtipodato = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string CAMPO
		{
			get{ return Campo.ToString().Trim(); }
			set
			{
				if(value!=Campo)
				{
					Campo = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string ALIAS
		{
			get{ return Alias.ToString().Trim(); }
			set
			{
				if(value!=Alias)
				{
					Alias = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int32 LOCALIZACION
		{
			get{ return Localizacion; }
			set
			{
				if(value!=Localizacion)
				{
					Localizacion = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int16 ANCHO
		{
			get{ return Ancho; }
			set
			{
				if(value!=Ancho)
				{
					Ancho = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string FORMATO
		{
			get{ return Formato.ToString().Trim(); }
			set
			{
				if(value!=Formato)
				{
					Formato = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int16 TIPOTOTAL
		{
			get{ return Tipototal; }
			set
			{
				if(value!=Tipototal)
				{
					Tipototal = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string TOTALENCABEZADO
		{
			get{ return Totalencabezado.ToString().Trim(); }
			set
			{
				if(value!=Totalencabezado)
				{
					Totalencabezado = value;
				}
			}
		}
	}
}
