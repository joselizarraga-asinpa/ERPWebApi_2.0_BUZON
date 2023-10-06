using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class CFDIEncabezado: IEntidadBase
	{
		private Int64 Iddocfiscal;
        private Int16 IdSucursal;
        private string Serie;
		private Int64 Folio;
        private Int16 IdTipoTimbrado;
        private DateTime Fecha;
		private string Formapago;
		private string Condicionespago;
		private string Moneda;
        private decimal TipoCambio;
		private string Tipocomprobante;
		private string Metodopago;
        private string FolioFiscal;
        private decimal Subtotal;
		private decimal Descuento;
		private decimal Impuestosretenidos;
		private decimal Impuestostrasladados;
		private decimal Total;
		private string Lugarexpedicion;
		private string Confirmacion;
		private string Tiporelacion;
		private string Emisorrfc;
		private string Emisornombre;
		private string Emisorregimenfiscal;
		private string Receptorrfc;
		private string Receptornombre;
		private string Usocfdi;
		private string Emisordomicilio;
		private string Receptordomicilio;
		private string Obsv;
		private string Totalletra;
		private string Expediciondomicilio;
		private string Domicilioentrega;
		private string Residenciafiscal;
        private string NumRegIdTrib;
		private string Agente;
		private string Ruta;
		private DateTime Vencimiento;
		private Int32 Faltantes;
		private string Emisortelefono;
		private Int32 Cajas;
		private Int32 Piezas;
		private string Impuesto;
		private string Tipofactor;
		private decimal Tasa;
		private decimal Importeimpuesto;
        private string Usuario;
		
		
		//Constructor
		public CFDIEncabezado()
		{
			Iddocfiscal = 0;
            IdTipoTimbrado = 0;
            IdSucursal = 0;
            Serie = ""; 
			Folio = 0; 
			Fecha = System.DateTime.Today;
			Formapago = ""; 
			Condicionespago = ""; 
			Moneda = "";
            TipoCambio = 1;
            Tipocomprobante = ""; 
			Metodopago = "";
            FolioFiscal = "";
            Subtotal = 0; 
			Descuento = 0; 
			Impuestosretenidos = 0; 
			Impuestostrasladados = 0; 
			Total = 0; 
			Lugarexpedicion = ""; 
			Confirmacion = ""; 
			Tiporelacion = ""; 
			Emisorrfc = ""; 
			Emisornombre = ""; 
			Emisorregimenfiscal = ""; 
			Receptorrfc = ""; 
			Receptornombre = ""; 
			Usocfdi = ""; 
			Emisordomicilio = ""; 
			Receptordomicilio = ""; 
			Obsv = ""; 
			Totalletra = ""; 
			Expediciondomicilio = ""; 
			Domicilioentrega = ""; 
			Residenciafiscal = "";
            NumRegIdTrib = "";
            Agente = ""; 
			Ruta = ""; 
			Vencimiento = System.DateTime.Today;
			Faltantes = 0; 
			Emisortelefono = ""; 
			Cajas = 0; 
			Piezas = 0; 
			Impuesto = ""; 
			Tipofactor = ""; 
			Tasa = 0; 
			Importeimpuesto = 0;
            Usuario = "";			
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
        public Int16 IDSUCURSAL
        {
            get { return IdSucursal; }
            set
            {
                if (value != IdSucursal)
                {
                    IdSucursal = value;
                }
            }
        }
        [DataMember(IsRequired = true)]
        public Int16 IDTIPOTIMBRADO
        {
            get { return IdTipoTimbrado; }
            set
            {
                if (value != IdTipoTimbrado)
                {
                    IdTipoTimbrado = value;
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
		public string FORMAPAGO
		{
			get{ return Formapago.ToString().Trim(); }
			set
			{
				if(value!=Formapago)
				{
					Formapago = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string CONDICIONESPAGO
		{
			get{ return Condicionespago.ToString().Trim(); }
			set
			{
				if(value!=Condicionespago)
				{
					Condicionespago = value;
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
		public string TIPOCOMPROBANTE
		{
			get{ return Tipocomprobante.ToString().Trim(); }
			set
			{
				if(value!=Tipocomprobante)
				{
					Tipocomprobante = value;
				}
			}
		}
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
        public decimal SUBTOTAL
		{
			get{ return Subtotal; }
			set
			{
				if(value!=Subtotal)
				{
					Subtotal = value;
				}
			}
		}
		public decimal DESCUENTO
		{
			get{ return Descuento; }
			set
			{
				if(value!=Descuento)
				{
					Descuento = value;
				}
			}
		}
		public decimal IMPUESTOSRETENIDOS
		{
			get{ return Impuestosretenidos; }
			set
			{
				if(value!=Impuestosretenidos)
				{
					Impuestosretenidos = value;
				}
			}
		}
		public decimal IMPUESTOSTRASLADADOS
		{
			get{ return Impuestostrasladados; }
			set
			{
				if(value!=Impuestostrasladados)
				{
					Impuestostrasladados = value;
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
		public string LUGAREXPEDICION
		{
			get{ return Lugarexpedicion.ToString().Trim(); }
			set
			{
				if(value!=Lugarexpedicion)
				{
					Lugarexpedicion = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string CONFIRMACION
		{
			get{ return Confirmacion.ToString().Trim(); }
			set
			{
				if(value!=Confirmacion)
				{
					Confirmacion = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string TIPORELACION
		{
			get{ return Tiporelacion.ToString().Trim(); }
			set
			{
				if(value!=Tiporelacion)
				{
					Tiporelacion = value;
				}
			}
		}
		public string EMISORRFC
		{
			get{ return Emisorrfc.ToString().Trim(); }
			set
			{
				if(value!=Emisorrfc)
				{
					Emisorrfc = value;
				}
			}
		}
		public string EMISORNOMBRE
		{
			get{ return Emisornombre.ToString().Trim(); }
			set
			{
				if(value!=Emisornombre)
				{
					Emisornombre = value;
				}
			}
		}
		public string EMISORREGIMENFISCAL
		{
			get{ return Emisorregimenfiscal.ToString().Trim(); }
			set
			{
				if(value!=Emisorregimenfiscal)
				{
					Emisorregimenfiscal = value;
				}
			}
		}
		public string RECEPTORRFC
		{
			get{ return Receptorrfc.ToString().Trim(); }
			set
			{
				if(value!=Receptorrfc)
				{
					Receptorrfc = value;
				}
			}
		}
		public string RECEPTORNOMBRE
		{
			get{ return Receptornombre.ToString().Trim(); }
			set
			{
				if(value!=Receptornombre)
				{
					Receptornombre = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string USOCFDI
		{
			get{ return Usocfdi.ToString().Trim(); }
			set
			{
				if(value!=Usocfdi)
				{
					Usocfdi = value;
				}
			}
		}
		public string EMISORDOMICILIO
		{
			get{ return Emisordomicilio.ToString().Trim(); }
			set
			{
				if(value!=Emisordomicilio)
				{
					Emisordomicilio = value;
				}
			}
		}
		public string RECEPTORDOMICILIO
		{
			get{ return Receptordomicilio.ToString().Trim(); }
			set
			{
				if(value!=Receptordomicilio)
				{
					Receptordomicilio = value;
				}
			}
		}
		public string OBSV
		{
			get{ return Obsv.ToString().Trim(); }
			set
			{
				if(value!=Obsv)
				{
					Obsv = value;
				}
			}
		}
		public string TOTALLETRA
		{
			get{ return Totalletra.ToString().Trim(); }
			set
			{
				if(value!=Totalletra)
				{
					Totalletra = value;
				}
			}
		}
		public string EXPEDICIONDOMICILIO
		{
			get{ return Expediciondomicilio.ToString().Trim(); }
			set
			{
				if(value!=Expediciondomicilio)
				{
					Expediciondomicilio = value;
				}
			}
		}
		public string DOMICILIOENTREGA
		{
			get{ return Domicilioentrega.ToString().Trim(); }
			set
			{
				if(value!=Domicilioentrega)
				{
					Domicilioentrega = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string RESIDENCIAFISCAL
		{
			get{ return Residenciafiscal.ToString().Trim(); }
			set
			{
				if(value!=Residenciafiscal)
				{
					Residenciafiscal = value;
				}
			}
		}
        public string NUMREGIDTRIB
        {
            get { return NumRegIdTrib.Trim(); }
            set { NumRegIdTrib = value; }
        }
        [DataMember(IsRequired = true)]
		public string AGENTE
		{
			get{ return Agente.ToString().Trim(); }
			set
			{
				if(value!=Agente)
				{
					Agente = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string RUTA
		{
			get{ return Ruta.ToString().Trim(); }
			set
			{
				if(value!=Ruta)
				{
					Ruta = value;
				}
			}
		}
		public DateTime VENCIMIENTO
		{
			get{ return Vencimiento; }
			set
			{
				if (value != null)
				{
					if(value!=Vencimiento)
					{
						Vencimiento = value;
					}
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int32 FALTANTES
		{
			get{ return Faltantes; }
			set
			{
				if(value!=Faltantes)
				{
					Faltantes = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string EMISORTELEFONO
		{
			get{ return Emisortelefono.ToString().Trim(); }
			set
			{
				if(value!=Emisortelefono)
				{
					Emisortelefono = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int32 CAJAS
		{
			get{ return Cajas; }
			set
			{
				if(value!=Cajas)
				{
					Cajas = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int32 PIEZAS
		{
			get{ return Piezas; }
			set
			{
				if(value!=Piezas)
				{
					Piezas = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string IMPUESTO
		{
			get{ return Impuesto.ToString().Trim(); }
			set
			{
				if(value!=Impuesto)
				{
					Impuesto = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string TIPOFACTOR
		{
			get{ return Tipofactor.ToString().Trim(); }
			set
			{
				if(value!=Tipofactor)
				{
					Tipofactor = value;
				}
			}
		}
		public decimal TASA
		{
			get{ return Tasa; }
			set
			{
				if(value!=Tasa)
				{
					Tasa = value;
				}
			}
		}
		public decimal IMPORTEIMPUESTO
		{
			get{ return Importeimpuesto; }
			set
			{
				if(value!=Importeimpuesto)
				{
					Importeimpuesto = value;
				}
			}
		}
        [DataMember(IsRequired = true)]
        public string USUARIO
        {
            get { return Usuario.ToString().Trim(); }
            set
            {
                if (value != Usuario)
                {
                    Usuario = value;
                }
            }
        }
    }
}
