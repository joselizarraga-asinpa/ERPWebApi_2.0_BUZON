using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class ProcesoCondicion: IEntidadBase
	{
		private Int16 Id;
		private Int16 Idpincliente;
		private Int16 Idfuncionalidad;
		private Int64 Idfuncionalidadref;
		private Int16 Idfuncionalidadfuente;
		private Int64 Idfuncionalidadfuenteref;
		private Int32 Idclasificacion;
		private string Nombreprocesocondicion;
		
		
		//Constructor
		public ProcesoCondicion()
		{
			Id = 0; 
			Idpincliente = 0; 
			Idfuncionalidad = 0; 
			Idfuncionalidadref = 0; 
			Idfuncionalidadfuente = 0; 
			Idfuncionalidadfuenteref = 0; 
			Idclasificacion = 0; 
			Nombreprocesocondicion = ""; 
			
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
		public Int64 IDFUNCIONALIDADREF
		{
			get{ return Idfuncionalidadref; }
			set
			{
				if(value!=Idfuncionalidadref)
				{
					
					Idfuncionalidadref = value;
				}
			}
		}
		public Int16 IDFUNCIONALIDADFUENTE
		{
			get{ return Idfuncionalidadfuente; }
			set
			{
				if(value!=Idfuncionalidadfuente)
				{
					
					Idfuncionalidadfuente = value;
				}
			}
		}
		public Int64 IDFUNCIONALIDADFUENTEREF
		{
			get{ return Idfuncionalidadfuenteref; }
			set
			{
				if(value!=Idfuncionalidadfuenteref)
				{
					
					Idfuncionalidadfuenteref = value;
				}
			}
		}
		public Int32 IDCLASIFICACION
		{
			get{ return Idclasificacion; }
			set
			{
				if(value!=Idclasificacion)
				{
					
					Idclasificacion = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string NOMBREPROCESOCONDICION
		{
			get{ return Nombreprocesocondicion.ToString().Trim(); }
			set
			{
				if(value!=Nombreprocesocondicion)
				{
					
					Nombreprocesocondicion = value;
				}
			}
		}
	}
}
