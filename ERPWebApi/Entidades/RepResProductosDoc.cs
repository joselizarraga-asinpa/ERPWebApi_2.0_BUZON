using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class RepResProductosDoc: IEntidadBase
	{
		private Int16 Id;
		private Int16 Idempresa;
		private string Nombreempresa;
		private Int16 Idsucursal;
		private string Nombresucursal;
		private string Tipo;
		private string Nombreproducto;
		private string Nombretipoproducto;
		private string Nombretipounidad;
		private string Estatus;
		private decimal Cantidad;
		private decimal Total;
		private string Moneda;
        private string Producto;
        private string Clasificaciones;
        private DateTime Desde;
        private DateTime Hasta;


        //Constructor
        public RepResProductosDoc()
		{
			Id = 0; 
			Idempresa = 0; 
			Nombreempresa = ""; 
			Idsucursal = 0; 
			Nombresucursal = ""; 
			Tipo = ""; 
			Nombreproducto = ""; 
			Nombretipoproducto = ""; 
			Nombretipounidad = ""; 
			Estatus = ""; 
			Cantidad = 0; 
			Total = 0; 
			Moneda = "";
            Producto = "";
            Clasificaciones = "";
            Desde = DateTime.Now;
            Hasta = DateTime.Now;

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
		public string NOMBREEMPRESA
		{
			get{ return Nombreempresa.ToString().Trim(); }
			set
			{
				if(value!=Nombreempresa)
				{
					Nombreempresa = value;
				}
			}
		}
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
		public string NOMBRESUCURSAL
		{
			get{ return Nombresucursal.ToString().Trim(); }
			set
			{
				if(value!=Nombresucursal)
				{
					Nombresucursal = value;
				}
			}
		}
		public string TIPO
		{
			get{ return Tipo.ToString().Trim(); }
			set
			{
				if(value!=Tipo)
				{
					Tipo = value;
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
		public string NOMBRETIPOPRODUCTO
		{
			get{ return Nombretipoproducto.ToString().Trim(); }
			set
			{
				if(value!=Nombretipoproducto)
				{
					Nombretipoproducto = value;
				}
			}
		}
		public string NOMBRETIPOUNIDAD
		{
			get{ return Nombretipounidad.ToString().Trim(); }
			set
			{
				if(value!=Nombretipounidad)
				{
					Nombretipounidad = value;
				}
			}
		}
		public string ESTATUS
		{
			get{ return Estatus.ToString().Trim(); }
			set
			{
				if(value!=Estatus)
				{
					Estatus = value;
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
		public decimal TOTAL
		{
			get{ return Total; }
			set
			{
				if(value!=Total)
				{
					Total = value;
				}
			}
		}
		public string MONEDA
		{
			get{ return Moneda.ToString().Trim(); }
			set
			{
				if(value!=Moneda)
				{
					Moneda = value;
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
        public string CLASIFICACIONES
        {
            get { return Clasificaciones.ToString().Trim(); }
            set
            {
                if (value != Clasificaciones)
                {
                    Clasificaciones = value;
                }
            }
        }
    }
}
