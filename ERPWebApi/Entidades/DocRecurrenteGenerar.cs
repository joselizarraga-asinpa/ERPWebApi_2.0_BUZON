using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class DocRecurrenteGenerar: IEntidadBase
	{
        private DateTime Fecha;
        private Int16 IdSucursal;
		private Int32 Iddocrecurrente;
		private string Nombredocrecurrente;
        private Int16 ModalidadPrecios;
		private Int32 Idcliprov;
        private Int16 IdMoneda;
        private string Nombrecliprov;
		private Int16 Idtipodocumento;
		private string Nombretipodoc;		
        private long IdDocOrigen;
        private long IdDocGenerado;
        private long IdDocFiscalOrigen;
        private long IdDocFiscalGenerado;        
		private string Obs;
		private Int16 Idusocfdi;
		private string Nombreusocfdi;
		private Int16 Idcondicionpago;
		private string Nombrecondicionpago;
		private Int16 Idmetodopago;
		private string Nombremetodopago;
		private string Email;
		private decimal Subtotal;
		private decimal Iva;
		private decimal Total;
        private string Folio;
        private string Foliofiscal;
        private bool Documento_generado;
		private bool Docfiscal_generado;
		private bool Docfiscal_timbrado;
        private bool Docfiscal_descargado;
        private bool Docfiscal_enviado;
		
		
		//Constructor
		public DocRecurrenteGenerar()
		{
            Fecha = DateTime.Now;
            IdSucursal = 0;
			Iddocrecurrente = 0; 
			Nombredocrecurrente = "";
            ModalidadPrecios = 0;
            Idcliprov = 0;
            IdMoneda = 0;
            Nombrecliprov = ""; 
			Idtipodocumento = 0; 
			Nombretipodoc = ""; 
			Folio = "";
            IdDocOrigen = 0;
            IdDocGenerado = 0;
            IdDocFiscalOrigen = 0;
            IdDocFiscalGenerado = 0;
            Foliofiscal = ""; 
			Obs = ""; 
			Idusocfdi = 0; 
			Nombreusocfdi = ""; 
			Idcondicionpago = 0; 
			Nombrecondicionpago = ""; 
			Idmetodopago = 0; 
			Nombremetodopago = ""; 
			Email = ""; 
			Subtotal = 0; 
			Iva = 0; 
			Total = 0; 
			Documento_generado = false; 
			Docfiscal_generado = false; 
			Docfiscal_timbrado = false;
            Docfiscal_descargado = false;
            Docfiscal_enviado = false; 
			
		}

        [DataMember(IsRequired = true)]
        public DateTime FECHA
        {
            get { return Fecha; }
            set
            {
                Fecha = value;
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
		public Int32 IDDOCRECURRENTE
		{
			get{ return Iddocrecurrente; }
			set
			{
				if(value!=Iddocrecurrente)
				{
					Iddocrecurrente = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string NOMBREDOCRECURRENTE
		{
			get{ return Nombredocrecurrente.ToString().Trim(); }
			set
			{
				if(value!=Nombredocrecurrente)
				{
					Nombredocrecurrente = value;
				}
			}
		}
        public Int16 MODALIDADPRECIOS
        {
            get { return ModalidadPrecios; }
            set
            {
                if (value != ModalidadPrecios)
                {
                    ModalidadPrecios = value;
                }
            }
        }
        [DataMember(IsRequired = true)]
		public Int32 IDCLIPROV
		{
			get{ return Idcliprov; }
			set
			{
				if(value!=Idcliprov)
				{
					Idcliprov = value;
				}
			}
		}
        [DataMember(IsRequired = true)]
        public Int16 IDMONEDA
        {
            get { return IdMoneda; }
            set
            {
                if (value != IdMoneda)
                {
                    IdMoneda = value;
                }
            }
        }
        public string NOMBRECLIPROV
		{
			get{ return Nombrecliprov.ToString().Trim(); }
			set
			{
				if(value!=Nombrecliprov)
				{
					Nombrecliprov = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int16 IDTIPODOCUMENTO
		{
			get{ return Idtipodocumento; }
			set
			{
				if(value!=Idtipodocumento)
				{
					Idtipodocumento = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
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
		
        public long IDDOCORIGEN
        {
            get { return IdDocOrigen; }
            set
            {
                if (value != IdDocOrigen)
                {
                    IdDocOrigen = value;
                }
            }
        }
        public long IDDOCGENERADO
        {
            get { return IdDocGenerado; }
            set
            {
                if (value != IdDocGenerado)
                {
                    IdDocGenerado = value;
                }
            }
        }
        public long IDDOCFISCALORIGEN
        {
            get { return IdDocFiscalOrigen; }
            set
            {
                if (value != IdDocFiscalOrigen)
                {
                    IdDocFiscalOrigen = value;
                }
            }
        }
        public long IDDOCFISCALGENERADO
        {
            get { return IdDocFiscalGenerado; }
            set
            {
                if (value != IdDocFiscalGenerado)
                {
                    IdDocFiscalGenerado = value;
                }
            }
        }
        
        
		[DataMember(IsRequired = true)]
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
		public Int16 IDUSOCFDI
		{
			get{ return Idusocfdi; }
			set
			{
				if(value!=Idusocfdi)
				{
					Idusocfdi = value;
				}
			}
		}
		public string NOMBREUSOCFDI
		{
			get{ return Nombreusocfdi.ToString().Trim(); }
			set
			{
				if(value!=Nombreusocfdi)
				{
					Nombreusocfdi = value;
				}
			}
		}
		public Int16 IDCONDICIONPAGO
		{
			get{ return Idcondicionpago; }
			set
			{
				if(value!=Idcondicionpago)
				{
					Idcondicionpago = value;
				}
			}
		}
		public string NOMBRECONDICIONPAGO
		{
			get{ return Nombrecondicionpago.ToString().Trim(); }
			set
			{
				if(value!=Nombrecondicionpago)
				{
					Nombrecondicionpago = value;
				}
			}
		}
		public Int16 IDMETODOPAGO
		{
			get{ return Idmetodopago; }
			set
			{
				if(value!=Idmetodopago)
				{
					Idmetodopago = value;
				}
			}
		}
		public string NOMBREMETODOPAGO
		{
			get{ return Nombremetodopago.ToString().Trim(); }
			set
			{
				if(value!=Nombremetodopago)
				{
					Nombremetodopago = value;
				}
			}
		}
		public string EMAIL
		{
			get{ return Email.ToString().Trim(); }
			set
			{
				if(value!=Email)
				{
					Email = value;
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
		public decimal IVA
		{
			get{ return Iva; }
			set
			{
				if(value!=Iva)
				{
					Iva = value;
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
        public string FOLIOFISCAL
        {
            get { return Foliofiscal.ToString().Trim(); }
            set
            {
                if (value != Foliofiscal)
                {
                    Foliofiscal = value;
                }
            }
        }
        public bool DOCUMENTO_GENERADO
		{
			get{ return Documento_generado; }
			set
			{
				if(value!=Documento_generado)
				{
					Documento_generado = value;
				}
			}
		}
		public bool DOCFISCAL_GENERADO
		{
			get{ return Docfiscal_generado; }
			set
			{
				if(value!=Docfiscal_generado)
				{
					Docfiscal_generado = value;
				}
			}
		}
		public bool DOCFISCAL_TIMBRADO
		{
			get{ return Docfiscal_timbrado; }
			set
			{
				if(value!=Docfiscal_timbrado)
				{
					Docfiscal_timbrado = value;
				}
			}
		}
        [DataMember(IsRequired = true)]
        public bool DOCFISCAL_DESCARGADO
        {
            get { return Docfiscal_descargado; }
            set
            {
                if (value != Docfiscal_descargado)
                {
                    Docfiscal_descargado = value;
                }
            }
        }
        [DataMember(IsRequired = true)]
		public bool DOCFISCAL_ENVIADO
		{
			get{ return Docfiscal_enviado; }
			set
			{
				if(value!=Docfiscal_enviado)
				{
					Docfiscal_enviado = value;
				}
			}
		}
	}
}
