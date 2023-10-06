using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class RepSaldoProveedores: IEntidadBase
	{
        private Int16 Idempresa;
        private Int16 Idsucursal;
        private int IdProveedor;
		private string Nombreproveedor;
		private string Nombretipodoc;
		private string Folio;
		private DateTime Fecha;
        private DateTime FechaDoc;
        private decimal Total;
		private decimal Pagado;
		private decimal Saldo;
		
		
		//Constructor
		public RepSaldoProveedores()
		{
            Idempresa = 0;
            Idsucursal = 0;
            IdProveedor = 0;
            Nombreproveedor = ""; 
			Nombretipodoc = ""; 
			Folio = ""; 
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
        public int IDPROVEEDOR
        {
            get { return IdProveedor; }
            set
            {
                if (value != IdProveedor)
                {
                    
                    IdProveedor = value;
                }
            }
        }
        public string NOMBREPROVEEDOR
		{
			get{ return Nombreproveedor.ToString().Trim(); }
			set
			{
				if(value!=Nombreproveedor)
				{
					
					Nombreproveedor = value;
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
