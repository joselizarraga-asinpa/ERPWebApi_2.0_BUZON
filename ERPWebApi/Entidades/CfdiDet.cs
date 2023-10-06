using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class CFDIDet: IEntidadBase
	{
		private Int64 Iddocfiscal;
		private string Satclaveprod;
		private string Noidentificacion;
		private decimal Cantidad;
		private string Satclaveunidad;
		private string Unidad;
		private string Descripcion;
		private decimal Valorunitario;
		private decimal Importe;
		private decimal Descuento;
		private string Lote;
		private string Caducidad;
		private string Proveedor;
		private string Tipodescuento;
		private string Publico;
		private string Obs;
		private decimal Base;
		private string Impuesto;
		private string Tipofactor;
		private decimal Tasa;
		private decimal Importeimpuesto;
		private Int32 Registro;
		
		
		//Constructor
		public CFDIDet()
		{
			Iddocfiscal = 0; 
			Satclaveprod = ""; 
			Noidentificacion = ""; 
			Cantidad = 0; 
			Satclaveunidad = ""; 
			Unidad = ""; 
			Descripcion = ""; 
			Valorunitario = 0; 
			Importe = 0; 
			Descuento = 0; 
			Lote = ""; 
			Caducidad = ""; 
			Proveedor = ""; 
			Tipodescuento = ""; 
			Publico = ""; 
			Obs = ""; 
			Base = 0; 
			Impuesto = ""; 
			Tipofactor = ""; 
			Tasa = 0; 
			Importeimpuesto = 0; 
			Registro = 0; 
			
		}
		
		[DataMember(IsRequired = true)]
		public Int64 IDDOCFISCAL
		{
			get{ return Iddocfiscal; }
			set
			{
				if(value!=Iddocfiscal)
				{
					Iddocfiscal = value;
				}
			}
		}
		public string SATCLAVEPROD
		{
			get{ return Satclaveprod.ToString().Trim(); }
			set
			{
				if(value!=Satclaveprod)
				{
					Satclaveprod = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string NOIDENTIFICACION
		{
			get{ return Noidentificacion.ToString().Trim(); }
			set
			{
				if(value!=Noidentificacion)
				{
					Noidentificacion = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public decimal CANTIDAD
		{
			get{ return Cantidad; }
			set
			{
				if(value!=Cantidad)
				{
					Cantidad = value;
				}
			}
		}
		public string SATCLAVEUNIDAD
		{
			get{ return Satclaveunidad.ToString().Trim(); }
			set
			{
				if(value!=Satclaveunidad)
				{
					Satclaveunidad = value;
				}
			}
		}
		public string UNIDAD
		{
			get{ return Unidad.ToString().Trim(); }
			set
			{
				if(value!=Unidad)
				{
					Unidad = value;
				}
			}
		}
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
		public decimal VALORUNITARIO
		{
			get{ return Valorunitario; }
			set
			{
				if(value!=Valorunitario)
				{
					Valorunitario = value;
				}
			}
		}
		public decimal IMPORTE
		{
			get{ return Importe; }
			set
			{
				if(value!=Importe)
				{
					Importe = value;
				}
			}
		}
		public decimal DESCUENTO
		{
			get{ return Descuento; }
			set
			{
				if(value!=Descuento)
				{
					Descuento = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string LOTE
		{
			get{ return Lote.ToString().Trim(); }
			set
			{
				if(value!=Lote)
				{
					Lote = value;
				}
			}
		}
		public string CADUCIDAD
		{
			get{ return Caducidad.ToString().Trim(); }
			set
			{
				if(value!=Caducidad)
				{
					Caducidad = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string PROVEEDOR
		{
			get{ return Proveedor.ToString().Trim(); }
			set
			{
				if(value!=Proveedor)
				{
					Proveedor = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string TIPODESCUENTO
		{
			get{ return Tipodescuento.ToString().Trim(); }
			set
			{
				if(value!=Tipodescuento)
				{
					Tipodescuento = value;
				}
			}
		}
		public string PUBLICO
		{
			get{ return Publico.ToString().Trim(); }
			set
			{
				if(value!=Publico)
				{
					Publico = value;
				}
			}
		}
		public string OBS
		{
			get{ return Obs.ToString().Trim(); }
			set
			{
				if(value!=Obs)
				{
					Obs = value;
				}
			}
		}
		public decimal BASE
		{
			get{ return Base; }
			set
			{
				if(value!=Base)
				{
					Base = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string IMPUESTO
		{
			get{ return Impuesto.ToString().Trim(); }
			set
			{
				if(value!=Impuesto)
				{
					Impuesto = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string TIPOFACTOR
		{
			get{ return Tipofactor.ToString().Trim(); }
			set
			{
				if(value!=Tipofactor)
				{
					Tipofactor = value;
				}
			}
		}
		public decimal TASA
		{
			get{ return Tasa; }
			set
			{
				if(value!=Tasa)
				{
					Tasa = value;
				}
			}
		}
		public decimal IMPORTEIMPUESTO
		{
			get{ return Importeimpuesto; }
			set
			{
				if(value!=Importeimpuesto)
				{
					Importeimpuesto = value;
				}
			}
		}
		public Int32 REGISTRO
		{
			get{ return Registro; }
			set
			{
				if(value!=Registro)
				{
					Registro = value;
				}
			}
		}
	}
}
