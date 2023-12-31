using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de c�digo

	public class ProcesoDetCondicion: IEntidadBase
	{
		private Int16 Id;
		private Int16 Idprocesodet;
		private Int16 Idprocesocondicion;
		
		
		//Constructor
		public ProcesoDetCondicion()
		{
			Id = 0; 
			Idprocesodet = 0; 
			Idprocesocondicion = 0; 
			
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
		public Int16 IDPROCESODET
		{
			get{ return Idprocesodet; }
			set
			{
				if(value!=Idprocesodet)
				{
					
					Idprocesodet = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int16 IDPROCESOCONDICION
		{
			get{ return Idprocesocondicion; }
			set
			{
				if(value!=Idprocesocondicion)
				{
					
					Idprocesocondicion = value;
				}
			}
		}
	}
}
