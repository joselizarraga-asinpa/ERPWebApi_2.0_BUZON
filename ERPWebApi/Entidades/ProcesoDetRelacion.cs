using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class ProcesoDetRelacion: IEntidadBase
	{
		private Int16 Id;
		private Int16 Idprocesodet;
		private Int16 Idprocesodetpadre;
		
		
		//Constructor
		public ProcesoDetRelacion()
		{
			Id = 0; 
			Idprocesodet = 0; 
			Idprocesodetpadre = 0; 
			
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
		public Int16 IDPROCESODETPADRE
		{
			get{ return Idprocesodetpadre; }
			set
			{
				if(value!=Idprocesodetpadre)
				{
					
					Idprocesodetpadre = value;
				}
			}
		}
	}
}
