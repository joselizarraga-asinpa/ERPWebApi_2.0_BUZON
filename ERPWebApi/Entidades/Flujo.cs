using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class Flujo: IEntidadBase
	{
		private Int32 Id;
		private Int16 Idsucursal;
		private Int32 IdClas;
        private Int16 IdFuncionalidad;
        private Int32 IdRef;
        private Int16 Idcuentabanco;
        private Int16 Idcuentabancodes;
        private Int32 IdMovBanco;
        private DateTime Fecha;
        private DateTime Fechaini;
		private DateTime Fechafin;
        private bool CompraVentaDivisa;
        private decimal Tipocambio;
        private decimal Importe;
		private string Obs;
        private string NombreClasificacion;
        private string Concepto;
        private string Cuentapago;
        private string Foliooperacion;


        //Constructor
        public Flujo()
		{
			Id = 0; 
			Idsucursal = 0;
            IdClas = 0;
            IdFuncionalidad = 0;
            IdRef = 0;
            IdMovBanco = 0;
            Fecha = System.DateTime.Today;
            Fechaini = System.DateTime.Today;
			Fechafin = System.DateTime.Today;
            CompraVentaDivisa = false;
            Tipocambio = 0;
			Importe = 0; 
			Obs = "";
            NombreClasificacion = "";
            Idcuentabanco = 0;
            Idcuentabancodes = 0;
            Concepto = "";
            Cuentapago = "";
            Foliooperacion = "";

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
		public Int32 IDCLAS
		{
			get{ return IdClas; }
			set
			{
				if(value!= IdClas)
				{
                    IdClas = value;
				}
			}
		}
        public Int16 IDFUNCIONALIDAD
        {
            get { return IdFuncionalidad; }
            set
            {
                if (value != IdFuncionalidad)
                {
                    IdFuncionalidad = value;
                }
            }
        }
        public Int32 IDREF
        {
            get { return IdRef; }
            set
            {
                if (value != IdRef)
                {
                    IdRef = value;
                }
            }
        }
        public Int32 IDMOVBANCO
        {
            get { return IdMovBanco; }
            set
            {
                if (value != IdMovBanco)
                {
                    IdMovBanco = value;
                }
            }
        }
        [DataMember(IsRequired = true)]
        public DateTime FECHA
        {
            get { return Fecha; }
            set
            {
                if (value != null)
                {
                    if (value != Fecha)
                    {
                        Fecha = value;
                    }
                }
            }
        }
        [DataMember(IsRequired = true)]
		public DateTime FECHAINI
		{
			get{ return Fechaini; }
			set
			{
				if (value != null)
				{
					if(value!=Fechaini)
					{
						Fechaini = value;
					}
				}
			}
		}
		[DataMember(IsRequired = true)]
		public DateTime FECHAFIN
		{
			get{ return Fechafin; }
			set
			{
				if (value != null)
				{
					if(value!=Fechafin)
					{
						Fechafin = value;
					}
				}
			}
		}
        [DataMember(IsRequired = true)]
        public bool COMPRAVENTADIVISA
        {
            get { return CompraVentaDivisa; }
            set
            {
                if (value != CompraVentaDivisa)
                {
                    CompraVentaDivisa = value;
                }
            }
        }
        [DataMember(IsRequired = true)]
        public decimal TIPOCAMBIO
        {
            get { return Tipocambio; }
            set
            {
                if (value != Tipocambio)
                {
                    Tipocambio = value;
                }
            }
        }
        [DataMember(IsRequired = true)]
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
        public string NOMBRECLASIFICACION
        {
            get { return NombreClasificacion.ToString().Trim(); }
            set
            {
                if (value != NombreClasificacion)
                {
                    NombreClasificacion = value;
                }
            }
        }
        public Int16 IDCUENTABANCO
        {
            get { return Idcuentabanco; }
            set
            {
                if (value != Idcuentabanco)
                {

                    Idcuentabanco = value;
                }
            }
        }
        public Int16 IDCUENTABANCODES
        {
            get { return Idcuentabancodes; }
            set
            {
                if (value != Idcuentabancodes)
                {

                    Idcuentabancodes = value;
                }
            }
        }
        public string CONCEPTO
        {
            get { return Concepto.ToString().Trim(); }
            set
            {
                if (value != Concepto)
                {
                    Concepto = value;
                }
            }
        }
        public string CUENTAPAGO
        {
            get { return Cuentapago.ToString().Trim(); }
            set
            {
                if (value != Cuentapago)
                {

                    Cuentapago = value;
                }
            }
        }
        public string FOLIOOPERACION
        {
            get { return Foliooperacion.ToString().Trim(); }
            set
            {
                if (value != Foliooperacion)
                {

                    Foliooperacion = value;
                }
            }
        }
    }
}
