using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class TipoDocSucursal: IEntidadBase
	{
		private Int16 Idtipodocumento;
		private Int16 Idsucursal;
		private string Serie;
		
		
		//Constructor
		public TipoDocSucursal()
		{
			Idtipodocumento = 0; 
			Idsucursal = 0; 
			Serie = ""; 
			
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
		public string SERIE
		{
			get{ return Serie.ToString().Trim(); }
			set
			{
				if(value!=Serie)
				{
					Serie = value;
				}
			}
		}
	}
}
