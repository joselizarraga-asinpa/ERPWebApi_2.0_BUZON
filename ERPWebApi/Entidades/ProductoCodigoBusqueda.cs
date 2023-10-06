using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class ProductoCodigoBusqueda: IEntidadBase
	{
		private Int32 Idproducto;
		private string Nombreproducto;
		
		
		//Constructor
		public ProductoCodigoBusqueda()
		{
			Idproducto = 0; 
			Nombreproducto = ""; 
			
		}
		
		[DataMember(IsRequired = true)]
		public Int32 IDPRODUCTO
		{
			get{ return Idproducto; }
			set
			{
				if(value!=Idproducto)
				{
					Idproducto = value;
				}
			}
		}
		public string NOMBREPRODUCTO
		{
			get{ return Nombreproducto.ToString().Trim(); }
			set
			{
				if(value!=Nombreproducto)
				{
					Nombreproducto = value;
				}
			}
		}
	}
}
