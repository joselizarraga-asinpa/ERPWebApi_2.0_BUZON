using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class DocRecurrenteDetGenerar: IEntidadBase
	{
		private Int32 Id;
        private DateTime Fecha;
        private Int32 Iddocrecurrente;
        private Int16 Idtipodocumento;
        private Int16 IdSucursal;
        private Int32 Idcliprov;
        private Int16 IdMoneda;
        private Int32 Idproducto;
		private string Nombreproducto;
        private string FormaPago;
        private string Plazo;
        private string Obs;
		private bool Considerarlistaprecio;
		private decimal Cantidad;
		private decimal Descuento;
		private decimal Unitario;
		private decimal Subtotal;
		private decimal Tasaimpuesto;
		private decimal Iva;
		private decimal Total;
		
		
		//Constructor
		public DocRecurrenteDetGenerar()
		{
            Fecha = DateTime.Now;
            IdSucursal = 0;            
            Idtipodocumento = 0;
            Id = 0; 
			Iddocrecurrente = 0; 
			Idcliprov = 0;
            IdMoneda = 0;
            Idproducto = 0; 
			Nombreproducto = "";
            FormaPago = "";
            Plazo = "";
			Obs = ""; 
			Considerarlistaprecio = false; 
			Cantidad = 0; 
			Descuento = 0; 
			Unitario = 0; 
			Subtotal = 0; 
			Tasaimpuesto = 0; 
			Iva = 0; 
			Total = 0; 
			
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
        public DateTime FECHA
        {
            get { return Fecha; }
            set
            {
                Fecha = value;
            }
        }
        [DataMember(IsRequired = true)]
        public Int16 IDSUCURSAL
        {
            get { return IdSucursal; }
            set
            {
                if (value != IdSucursal)
                {
                    IdSucursal = value;
                }
            }
        }
        [DataMember(IsRequired = true)]
		public Int32 IDDOCRECURRENTE
		{
			get{ return Iddocrecurrente; }
			set
			{
				if(value!=Iddocrecurrente)
				{
					Iddocrecurrente = value;
				}
			}
		}
        [DataMember(IsRequired = true)]
        public Int16 IDTIPODOCUMENTO
        {
            get { return Idtipodocumento; }
            set
            {
                if (value != Idtipodocumento)
                {
                    Idtipodocumento = value;
                }
            }
        }
        [DataMember(IsRequired = true)]
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
        [DataMember(IsRequired = true)]
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
        [DataMember(IsRequired = true)]
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
		[DataMember(IsRequired = true)]
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
		[DataMember(IsRequired = true)]
		public bool CONSIDERARLISTAPRECIO
		{
			get{ return Considerarlistaprecio; }
			set
			{
				if(value!=Considerarlistaprecio)
				{
					Considerarlistaprecio = value;
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
		[DataMember(IsRequired = true)]
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
		public decimal SUBTOTAL
		{
			get{ return Subtotal; }
			set
			{
				if(value!=Subtotal)
				{
					Subtotal = value;
				}
			}
		}
		public decimal TASAIMPUESTO
		{
			get{ return Tasaimpuesto; }
			set
			{
				if(value!=Tasaimpuesto)
				{
					Tasaimpuesto = value;
				}
			}
		}
		public decimal IVA
		{
			get{ return Iva; }
			set
			{
				if(value!=Iva)
				{
					Iva = value;
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
	}
}
