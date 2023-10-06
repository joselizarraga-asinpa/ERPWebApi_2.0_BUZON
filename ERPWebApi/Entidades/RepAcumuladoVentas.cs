using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class RepAcumuladoVentas: IEntidadBase
	{
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
		private Int32 Anio;
		private Int32 Numeromes;
		private string Mes;
		private string Servicioproducto;
		private decimal Cantidad;
		private decimal Importe;
        private DateTime Desde;
        private DateTime Hasta;


        //Constructor
        public RepAcumuladoVentas()
		{
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
			Anio = 0; 
			Numeromes = 0; 
			Mes = ""; 
			Servicioproducto = ""; 
			Cantidad = 0; 
			Importe = 0; 
            Desde = System.DateTime.Today;
            Hasta = System.DateTime.Today;

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
			get{ return Producto.ToString().Trim(); }
			set
			{
				if(value!=Producto)
				{
					Producto = value;
				}
			}
		}
        [DataMember(IsRequired = true)]
        public string CLASPRODUCTO
        {
            get { return ClasProducto.ToString().Trim(); }
            set
            {
                if (value != ClasProducto)
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
		public Int32 NUMEROMES
		{
			get{ return Numeromes; }
			set
			{
				if(value!=Numeromes)
				{
					Numeromes = value;
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
	
        public DateTime DESDE
        {
            get { return Desde; }
            set
            {
                if (value != null)
                {
                    if (value != Desde)
                    {

                        Desde = value;
                    }
                }
            }
        }
        public DateTime HASTA
        {
            get { return Hasta; }
            set
            {
                if (value != null)
                {
                    if (value != Hasta)
                    {

                        Hasta = value;
                    }
                }
            }
        }
    }
}
