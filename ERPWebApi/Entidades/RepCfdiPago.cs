using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class RepCfdiPago: IEntidadBase
	{
		private Int64 Iddocfiscal;
		private string Serie;
		private Int64 Folio;
		private DateTime Fecha;
        private DateTime FechaTimbrado;
        private string RfcCertificacion;
        private string Condicionespago;
		private string Moneda;
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
        private string EmisorEmail;
        private Int32 Cajas;
		private Int32 Piezas;
		private string Satclaveprod;
		private string Noidentificacion;
		private decimal Cantidad;
		private string Satclaveunidad;
		private string Unidad;
		private string Descripcion;
		private Int32 Valorunitario;
		private Int32 Importe;
		private Int32 Descuento;
        private Int16 IdOrdenDocPago;
		private Int64 Idpago;
		private DateTime Fechapago;
		private string Formapago;
		private string Monedapago;
		private decimal Monto;
		private decimal Tipocambio;
		private string Nooperacion;
		private string Rfcbancoordenante;
		private string Bancoordenante;
		private string Rfcbancobeneficiario;
		private string Nocuentabeneficiario;
		private string Nodocumento;
		private string Seriedoc;
		private Int64 Foliodoc;
		private string Monedadoc;
		private decimal Tipocambiodoc;
		private string Metodopagodoc;
		private Int32 Parcialidad;
		private decimal Saldoanterior;
		private decimal Pagado;
		private decimal Saldoinsoluto;
        private string CerEmisor;
        private string CerSat;
        private string SelloDigital;
        private string SelloDigitalSat;
        private string CadenaOriginal;
        private byte[] qr;


        //Constructor
        public RepCfdiPago()
		{
			Iddocfiscal = 0; 
			Serie = ""; 
			Folio = 0; 
			Fecha = System.DateTime.Today;
            FechaTimbrado = System.DateTime.Today;
            RfcCertificacion = "";
            Condicionespago = ""; 
			Moneda = ""; 
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
            EmisorEmail = "";
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
            IdOrdenDocPago = 0;
            Idpago = 0; 
			Fechapago = System.DateTime.Today;
			Formapago = ""; 
			Monedapago = ""; 
			Monto = 0; 
			Tipocambio = 0; 
			Nooperacion = ""; 
			Rfcbancoordenante = ""; 
			Bancoordenante = ""; 
			Rfcbancobeneficiario = ""; 
			Nocuentabeneficiario = ""; 
			Nodocumento = ""; 
			Seriedoc = ""; 
			Foliodoc = 0; 
			Monedadoc = ""; 
			Tipocambiodoc = 0; 
			Metodopagodoc = ""; 
			Parcialidad = 0; 
			Saldoanterior = 0; 
			Pagado = 0; 
			Saldoinsoluto = 0;

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
		[DataMember(IsRequired = true)]
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
        public string EMISOREMAIL
        {
            get { return EmisorEmail.ToString().Trim(); }
            set
            {
                if (value != EmisorEmail)
                {
                    EmisorEmail = value;
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
		[DataMember(IsRequired = true)]
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
		[DataMember(IsRequired = true)]
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
		[DataMember(IsRequired = true)]
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
		[DataMember(IsRequired = true)]
		public Int32 VALORUNITARIO
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
		[DataMember(IsRequired = true)]
		public Int32 IMPORTE
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
		[DataMember(IsRequired = true)]
		public Int32 DESCUENTO
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
        public Int16 IDORDENDOCPAGO
        {
            get { return IdOrdenDocPago; }
            set
            {
                if (value != IdOrdenDocPago)
                {
                    IdOrdenDocPago = value;
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
		public string MONEDAPAGO
		{
			get{ return Monedapago.ToString().Trim(); }
			set
			{
				if(value!=Monedapago)
				{
					Monedapago = value;
				}
			}
		}
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
		public string SERIEDOC
		{
			get{ return Seriedoc.ToString().Trim(); }
			set
			{
				if(value!=Seriedoc)
				{
					Seriedoc = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int64 FOLIODOC
		{
			get{ return Foliodoc; }
			set
			{
				if(value!=Foliodoc)
				{
					Foliodoc = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string MONEDADOC
		{
			get{ return Monedadoc.ToString().Trim(); }
			set
			{
				if(value!=Monedadoc)
				{
					Monedadoc = value;
				}
			}
		}
		public decimal TIPOCAMBIODOC
		{
			get{ return Tipocambiodoc; }
			set
			{
				if(value!=Tipocambiodoc)
				{
					Tipocambiodoc = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string METODOPAGODOC
		{
			get{ return Metodopagodoc.ToString().Trim(); }
			set
			{
				if(value!=Metodopagodoc)
				{
					Metodopagodoc = value;
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
