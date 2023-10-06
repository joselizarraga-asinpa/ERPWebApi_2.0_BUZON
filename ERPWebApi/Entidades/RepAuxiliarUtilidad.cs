using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class RepAuxiliarUtilidad: IEntidadBase
	{
		private DateTime Desde;
		private DateTime Hasta;
		private Int16 Idempresa;
		private string Empresa;
		private Int16 Idsucursal;
		private string Sucursal;
		private string Cliente;
        private string ClasCliente;
        private string Ejecutivo;
		private string Producto;
        private string ClasProducto;
        private string Tipoprodser;
		private string Codigo;
		private string Foliodocumento;
		private Int32 Anio;
		private string Mes;
		private string Servicioproducto;
		private decimal Cantidad;
		private decimal Precio;
		private decimal Totalventa;
		private decimal Costo;
		private decimal Totalcosto;
		private decimal Utilidad;
		
		
		//Constructor
		public RepAuxiliarUtilidad()
		{
			Desde = System.DateTime.Today;
			Hasta = System.DateTime.Today;
			Idempresa = 0; 
			Empresa = ""; 
			Idsucursal = 0; 
			Sucursal = ""; 
			Cliente = "";
            ClasCliente = "";
            Ejecutivo = ""; 
			Producto = "";
            ClasProducto = "";
            Tipoprodser = ""; 
			Codigo = ""; 
			Foliodocumento = ""; 
			Anio = 0; 
			Mes = ""; 
			Servicioproducto = ""; 
			Cantidad = 0; 
			Precio = 0; 
			Totalventa = 0; 
			Costo = 0; 
			Totalcosto = 0; 
			Utilidad = 0; 
			
		}
		
		public DateTime DESDE
		{
			get{ return Desde; }
			set
			{
				if (value != null)
				{
					if(value!=Desde)
					{
						Desde = value;
					}
				}
			}
		}
		public DateTime HASTA
		{
			get{ return Hasta; }
			set
			{
				if (value != null)
				{
					if(value!=Hasta)
					{
						Hasta = value;
					}
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int16 IDEMPRESA
		{
			get{ return Idempresa; }
			set
			{
				if(value!=Idempresa)
				{
					Idempresa = value;
				}
			}
		}
		public string EMPRESA
		{
			get{ return Empresa.ToString().Trim(); }
			set
			{
				if(value!=Empresa)
				{
					Empresa = value;
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
		public string SUCURSAL
		{
			get{ return Sucursal.ToString().Trim(); }
			set
			{
				if(value!=Sucursal)
				{
					Sucursal = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string CLIENTE
		{
			get{ return Cliente.ToString().Trim(); }
			set
			{
				if(value!=Cliente)
				{
					Cliente = value;
				}
			}
		}
        [DataMember(IsRequired = true)]
        public string CLASCLIENTE
        {
            get { return ClasCliente.ToString().Trim(); }
            set
            {
                if (value != ClasCliente)
                {
                    ClasCliente = value;
                }
            }
        }
        [DataMember(IsRequired = true)]
		public string EJECUTIVO
		{
			get{ return Ejecutivo.ToString().Trim(); }
			set
			{
				if(value!=Ejecutivo)
				{
					Ejecutivo = value;
				}
			}
		}
        public string PRODUCTO
        {
            get { return Producto.ToString().Trim(); }
            set
            {
                if (value != Producto)
                {
                    Producto = value;
                }
            }
        }
        public string CLASPRODUCTO
		{
			get{ return ClasProducto.ToString().Trim(); }
			set
			{
				if(value!= ClasProducto)
				{
                    ClasProducto = value;
				}
			}
		}
		public string TIPOPRODSER
		{
			get{ return Tipoprodser.ToString().Trim(); }
			set
			{
				if(value!=Tipoprodser)
				{
					Tipoprodser = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string CODIGO
		{
			get{ return Codigo.ToString().Trim(); }
			set
			{
				if(value!=Codigo)
				{
					Codigo = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string FOLIODOCUMENTO
		{
			get{ return Foliodocumento.ToString().Trim(); }
			set
			{
				if(value!=Foliodocumento)
				{
					Foliodocumento = value;
				}
			}
		}
		public Int32 ANIO
		{
			get{ return Anio; }
			set
			{
				if(value!=Anio)
				{
					Anio = value;
				}
			}
		}
		public string MES
		{
			get{ return Mes.ToString().Trim(); }
			set
			{
				if(value!=Mes)
				{
					Mes = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string SERVICIOPRODUCTO
		{
			get{ return Servicioproducto.ToString().Trim(); }
			set
			{
				if(value!=Servicioproducto)
				{
					Servicioproducto = value;
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
		public decimal PRECIO
		{
			get{ return Precio; }
			set
			{
				if(value!=Precio)
				{
					Precio = value;
				}
			}
		}
		public decimal TOTALVENTA
		{
			get{ return Totalventa; }
			set
			{
				if(value!=Totalventa)
				{
					Totalventa = value;
				}
			}
		}
		public decimal COSTO
		{
			get{ return Costo; }
			set
			{
				if(value!=Costo)
				{
					Costo = value;
				}
			}
		}
		public decimal TOTALCOSTO
		{
			get{ return Totalcosto; }
			set
			{
				if(value!=Totalcosto)
				{
					Totalcosto = value;
				}
			}
		}
		public decimal UTILIDAD
		{
			get{ return Utilidad; }
			set
			{
				if(value!=Utilidad)
				{
					Utilidad = value;
				}
			}
		}
	}
}
