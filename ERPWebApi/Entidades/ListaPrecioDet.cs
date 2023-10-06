using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class ListaPrecioDet: IEntidadBase
	{
		private Int32 Id;
		private Int16 Idlistaprecio;
		private Int16 Idtipoproducto;
        private string TipoProducto;
		private Int32 Idclasproducto;
        private string ClasProducto;
        private Int32 Idproducto;
        private string Producto;
        private Int32 Idclascliprov;
        private string ClasCliProv;
        private Int32 Idcliprov;
        private string CliProv;
        private Int16 IdMoneda;
        private Int16 IdImpuesto;
        private string Impuesto;
        private string Moneda;
        private Int32 Volumen;
		private decimal Descuento;
		private decimal Unitario;
		
		
		//Constructor
		public ListaPrecioDet()
		{
			Id = 0; 
			Idlistaprecio = 0; 
			Idtipoproducto = 0;
            TipoProducto = "";
			Idclasproducto = 0;
            ClasProducto = "";
			Idproducto = 0;
            Producto = "";
			Idclascliprov = 0;
            ClasCliProv = "";
			Idcliprov = 0;
            CliProv = "";
            IdMoneda = 0;
            IdImpuesto = 0;
            Impuesto = "";
            Moneda = "";
            Volumen = 0; 
			Descuento = 0; 
			Unitario = 0; 
			
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
		public Int16 IDLISTAPRECIO
		{
			get{ return Idlistaprecio; }
			set
			{
				if(value!=Idlistaprecio)
				{
					Idlistaprecio = value;
				}
			}
		}        
		public Int16 IDTIPOPRODUCTO
		{
			get{ return Idtipoproducto; }
			set
			{
				if(value!=Idtipoproducto)
				{
					Idtipoproducto = value;
				}
			}
		}
        public string TIPOPRODUCTO
        {
            get { return TipoProducto; }
            set
            {
                TipoProducto = value;
            }
        }
        public Int32 IDCLASPRODUCTO
		{
			get{ return Idclasproducto; }
			set
			{
				if(value!=Idclasproducto)
				{
					Idclasproducto = value;
				}
			}
		}
        public string CLASPRODUCTO
        {
            get { return ClasProducto; }
            set
            {
                ClasProducto = value;
            }
        }
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
        public string PRODUCTO
        {
            get { return Producto; }
            set
            {
                Producto = value;
            }
        }
        public Int32 IDCLASCLIPROV
		{
			get{ return Idclascliprov; }
			set
			{
				if(value!=Idclascliprov)
				{
					Idclascliprov = value;
				}
			}
		}
        public string CLASCLIPROV
        {
            get { return ClasCliProv; }
            set
            {
                ClasCliProv = value;
            }
        }
        public Int32 IDCLIPROV
		{
			get{ return Idcliprov; }
			set
			{
				if(value!=Idcliprov)
				{
					Idcliprov = value;
				}
			}
		}
        public string CLIPROV
        {
            get { return CliProv; }
            set
            {
                CliProv = value;
            }
        }
        public Int16 IDMONEDA
        {
            get { return IdMoneda; }
            set
            {
                if (value != IdMoneda)
                {
                    IdMoneda = value;
                }
            }
        }
        public Int16 IDIMPUESTO
        {
            get { return IdImpuesto; }
            set
            {
                if (value != IdImpuesto)
                {
                    IdImpuesto = value;
                }
            }
        }
        public string MONEDA
        {
            get { return Moneda; }
            set
            {
                Moneda = value;
            }
        }
        public Int32 VOLUMEN
		{
			get{ return Volumen; }
			set
			{
				if(value!=Volumen)
				{
					Volumen = value;
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
		public decimal UNITARIO
		{
			get{ return Unitario; }
			set
			{
				if(value!=Unitario)
				{
					Unitario = value;
				}
			}
		}
        public string IMPUESTO
        {
            get { return Impuesto; }
            set
            {
                Impuesto = value;
            }
        }
    }
}
