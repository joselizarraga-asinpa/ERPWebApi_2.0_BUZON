using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class RepVerFlujoFondos: IEntidadBase
	{
        private Int16 IdEmpresa;
        private Int16 IdSucursal;
        private string Nombreempresa;
		private string Nombresucursal;
		private string Nombreclasificacion;
        private string Aplicado;
        private DateTime Fecha;
		private DateTime Fechaini;
		private DateTime Fechafin;
		private decimal Importe;
		private string Obs;
        private string Concepto;
        private string CuentaOrigen;
        private string CuentaDestino;
        private bool CompraVentaDivisa;
        private decimal TipoCambio;


        //Constructor
        public RepVerFlujoFondos()
		{
            IdEmpresa = 0;
            IdSucursal = 0;
            Nombreempresa = ""; 
			Nombresucursal = ""; 
			Nombreclasificacion = "";
            Aplicado = "";
            Fecha = System.DateTime.Today;
			Fechaini = System.DateTime.Today;
			Fechafin = System.DateTime.Today;
			Importe = 0; 
			Obs = "";
            Concepto="";
            CuentaOrigen = "";
            CuentaDestino = "";
            CompraVentaDivisa = false;
            TipoCambio = 0;
    }
        [DataMember(IsRequired = true)]
        public Int16 IDEMPRESA
        {
            get { return IdEmpresa; }
            set
            {
                IdEmpresa = value;
            }
        }
        [DataMember(IsRequired = true)]
        public Int16 IDSUCURSAL
        {
            get { return IdSucursal; }
            set
            {
                IdSucursal = value;
            }
        }
        [DataMember(IsRequired = true)]
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
		[DataMember(IsRequired = true)]
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
		[DataMember(IsRequired = true)]
		public string NOMBRECLASIFICACION
		{
			get{ return Nombreclasificacion.ToString().Trim(); }
			set
			{
				if(value!=Nombreclasificacion)
				{
					Nombreclasificacion = value;
				}
			}
		}

        public string APLICADO
        {
            get { return Aplicado.ToString().Trim(); }
            set
            {
                if (value != Aplicado)
                {
                    Aplicado = value;
                }
            }
        }
        [DataMember(IsRequired = true)]
		public DateTime FECHA
		{
			get{ return Fecha; }
			set
			{
				if (value != null)
				{
					if(value!=Fecha)
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
        public string CUENTAORIGEN
        {
            get { return CuentaOrigen.ToString().Trim(); }
            set
            {
                if (value != CuentaOrigen)
                {
                    CuentaOrigen = value;
                }
            }
        }
        public string CUENTADESTINO
        {
            get { return CuentaDestino.ToString().Trim(); }
            set
            {
                if (value != CuentaDestino)
                {
                    CuentaDestino = value;
                }
            }
        }
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
        public decimal TIPOCAMBIO
        {
            get { return TipoCambio; }
            set
            {
                if (value != TipoCambio)
                {
                    TipoCambio = value;
                }
            }
        }
    }
}
