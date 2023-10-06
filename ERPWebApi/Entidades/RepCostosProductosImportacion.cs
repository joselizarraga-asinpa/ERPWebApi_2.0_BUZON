using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class RepCostosProductosImportacion: IEntidadBase
	{
        private long Id;
        private string Folio;
        private string Nombreproducto;
		private decimal Cantidad;
		private decimal Unitario;
		private decimal Importe;
		private decimal Importeconflete;
		private decimal Dta;
		private decimal Cnt;
		private decimal Prv;
		private decimal Otrosaduana;
		private decimal Totalantesimpuesto;
		private decimal Tasaarancel;
		private decimal Tasatraslado;
		private decimal Impuestoarancel;
		private decimal Impuestotraslado;
		private decimal Costobrutounimxn;
		private decimal Costobrutomxn;
		private decimal Tipocambio;
		private decimal Costobrutouniusd;
		private decimal Costobrutousd;
		private decimal Montoflujo;
		private decimal Montocompra;
		private decimal Montocompraotros;
		private decimal Porccompra;
		private decimal Costoflujo;
		private decimal Costonetounimxn;
		private decimal Costonetomxn;
		private decimal Costonetouniusd;
		private decimal Costonetousd;
		
		
		//Constructor
		public RepCostosProductosImportacion()
		{
            Id = 0;
            Folio = "";
            Nombreproducto = ""; 
			Cantidad = 0; 
			Unitario = 0; 
			Importe = 0; 
			Importeconflete = 0; 
			Dta = 0; 
			Cnt = 0; 
			Prv = 0; 
			Otrosaduana = 0; 
			Totalantesimpuesto = 0; 
			Tasaarancel = 0; 
			Tasatraslado = 0; 
			Impuestoarancel = 0; 
			Impuestotraslado = 0; 
			Costobrutounimxn = 0; 
			Costobrutomxn = 0; 
			Tipocambio = 0; 
			Costobrutouniusd = 0; 
			Costobrutousd = 0; 
			Montoflujo = 0; 
			Montocompra = 0; 
			Montocompraotros = 0; 
			Porccompra = 0; 
			Costoflujo = 0; 
			Costonetounimxn = 0; 
			Costonetomxn = 0; 
			Costonetouniusd = 0; 
			Costonetousd = 0; 
			
		}

        public long ID
        {
            get { return Id; }
            set
            {
                if (value != Id)
                {
                    Id = value;
                }
            }
        }
        public string FOLIO
        {
            get { return Folio.ToString().Trim(); }
            set
            {
                if (value != Folio)
                {
                    Folio = value;
                }
            }
        }
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
		public decimal IMPORTECONFLETE
		{
			get{ return Importeconflete; }
			set
			{
				if(value!=Importeconflete)
				{
					Importeconflete = value;
				}
			}
		}
		public decimal DTA
		{
			get{ return Dta; }
			set
			{
				if(value!=Dta)
				{
					Dta = value;
				}
			}
		}
		public decimal CNT
		{
			get{ return Cnt; }
			set
			{
				if(value!=Cnt)
				{
					Cnt = value;
				}
			}
		}
		public decimal PRV
		{
			get{ return Prv; }
			set
			{
				if(value!=Prv)
				{
					Prv = value;
				}
			}
		}
		public decimal OTROSADUANA
		{
			get{ return Otrosaduana; }
			set
			{
				if(value!=Otrosaduana)
				{
					Otrosaduana = value;
				}
			}
		}
		public decimal TOTALANTESIMPUESTO
		{
			get{ return Totalantesimpuesto; }
			set
			{
				if(value!=Totalantesimpuesto)
				{
					Totalantesimpuesto = value;
				}
			}
		}
		public decimal TASAARANCEL
		{
			get{ return Tasaarancel; }
			set
			{
				if(value!=Tasaarancel)
				{
					Tasaarancel = value;
				}
			}
		}
		public decimal TASATRASLADO
		{
			get{ return Tasatraslado; }
			set
			{
				if(value!=Tasatraslado)
				{
					Tasatraslado = value;
				}
			}
		}
		public decimal IMPUESTOARANCEL
		{
			get{ return Impuestoarancel; }
			set
			{
				if(value!=Impuestoarancel)
				{
					Impuestoarancel = value;
				}
			}
		}
		public decimal IMPUESTOTRASLADO
		{
			get{ return Impuestotraslado; }
			set
			{
				if(value!=Impuestotraslado)
				{
					Impuestotraslado = value;
				}
			}
		}
		public decimal COSTOBRUTOUNIMXN
		{
			get{ return Costobrutounimxn; }
			set
			{
				if(value!=Costobrutounimxn)
				{
					Costobrutounimxn = value;
				}
			}
		}
		public decimal COSTOBRUTOMXN
		{
			get{ return Costobrutomxn; }
			set
			{
				if(value!=Costobrutomxn)
				{
					Costobrutomxn = value;
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
		public decimal COSTOBRUTOUNIUSD
		{
			get{ return Costobrutouniusd; }
			set
			{
				if(value!=Costobrutouniusd)
				{
					Costobrutouniusd = value;
				}
			}
		}
		public decimal COSTOBRUTOUSD
		{
			get{ return Costobrutousd; }
			set
			{
				if(value!=Costobrutousd)
				{
					Costobrutousd = value;
				}
			}
		}
		public decimal MONTOFLUJO
		{
			get{ return Montoflujo; }
			set
			{
				if(value!=Montoflujo)
				{
					Montoflujo = value;
				}
			}
		}
		public decimal MONTOCOMPRA
		{
			get{ return Montocompra; }
			set
			{
				if(value!=Montocompra)
				{
					Montocompra = value;
				}
			}
		}
		public decimal MONTOCOMPRAOTROS
		{
			get{ return Montocompraotros; }
			set
			{
				if(value!=Montocompraotros)
				{
					Montocompraotros = value;
				}
			}
		}
		public decimal PORCCOMPRA
		{
			get{ return Porccompra; }
			set
			{
				if(value!=Porccompra)
				{
					Porccompra = value;
				}
			}
		}
		public decimal COSTOFLUJO
		{
			get{ return Costoflujo; }
			set
			{
				if(value!=Costoflujo)
				{
					Costoflujo = value;
				}
			}
		}
		public decimal COSTONETOUNIMXN
		{
			get{ return Costonetounimxn; }
			set
			{
				if(value!=Costonetounimxn)
				{
					Costonetounimxn = value;
				}
			}
		}
		public decimal COSTONETOMXN
		{
			get{ return Costonetomxn; }
			set
			{
				if(value!=Costonetomxn)
				{
					Costonetomxn = value;
				}
			}
		}
		public decimal COSTONETOUNIUSD
		{
			get{ return Costonetouniusd; }
			set
			{
				if(value!=Costonetouniusd)
				{
					Costonetouniusd = value;
				}
			}
		}
		public decimal COSTONETOUSD
		{
			get{ return Costonetousd; }
			set
			{
				if(value!=Costonetousd)
				{
					Costonetousd = value;
				}
			}
		}
	}
}
