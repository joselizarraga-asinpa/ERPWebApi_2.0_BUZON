using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class CFDIPagos: IEntidadBase
	{
		private Int64 Iddocfiscal;
		private Int64 Idpago;
		private DateTime Fechapago;
		private string Satformapago;
		private string Moneda;
		private decimal Monto;
        private decimal TipoCambio;
		private string Nooperacion;
		private string Rfcbancoordenante;
		private string Bancoordenante;
		private string Rfcbancobeneficiario;
		private string Nocuentabeneficiario;
		
		
		//Constructor
		public CFDIPagos()
		{
			Iddocfiscal = 0; 
			Idpago = 0; 
			Fechapago = System.DateTime.Today;
			Satformapago = ""; 
			Moneda = ""; 
			Monto = 0;
            TipoCambio = 0;
            Nooperacion = ""; 
			Rfcbancoordenante = ""; 
			Bancoordenante = ""; 
			Rfcbancobeneficiario = ""; 
			Nocuentabeneficiario = ""; 
			
		}
		
		[DataMember(IsRequired = true)]
		public Int64 IDDOCFISCAL
		{
			get{ return Iddocfiscal; }
			set
			{
				if(value!=Iddocfiscal)
				{
					Iddocfiscal = value;
				}
			}
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
		[DataMember(IsRequired = true)]
		public DateTime FECHAPAGO
		{
			get{ return Fechapago; }
			set
			{
				if (value != null)
				{
					if(value!=Fechapago)
					{
						Fechapago = value;
					}
				}
			}
		}
		public string SATFORMAPAGO
		{
			get{ return Satformapago.ToString().Trim(); }
			set
			{
				if(value!=Satformapago)
				{
					Satformapago = value;
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
		[DataMember(IsRequired = true)]
		public decimal MONTO
		{
			get{ return Monto; }
			set
			{
				if(value!=Monto)
				{
					Monto = value;
				}
			}
		}
        [DataMember(IsRequired = true)]
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
        public string NOOPERACION
		{
			get{ return Nooperacion.ToString().Trim(); }
			set
			{
				if(value!=Nooperacion)
				{
					Nooperacion = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string RFCBANCOORDENANTE
		{
			get{ return Rfcbancoordenante.ToString().Trim(); }
			set
			{
				if(value!=Rfcbancoordenante)
				{
					Rfcbancoordenante = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string BANCOORDENANTE
		{
			get{ return Bancoordenante.ToString().Trim(); }
			set
			{
				if(value!=Bancoordenante)
				{
					Bancoordenante = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string RFCBANCOBENEFICIARIO
		{
			get{ return Rfcbancobeneficiario.ToString().Trim(); }
			set
			{
				if(value!=Rfcbancobeneficiario)
				{
					Rfcbancobeneficiario = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string NOCUENTABENEFICIARIO
		{
			get{ return Nocuentabeneficiario.ToString().Trim(); }
			set
			{
				if(value!=Nocuentabeneficiario)
				{
					Nocuentabeneficiario = value;
				}
			}
		}
	}
}
