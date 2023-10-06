using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class RepSaldoClientes: IEntidadBase
	{
        private Int16 Idempresa;
        private Int16 Idsucursal;
        private int IdCliente;
        private string FiltroSaldo;
		private string Nombrecliente;
		private string Nombretipodoc;
        private long IdAgrup;
		private string Folio;
        private string FolioPago;
        private string FolioFiscal;
        private DateTime Fecha;
        private DateTime FechaDoc;
        private decimal Total;
		private decimal Pagado;
		private decimal Saldo;
		
		
		//Constructor
		public RepSaldoClientes()
		{
            Idempresa = 0;
            Idsucursal = 0;
            IdCliente = 0;
            FiltroSaldo = "T";
            Nombrecliente = ""; 
			Nombretipodoc = "";
            IdAgrup = 0;
            Folio = "";
            FolioPago = "";
            FolioFiscal = "";
            Fecha = System.DateTime.Today;
            FechaDoc = System.DateTime.Today;
            Total = 0; 
			Pagado = 0; 
			Saldo = 0; 
			
		}

        public Int16 IDEMPRESA
        {
            get { return Idempresa; }
            set
            {
                if (value != Idempresa)
                {

                    Idempresa = value;
                }
            }
        }
        public Int16 IDSUCURSAL
        {
            get { return Idsucursal; }
            set
            {
                if (value != Idsucursal)
                {

                    Idsucursal = value;
                }
            }
        }
        public int IDCLIENTE
        {
            get { return IdCliente; }
            set
            {
                if (value != IdCliente)
                {

                    IdCliente = value;
                }
            }
        }
        public string FILTROSALDO
        {
            get { return FiltroSaldo.ToString().Trim(); }
            set { FiltroSaldo = value; }
        }
        public string NOMBRECLIENTE
		{
			get{ return Nombrecliente.ToString().Trim(); }
			set
			{
				if(value!= Nombrecliente)
				{

                    Nombrecliente = value;
				}
			}
		}		
		public string NOMBRETIPODOC
		{
			get{ return Nombretipodoc.ToString().Trim(); }
			set
			{
				if(value!=Nombretipodoc)
				{
					
					Nombretipodoc = value;
				}
			}
		}		
        public long IDAGRUP
        {
            get { return IdAgrup; }
            set
            {
                IdAgrup = value;
            }
        }
        public string FOLIO
		{
			get{ return Folio.ToString().Trim(); }
			set
			{
				if(value!=Folio)
				{
					
					Folio = value;
				}
			}
		}
        public string FOLIOPAGO
        {
            get { return FolioPago.ToString().Trim(); }
            set
            {
                if (value != FolioPago)
                {
                    FolioPago = value;
                }
            }
        }
        public string FOLIOFISCAL
        {
            get { return FolioFiscal.ToString().Trim(); }
            set
            {
                if (value != FolioFiscal)
                {

                    FolioFiscal = value;
                }
            }
        }
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
        public DateTime FECHADOC
        {
            get { return FechaDoc; }
            set
            {
                if (value != null)
                {
                    if (value != FechaDoc)
                    {
                        
                        FechaDoc = value;
                    }
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
		public decimal PAGADO
		{
			get{ return Pagado; }
			set
			{
				if(value!=Pagado)
				{
					
					Pagado = value;
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
