using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class ProductoSugerido: IEntidadBase
	{
		private Int32 Idproducto;
		private Int32 Idproductosugerido;
        private string NombreProductoSugerido;
        private decimal Factor;
		private bool Docrecurrente;
        private decimal Descuento;
        private decimal Unitario;
        private bool Considerarlistaprecio;
        private bool Unicaocasion;
        private Int16 NumPeriodicidad;
        private Int16 InicioPeriodicidad;
        private string Obs;
        private bool MostrarId;


        //Constructor
        public ProductoSugerido()
		{
			Idproducto = 0; 
			Idproductosugerido = 0; 
			Factor = 0; 
			Docrecurrente = false;

            NombreProductoSugerido = "";
            Descuento = 0;
            Unitario = 0;
            Considerarlistaprecio = false;
            Unicaocasion = false;
            NumPeriodicidad = 0;
            InicioPeriodicidad = 0;            
            Obs = "";
            MostrarId = true;


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
		public Int32 IDPRODUCTOSUGERIDO
		{
			get{ return Idproductosugerido; }
			set
			{
				if(value!=Idproductosugerido)
				{
					Idproductosugerido = value;
				}
			}
		}
        public string NOMBREPRODUCTOSUGERIDO
        {
            get { return NombreProductoSugerido; }
            set
            {
                if (value != NombreProductoSugerido)
                {
                    NombreProductoSugerido = value;
                }
            }
        }
        [DataMember(IsRequired = true)]
		public decimal FACTOR
		{
			get{ return Factor; }
			set
			{
				if(value!=Factor)
				{
					Factor = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public bool DOCRECURRENTE
		{
			get{ return Docrecurrente; }
			set
			{
				if(value!=Docrecurrente)
				{
					Docrecurrente = value;
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
            get { return Unitario; }
            set
            {
                if (value != Unitario)
                {
                    Unitario = value;
                }
            }
        }
        [DataMember(IsRequired = true)]
        public bool CONSIDERARLISTAPRECIO
        {
            get { return Considerarlistaprecio; }
            set
            {
                if (value != Considerarlistaprecio)
                {
                    Considerarlistaprecio = value;
                }
            }
        }
        [DataMember(IsRequired = true)]
        public bool UNICAOCASION
        {
            get { return Unicaocasion; }
            set
            {
                if (value != Unicaocasion)
                {
                    Unicaocasion = value;
                }
            }
        }
        public Int16 NUMPERIODICIDAD
        {
            get { return NumPeriodicidad; }
            set
            {
                if (value != NumPeriodicidad)
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
        public string OBS
        {
            get { return Obs.ToString().Trim(); }
            set
            {
                if (value != Obs)
                {
                    Obs = value;
                }
            }
        }

        public bool MOSTRARID
        {
            get { return MostrarId; }
            set
            {
                if (value != MostrarId)
                {

                    MostrarId = value;
                }
            }
        }
    }
}
