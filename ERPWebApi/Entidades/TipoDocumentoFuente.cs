using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class TipoDocumentoFuente: IEntidadBase
	{
		private Int64 Idtipodocumento;
		private Int16 Idpincliente;
		private string Nombretipodoc;
		
		
		//Constructor
		public TipoDocumentoFuente()
		{
			Idtipodocumento = 0; 
			Idpincliente = 0; 
			Nombretipodoc = ""; 
			
		}
		
		public Int64 IDTIPODOCUMENTO
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
		public string NOMBRETIPODOC
		{
			get{ return Nombretipodoc.ToString().Trim(); }
			set
			{
				if(value!=Nombretipodoc)
				{
					
					Nombretipodoc = value;
				}
			}
		}
	}
}
