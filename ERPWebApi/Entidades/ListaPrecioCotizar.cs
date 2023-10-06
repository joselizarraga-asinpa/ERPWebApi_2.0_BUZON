using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class ListaPrecioCotizar: IEntidadBase
	{
		private Int32 Idproducto;
		private Int32 Idcliprov;
		private Int32 Cantidad;
		private decimal Tipocambio;
		private string Nombrelistaprecio;
		private Int32 Volumen;
		private decimal Descuento;
		private decimal Unitario;
		private decimal Publico;
        private Int16 IdImpuesto;
        private Int16 Idmoneda;
		private string Moneda;
		private decimal Preciolista;
		private bool Aplica;
		private decimal Preciocotizado;
        private decimal DescuentoAplicado;
        private Int16 Idmonedaaplicada;
        private Int16 Idimpuestoaplicado;

        //Constructor
        public ListaPrecioCotizar()
		{
			Idproducto = 0; 
			Idcliprov = 0; 
			Cantidad = 0; 
			Tipocambio = 0; 
			Nombrelistaprecio = ""; 
			Volumen = 0; 
			Descuento = 0; 
			Unitario = 0; 
			Publico = 0;
            IdImpuesto = 0;
            Idmoneda = 0; 
			Moneda = ""; 
			Preciolista = 0; 
			Aplica = false; 
			Preciocotizado = 0;
            DescuentoAplicado = 0;
            Idmonedaaplicada = 0;
            Idimpuestoaplicado = 0;

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
		public Int32 CANTIDAD
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
		public decimal TIPOCAMBIO
		{
			get{ return Tipocambio; }
			set
			{
				if(value!=Tipocambio)
				{
					Tipocambio = value;
				}
			}
		}
		public string NOMBRELISTAPRECIO
		{
			get{ return Nombrelistaprecio.ToString().Trim(); }
			set
			{
				if(value!=Nombrelistaprecio)
				{
					Nombrelistaprecio = value;
				}
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
		public decimal PUBLICO
		{
			get{ return Publico; }
			set
			{
				if(value!=Publico)
				{
					Publico = value;
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
        public Int16 IDMONEDA
		{
			get{ return Idmoneda; }
			set
			{
				if(value!=Idmoneda)
				{
					Idmoneda = value;
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
		public decimal PRECIOLISTA
		{
			get{ return Preciolista; }
			set
			{
				if(value!=Preciolista)
				{
					Preciolista = value;
				}
			}
		}
		public bool APLICA
		{
			get{ return Aplica; }
			set
			{
				if(value!=Aplica)
				{
					Aplica = value;
				}
			}
		}
		public decimal PRECIOCOTIZADO
		{
			get{ return Preciocotizado; }
			set
			{
				if(value!=Preciocotizado)
				{
					Preciocotizado = value;
				}
			}
		}
        public decimal DESCUENTOAPLICADO
        {
            get { return DescuentoAplicado; }
            set
            {
                if (value != DescuentoAplicado)
                {
                    DescuentoAplicado = value;
                }
            }
        }
        public Int16 IDMONEDAAPLICADA
        {
            get { return Idmonedaaplicada; }
            set
            {
                if (value != Idmonedaaplicada)
                {
                    Idmonedaaplicada = value;
                }
            }
        }
        public Int16 IDIMPUESTOAPLICADO
        {
            get { return Idimpuestoaplicado; }
            set
            {
                if (value != Idimpuestoaplicado)
                {
                    Idimpuestoaplicado = value;
                }
            }
        }
    }
}
