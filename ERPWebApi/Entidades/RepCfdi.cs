using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class RepCfdi: IEntidadBase
	{
		private Int64 Iddocfiscal;
		private string Serie;
		private Int64 Folio;
		private DateTime Fecha;
        private DateTime FechaTimbrado;
        private string RfcCertificacion;
        private string Formapago;
		private string Condicionespago;
		private string Moneda;
        private decimal TipoCambio;
        private string TipoDocumento;
        private string Tipocomprobante;
		private string Metodopago;
		private string Foliofiscal;
		private decimal Subtotal;
		private decimal Totaldescuento;
		private decimal Impuestosretenidos;
		private decimal Impuestostrasladados;
		private decimal Total;
		private string Lugarexpedicion;
		private string Confirmacion;
		private string Tiporelacion;
		private string Cfdirelacionado;
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
		private string Satclaveprod;
		private string Noidentificacion;
		private decimal Cantidad;
		private string Satclaveunidad;
		private string Unidad;
		private string Descripcion;
		private decimal Valorunitario;
		private decimal Importe;
		private decimal Descuento;
		private string Lote;
		private string Caducidad;
		private string Proveedor;
		private string Tipodescuento;
		private string Publico;
		private string Obs;
		private decimal Base;
		private string Impuesto;
		private string Tipofactor;
		private decimal Tasa;
		private decimal Importeimpuesto;
		private Int16 Registro;

        private string CerEmisor;
        private string CerSat;
        private string SelloDigital;
        private string SelloDigitalSat;
        private string CadenaOriginal;
        private byte[] qr;


        //Constructor
        public RepCfdi()
		{
			Iddocfiscal = 0; 
			Serie = ""; 
			Folio = 0; 
			Fecha = System.DateTime.Today;
            FechaTimbrado = System.DateTime.Today;
            RfcCertificacion = "";
            Formapago = ""; 
			Condicionespago = ""; 
			Moneda = "";
            TipoCambio = 0;
            TipoDocumento = "";
            Tipocomprobante = ""; 
			Metodopago = ""; 
			Foliofiscal = ""; 
			Subtotal = 0; 
			Totaldescuento = 0; 
			Impuestosretenidos = 0; 
			Impuestostrasladados = 0; 
			Total = 0; 
			Lugarexpedicion = ""; 
			Confirmacion = ""; 
			Tiporelacion = ""; 
			Cfdirelacionado = ""; 
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
			Satclaveprod = ""; 
			Noidentificacion = ""; 
			Cantidad = 0; 
			Satclaveunidad = ""; 
			Unidad = ""; 
			Descripcion = ""; 
			Valorunitario = 0; 
			Importe = 0; 
			Descuento = 0; 
			Lote = ""; 
			Caducidad = ""; 
			Proveedor = ""; 
			Tipodescuento = ""; 
			Publico = ""; 
			Obs = ""; 
			Base = 0; 
			Impuesto = ""; 
			Tipofactor = ""; 
			Tasa = 0; 
			Importeimpuesto = 0; 
			Registro = 0;

            CerEmisor = "";
            CerSat = "";
            SelloDigital = "";
            SelloDigitalSat = "";
            CadenaOriginal = "";
            qr = null;
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
        public DateTime FECHATIMBRADO
        {
            get { return FechaTimbrado; }
            set
            {
                if (value != null)
                {
                    if (value != FechaTimbrado)
                    {
                        FechaTimbrado = value;
                    }
                }
            }
        }
        public string RFCCERTIFICACION
        {
            get { return RfcCertificacion.ToString().Trim(); }
            set
            {
                if (value != RfcCertificacion)
                {
                    RfcCertificacion = value;
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
        public string TIPODOCUMENTO
        {
            get { return TipoDocumento.ToString().Trim(); }
            set
            {
                if (value != TipoDocumento)
                {
                    TipoDocumento = value;
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
		public string FOLIOFISCAL
		{
			get{ return Foliofiscal.ToString().Trim(); }
			set
			{
				if(value!=Foliofiscal)
				{
					Foliofiscal = value;
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
		public decimal TOTALDESCUENTO
		{
			get{ return Totaldescuento; }
			set
			{
				if(value!=Totaldescuento)
				{
					Totaldescuento = value;
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
		public string CFDIRELACIONADO
		{
			get{ return Cfdirelacionado.ToString().Trim(); }
			set
			{
				if(value!=Cfdirelacionado)
				{
					Cfdirelacionado = value;
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
            get { return NumRegIdTrib.ToString().Trim(); }
            set
            {
                if (value != NumRegIdTrib)
                {
                    NumRegIdTrib = value;
                }
            }
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
		public string SATCLAVEPROD
		{
			get{ return Satclaveprod.ToString().Trim(); }
			set
			{
				if(value!=Satclaveprod)
				{
					Satclaveprod = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string NOIDENTIFICACION
		{
			get{ return Noidentificacion.ToString().Trim(); }
			set
			{
				if(value!=Noidentificacion)
				{
					Noidentificacion = value;
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
		public string SATCLAVEUNIDAD
		{
			get{ return Satclaveunidad.ToString().Trim(); }
			set
			{
				if(value!=Satclaveunidad)
				{
					Satclaveunidad = value;
				}
			}
		}
		public string UNIDAD
		{
			get{ return Unidad.ToString().Trim(); }
			set
			{
				if(value!=Unidad)
				{
					Unidad = value;
				}
			}
		}
		public string DESCRIPCION
		{
			get{ return Descripcion.ToString().Trim(); }
			set
			{
				if(value!=Descripcion)
				{
					Descripcion = value;
				}
			}
		}
		public decimal VALORUNITARIO
		{
			get{ return Valorunitario; }
			set
			{
				if(value!=Valorunitario)
				{
					Valorunitario = value;
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
		[DataMember(IsRequired = true)]
		public string LOTE
		{
			get{ return Lote.ToString().Trim(); }
			set
			{
				if(value!=Lote)
				{
					Lote = value;
				}
			}
		}
		public string CADUCIDAD
		{
			get{ return Caducidad.ToString().Trim(); }
			set
			{
				if(value!=Caducidad)
				{
					Caducidad = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string PROVEEDOR
		{
			get{ return Proveedor.ToString().Trim(); }
			set
			{
				if(value!=Proveedor)
				{
					Proveedor = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string TIPODESCUENTO
		{
			get{ return Tipodescuento.ToString().Trim(); }
			set
			{
				if(value!=Tipodescuento)
				{
					Tipodescuento = value;
				}
			}
		}
		public string PUBLICO
		{
			get{ return Publico.ToString().Trim(); }
			set
			{
				if(value!=Publico)
				{
					Publico = value;
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
		public decimal BASE
		{
			get{ return Base; }
			set
			{
				if(value!=Base)
				{
					Base = value;
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
		public Int16 REGISTRO
		{
			get{ return Registro; }
			set
			{
				if(value!=Registro)
				{
					Registro = value;
				}
			}
		}

        public string CEREMISOR
        {
            get { return CerEmisor.ToString().Trim(); }
            set
            {
                    CerEmisor = value;
            }
        }
        public string CERSAT
        {
            get { return CerSat.ToString().Trim(); }
            set
            {
                    CerSat = value;
            }
        }
        public string SELLODIGITAL
        {
            get { return SelloDigital.ToString().Trim(); }
            set
            {
                    SelloDigital = value;
            }
        }
        public string SELLODIGITALSAT
        {
            get { return SelloDigitalSat.ToString().Trim(); }
            set
            {
                SelloDigitalSat = value;
            }
        }
        public string CADENAORIGINAL
        {
            get { return CadenaOriginal.ToString().Trim(); }
            set
            {
                CadenaOriginal = value;
            }
        }
        public byte[] QR
        {
            get { return qr; }
            set
            {
                qr = value;
            }
        }
    }
}
