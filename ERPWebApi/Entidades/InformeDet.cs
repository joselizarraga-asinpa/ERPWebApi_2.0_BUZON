using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class InformeDet: IEntidadBase
	{
		private Int32 Id;
		private Int32 Idinforme;
		private Int16 Idinformeparametro;
		private Int16 Orden;
		
		
		//Constructor
		public InformeDet()
		{
			Id = 0; 
			Idinforme = 0; 
			Idinformeparametro = 0; 
			Orden = 0; 
			
		}
		
		public Int32 ID
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
		public Int32 IDINFORME
		{
			get{ return Idinforme; }
			set
			{
				if(value!=Idinforme)
				{
					
					Idinforme = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int16 IDINFORMEPARAMETRO
		{
			get{ return Idinformeparametro; }
			set
			{
				if(value!=Idinformeparametro)
				{
					
					Idinformeparametro = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int16 ORDEN
		{
			get{ return Orden; }
			set
			{
				if(value!=Orden)
				{
					
					Orden = value;
				}
			}
		}
	}
}
