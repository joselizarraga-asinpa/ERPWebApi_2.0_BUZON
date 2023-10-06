using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class DocRecurrenteDet: IEntidadBase
	{
		private Int32 Id;
		private Int32 Iddocrecurrente;
		private Int32 Idproducto;
        private string NombreProducto;
		private decimal Cantidad;
        private decimal Descuento;
        private decimal Unitario;
		private bool Considerarlistaprecio;
		private bool Unicaocasion;
		private Int16 NumPeriodicidad;
        private Int16 InicioPeriodicidad;
        private bool Activo;
        private bool Vigente;
        private DateTime Desde;
		private DateTime Hasta;
		private string Obs;
        private string FormaPago;
        private string Plazo;


        //Constructor
        public DocRecurrenteDet()
		{
			Id = 0; 
			Iddocrecurrente = 0; 
			Idproducto = 0;
            NombreProducto = "";
            Cantidad = 0;
            Descuento = 0;
            Unitario = 0; 
			Considerarlistaprecio = false; 
			Unicaocasion = false;
            NumPeriodicidad = 0;
            InicioPeriodicidad = 0;
            Activo = false;
            Vigente = false;
			Desde = DateTime.Parse("01/01/2000");
            Hasta = DateTime.Parse("01/01/2000");
            Obs = "";
            FormaPago = "";
            Plazo = "";


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
        public string NOMBREPRODUCTO
        {
            get { return NombreProducto; }
            set
            {
                if (value != NombreProducto)
                {
                    NombreProducto = value;
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
            get { return Descuento; }
            set
            {
                if (value != Descuento)
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
		public bool UNICAOCASION
		{
			get{ return Unicaocasion; }
			set
			{
				if(value!=Unicaocasion)
				{
					Unicaocasion = value;
				}
			}
		}
		public Int16 NUMPERIODICIDAD
        {
			get{ return NumPeriodicidad; }
			set
			{
				if(value!= NumPeriodicidad)
				{
                    NumPeriodicidad = value;
				}
			}
		}
        public Int16 INICIOPERIODICIDAD
        {
            get { return InicioPeriodicidad; }
            set
            {
                if (value != InicioPeriodicidad)
                {
                    InicioPeriodicidad = value;
                }
            }
        }
        [DataMember(IsRequired = true)]
		public bool ACTIVO
		{
			get{ return Activo; }
			set
			{
				if(value!=Activo)
				{
					Activo = value;
				}
			}
		}
        public bool VIGENTE
        {
            get { return Vigente; }
            set
            {
                if (value != Vigente)
                {
                    Vigente = value;
                }
            }
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
