using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class GrupoTipoDoc: IEntidadBase
	{
		private Int16 Id;
		private Int16 Idmodulo;
		private string Nombregrupotipodoc;
		
		
		//Constructor
		public GrupoTipoDoc()
		{
			Id = 0; 
			Idmodulo = 0; 
			Nombregrupotipodoc = ""; 
			
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
		public Int16 IDMODULO
		{
			get{ return Idmodulo; }
			set
			{
				if(value!=Idmodulo)
				{
					
					Idmodulo = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string NOMBREGRUPOTIPODOC
		{
			get{ return Nombregrupotipodoc.ToString().Trim(); }
			set
			{
				if(value!=Nombregrupotipodoc)
				{
					
					Nombregrupotipodoc = value;
				}
			}
		}
	}
}
