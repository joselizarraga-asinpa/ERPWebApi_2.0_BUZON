using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class IdiomaInterfaz: IEntidadBase
	{
		private Int32 Id;
		private Int16 Ididioma;
		private Int16 Idfuncionalidad;
		private Int16 Idaplicacion;        
        private Int16 Referencia;
		private string Control;
		private string Columna;
		private string Descripcion;
		
		
		//Constructor
		public IdiomaInterfaz()
		{
			Id = 0; 
			Ididioma = 0; 
			Idfuncionalidad = 0; 
			Idaplicacion = 0;            
            Referencia = 0; 
			Control = ""; 
			Columna = ""; 
			Descripcion = ""; 
			
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
		public Int16 IDIDIOMA
		{
			get{ return Ididioma; }
			set
			{
				if(value!=Ididioma)
				{
					
					Ididioma = value;
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
		public Int16 IDAPLICACION
		{
			get{ return Idaplicacion; }
			set
			{
				if(value!=Idaplicacion)
				{
					
					Idaplicacion = value;
				}
			}
		}        
        public Int16 REFERENCIA
		{
			get{ return Referencia; }
			set
			{
				if(value!=Referencia)
				{
					
					Referencia = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string CONTROL
		{
			get{ return Control.ToString().Trim(); }
			set
			{
				if(value!=Control)
				{
					
					Control = value;
				}
			}
		}
		public string COLUMNA
		{
			get{ return Columna.ToString().Trim(); }
			set
			{
				if(value!=Columna)
				{
					
					Columna = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string DESCRIPCION
		{
			get{ return Descripcion.ToString().Trim(); }
			set
			{
				if(value!=Descripcion)
				{
					
					Descripcion = value;
				}
			}
		}
	}
}
