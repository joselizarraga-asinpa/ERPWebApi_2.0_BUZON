using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class CFDIPagosDocs: IEntidadBase
	{
		private Int64 Idpago;
		private string Nodocumento;
		private string Serie;
		private Int64 Folio;
		private string Moneda;
        private decimal TipoCambio;
		private string Metodopago;
		private Int32 Parcialidad;
		private decimal Saldoanterior;
		private decimal Pagado;
		private decimal Saldoinsoluto;
		
		
		//Constructor
		public CFDIPagosDocs()
		{
			Idpago = 0; 
			Nodocumento = ""; 
			Serie = ""; 
			Folio = 0; 
			Moneda = "";
            TipoCambio = 0;
            Metodopago = ""; 
			Parcialidad = 0; 
			Saldoanterior = 0; 
			Pagado = 0; 
			Saldoinsoluto = 0; 
			
		}
		
		[DataMember(IsRequired = true)]
		public Int64 IDPAGO
		{
			get{ return Idpago; }
			set
			{
				if(value!=Idpago)
				{
					Idpago = value;
				}
			}
		}
		public string NODOCUMENTO
		{
			get{ return Nodocumento.ToString().Trim(); }
			set
			{
				if(value!=Nodocumento)
				{
					Nodocumento = value;
				}
			}
		}
		public string SERIE
		{
			get{ return Serie.ToString().Trim(); }
			set
			{
				if(value!=Serie)
				{
					Serie = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int64 FOLIO
		{
			get{ return Folio; }
			set
			{
				if(value!=Folio)
				{
					Folio = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string MONEDA
		{
			get{ return Moneda.ToString().Trim(); }
			set
			{
				if(value!=Moneda)
				{
					Moneda = value;
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
        [DataMember(IsRequired = true)]
		public string METODOPAGO
		{
			get{ return Metodopago.ToString().Trim(); }
			set
			{
				if(value!=Metodopago)
				{
					Metodopago = value;
				}
			}
		}
		public Int32 PARCIALIDAD
		{
			get{ return Parcialidad; }
			set
			{
				if(value!=Parcialidad)
				{
					Parcialidad = value;
				}
			}
		}
		public decimal SALDOANTERIOR
		{
			get{ return Saldoanterior; }
			set
			{
				if(value!=Saldoanterior)
				{
					Saldoanterior = value;
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
		public decimal SALDOINSOLUTO
		{
			get{ return Saldoinsoluto; }
			set
			{
				if(value!=Saldoinsoluto)
				{
					Saldoinsoluto = value;
				}
			}
		}
	}
}
