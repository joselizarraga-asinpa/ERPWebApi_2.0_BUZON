using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class FlujoAplicado_Saldos: IEntidadBase
	{
		private long Id;
		private Int16 Idfuncionalidad;
		private Int16 Idcuentabanco;
        private string Concepto;
		private DateTime Fecha;
        private decimal TipoCambio;
        private decimal Total;
		private decimal Saldo;
		
		
		//Constructor
		public FlujoAplicado_Saldos()
		{
			Id = 0;
			Idfuncionalidad = 0;
			Idcuentabanco = 0;
            Concepto = ""; 
			Fecha = System.DateTime.Today;
            TipoCambio = 0;
            Total = 0; 
			Saldo = 0; 
			
		}
		
		public long ID
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
		public Int16 IDFUNCIONALIDAD
		{
			get { return Idfuncionalidad; }
			set
			{
				if (value != Idfuncionalidad)
				{
					Idfuncionalidad = value;
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
        public string CONCEPTO
		{
			get{ return Concepto.ToString().Trim(); }
			set
			{
				if(value!=Concepto)
				{
					Concepto = value;
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
		public decimal SALDO
		{
			get{ return Saldo; }
			set
			{
				if(value!=Saldo)
				{
					Saldo = value;
				}
			}
		}
	}
}
