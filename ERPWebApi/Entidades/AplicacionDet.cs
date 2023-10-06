using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class AplicacionDet: IEntidadBase
	{
		private Int64 Id;
		private Int64 Idaplicacion;
		private Int16 Idtipoaplicacioncampo;
		private Int16 Idtipoaplicacioncategoria;
		private Int64 Idreferencia;
		private Int32 Idarchivo;
		private Int32 Idimagen;
		private string Texto;
		private DateTime Fecha;
		private decimal Numero;
		private bool Booleano;
		
		
		//Constructor
		public AplicacionDet()
		{
			Id = 0; 
			Idaplicacion = 0; 
			Idtipoaplicacioncampo = 0; 
			Idtipoaplicacioncategoria = 0; 
			Idreferencia = 0; 
			Idarchivo = 0; 
			Idimagen = 0; 
			Texto = ""; 
			Fecha = System.DateTime.Today;
			Numero = 0; 
			Booleano = false; 
			
		}
		
		public Int64 ID
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
		public Int64 IDAPLICACION
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
		[DataMember(IsRequired = true)]
		public Int16 IDTIPOAPLICACIONCAMPO
		{
			get{ return Idtipoaplicacioncampo; }
			set
			{
				if(value!=Idtipoaplicacioncampo)
				{
					Idtipoaplicacioncampo = value;
				}
			}
		}
		public Int16 IDTIPOAPLICACIONCATEGORIA
		{
			get{ return Idtipoaplicacioncategoria; }
			set
			{
				if(value!=Idtipoaplicacioncategoria)
				{
					Idtipoaplicacioncategoria = value;
				}
			}
		}
		public Int64 IDREFERENCIA
		{
			get{ return Idreferencia; }
			set
			{
				if(value!=Idreferencia)
				{
					Idreferencia = value;
				}
			}
		}
		public Int32 IDARCHIVO
		{
			get{ return Idarchivo; }
			set
			{
				if(value!=Idarchivo)
				{
					Idarchivo = value;
				}
			}
		}
		public Int32 IDIMAGEN
		{
			get{ return Idimagen; }
			set
			{
				if(value!=Idimagen)
				{
					Idimagen = value;
				}
			}
		}
		public string TEXTO
		{
			get{ return Texto.ToString().Trim(); }
			set
			{
				if(value!=Texto)
				{
					Texto = value;
				}
			}
		}
		public DateTime FECHA
		{
			get{ return Fecha; }
			set
			{
				if (value != null)
				{
					if(value!=Fecha)
					{
						Fecha = value;
					}
				}
			}
		}
		public decimal NUMERO
		{
			get{ return Numero; }
			set
			{
				if(value!=Numero)
				{
					Numero = value;
				}
			}
		}
		public bool BOOLEANO
		{
			get{ return Booleano; }
			set
			{
				if(value!=Booleano)
				{
					Booleano = value;
				}
			}
		}
	}
}
