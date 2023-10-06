using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class RepRecurrenciaVentas: IEntidadBase
	{
		private Int16 Idempresa;
		private string Empresa;
		private Int16 Idsucursal;
		private string Sucursal;
		private string Cliente;
		private string Clascliente;
        private string Producto;
        private string Tipoprodser;
        private string Servicioproducto;
		private decimal Cantidad;
        private decimal Descuento;
        private decimal Precio;
        private decimal Importe;
        private string Observacion;
        private DateTime Inicia;
        private DateTime Termina;
        private DateTime Desde;
        private DateTime Hasta;
        private Int16 Anio;
        private Int16 NumeroMes;
        private string Mes;
        private string FormaPago;
        private string Plazo;


        //Constructor
        public RepRecurrenciaVentas()
		{
			Idempresa = 0; 
			Empresa = ""; 
			Idsucursal = 0; 
			Sucursal = ""; 
			Cliente = ""; 
			Clascliente = ""; 
			Servicioproducto = "";
            Producto = "";
            Tipoprodser = "";
            Cantidad = 0;
            Descuento = 0;
            Precio = 0;
			Importe = 0;
            Observacion = "";
            Inicia = DateTime.Now;
            Termina = DateTime.Now;
            Desde = DateTime.Now;
            Hasta = DateTime.Now;
            Anio = 0;
            NumeroMes = 0;
            Mes = "";
            FormaPago = "";
            Plazo = "";
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
		public string CLASCLIENTE
		{
			get{ return Clascliente.ToString().Trim(); }
			set
			{
				if(value!=Clascliente)
				{
					Clascliente = value;
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
        public string TIPOPRODSER
        {
            get { return Tipoprodser.ToString().Trim(); }
            set
            {
                if (value != Tipoprodser)
                {
                    Tipoprodser = value;
                }
            }
        }
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
        public decimal DESCUENTO
        {
            get { return Descuento; }
            set
            {
                if (value != Descuento)
                {
                    Descuento = value;
                }
            }
        }
        public decimal PRECIO
        {
            get { return Precio; }
            set
            {
                if (value != Precio)
                {
                    Precio = value;
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
        public string OBSERVACION
        {
            get { return Observacion.ToString().Trim(); }
            set
            {
                if (value != Observacion)
                {
                    Observacion = value;
                }
            }
        }
        public DateTime INICIA
        {
            get { return Inicia; }
            set
            {
                if (value != null)
                {
                    if (value != Inicia)
                    {

                        Inicia = value;
                    }
                }
            }
        }
        public DateTime TERMINA
        {
            get { return Termina; }
            set
            {
                if (value != null)
                {
                    if (value != Termina)
                    {

                        Termina = value;
                    }
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
        public Int16 ANIO
        {
            get { return Anio; }
            set
            {
                if (value != Anio)
                {
                    Anio = value;
                }
            }
        }
        public Int16 NUMEROMES
        {
            get { return NumeroMes; }
            set
            {
                if (value != NumeroMes)
                {
                    NumeroMes = value;
                }
            }
        }
        public string MES
        {
            get { return Mes.ToString().Trim(); }
            set
            {
                if (value != Mes)
                {
                    Mes = value;
                }
            }
        }
        public string FORMAPAGO
        {
            get { return FormaPago.ToString().Trim(); }
            set
            {
                if (value != FormaPago)
                {
                    FormaPago = value;
                }
            }
        }
        public string PLAZO
        {
            get { return Plazo.ToString().Trim(); }
            set
            {
                if (value != Plazo)
                {
                    Plazo = value;
                }
            }
        }
    }
}
