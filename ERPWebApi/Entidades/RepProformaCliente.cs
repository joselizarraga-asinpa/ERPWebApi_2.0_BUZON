using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class RepProformaCliente: IEntidadBase
	{
        private long IdDocumento;
        private string Razonsocialempresa;
		private string Calleempresa;
		private string Colempresa;
		private string Ciudadempresa;
		private string Telefonosempresa;
		private string Rfc;
		private string Folio;
		private DateTime Fecha;
        private string FormaPago;
        private string Embarque;
		private string Realizo;
		private string Paginaweb;
		private string Contactocliente;
		private string Nombrecliente;
		private string Direccioncliente;
		private string Colcliente;
		private string Ciudadcliente;
		private string Telefonocliente;
		private string Celularcliente;
		private string Emailcliente;
		private string Contactoentrega;
		private string Nombreentrega;
		private string Direccionentrega;
		private string Colentrega;
		private string Ciudadentrega;
		private string Telefonoentrega;
		private string Celularentrega;
		private string Emailentrega;
		private Int16 Registro;
		private string Nombreproducto;
		private string Descripcion;
		private decimal Cantidad;
		private decimal Unitario;
		private decimal Subtotal;
        private decimal SubtotalTot;
        private decimal Impuestotrasladado;
		private decimal Total;
		private string Obs;
		private string Comentarios;
		private string Banco1;
		private string Nombrecuenta1;
		private string Numcuenta1;
		private string Clabecuenta1;
		private string Banco2;
		private string Nombrecuenta2;
		private string Numcuenta2;
		private string Clabecuenta2;
		
		
		//Constructor
		public RepProformaCliente()
		{
            IdDocumento = 0;
            Razonsocialempresa = ""; 
			Calleempresa = ""; 
			Colempresa = ""; 
			Ciudadempresa = ""; 
			Telefonosempresa = ""; 
			Rfc = ""; 
			Folio = ""; 
			Fecha = System.DateTime.Today;
            FormaPago = "";
            Embarque = ""; 
			Realizo = ""; 
			Paginaweb = ""; 
			Contactocliente = ""; 
			Nombrecliente = ""; 
			Direccioncliente = ""; 
			Colcliente = ""; 
			Ciudadcliente = ""; 
			Telefonocliente = ""; 
			Celularcliente = ""; 
			Emailcliente = ""; 
			Contactoentrega = ""; 
			Nombreentrega = ""; 
			Direccionentrega = ""; 
			Colentrega = ""; 
			Ciudadentrega = ""; 
			Telefonoentrega = ""; 
			Celularentrega = ""; 
			Emailentrega = ""; 
			Registro = 0; 
			Nombreproducto = ""; 
			Descripcion = ""; 
			Cantidad = 0; 
			Unitario = 0; 
			Subtotal = 0; 
			Impuestotrasladado = 0; 
			Total = 0; 
			Obs = ""; 
			Comentarios = ""; 
			Banco1 = ""; 
			Nombrecuenta1 = ""; 
			Numcuenta1 = ""; 
			Clabecuenta1 = ""; 
			Banco2 = ""; 
			Nombrecuenta2 = ""; 
			Numcuenta2 = ""; 
			Clabecuenta2 = ""; 
			
		}

        public long IDDOCUMENTO
        {
            get { return IdDocumento; }
            set
            {
                IdDocumento = value;
            }
        }
		
		public string RAZONSOCIALEMPRESA
		{
			get{ return Razonsocialempresa.ToString().Trim(); }
			set
			{
				if(value!=Razonsocialempresa)
				{
					Razonsocialempresa = value;
				}
			}
		}
		public string CALLEEMPRESA
		{
			get{ return Calleempresa.ToString().Trim(); }
			set
			{
				if(value!=Calleempresa)
				{
					Calleempresa = value;
				}
			}
		}
		public string COLEMPRESA
		{
			get{ return Colempresa.ToString().Trim(); }
			set
			{
				if(value!=Colempresa)
				{
					Colempresa = value;
				}
			}
		}
		public string CIUDADEMPRESA
		{
			get{ return Ciudadempresa.ToString().Trim(); }
			set
			{
				if(value!=Ciudadempresa)
				{
					Ciudadempresa = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string TELEFONOSEMPRESA
		{
			get{ return Telefonosempresa.ToString().Trim(); }
			set
			{
				if(value!=Telefonosempresa)
				{
					Telefonosempresa = value;
				}
			}
		}
		public string RFC
		{
			get{ return Rfc.ToString().Trim(); }
			set
			{
				if(value!=Rfc)
				{
					Rfc = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
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
            get { return FormaPago.ToString().Trim(); }
            set
            {
                if (value != FormaPago)
                {
                    FormaPago = value;
                }
            }
        }
        [DataMember(IsRequired = true)]
		public string EMBARQUE
		{
			get{ return Embarque.ToString().Trim(); }
			set
			{
				if(value!=Embarque)
				{
					Embarque = value;
				}
			}
		}
		public string REALIZO
		{
			get{ return Realizo.ToString().Trim(); }
			set
			{
				if(value!=Realizo)
				{
					Realizo = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string PAGINAWEB
		{
			get{ return Paginaweb.ToString().Trim(); }
			set
			{
				if(value!=Paginaweb)
				{
					Paginaweb = value;
				}
			}
		}
		public string CONTACTOCLIENTE
		{
			get{ return Contactocliente.ToString().Trim(); }
			set
			{
				if(value!=Contactocliente)
				{
					Contactocliente = value;
				}
			}
		}
		public string NOMBRECLIENTE
		{
			get{ return Nombrecliente.ToString().Trim(); }
			set
			{
				if(value!=Nombrecliente)
				{
					Nombrecliente = value;
				}
			}
		}
		public string DIRECCIONCLIENTE
		{
			get{ return Direccioncliente.ToString().Trim(); }
			set
			{
				if(value!=Direccioncliente)
				{
					Direccioncliente = value;
				}
			}
		}
		public string COLCLIENTE
		{
			get{ return Colcliente.ToString().Trim(); }
			set
			{
				if(value!=Colcliente)
				{
					Colcliente = value;
				}
			}
		}
		public string CIUDADCLIENTE
		{
			get{ return Ciudadcliente.ToString().Trim(); }
			set
			{
				if(value!=Ciudadcliente)
				{
					Ciudadcliente = value;
				}
			}
		}
		public string TELEFONOCLIENTE
		{
			get{ return Telefonocliente.ToString().Trim(); }
			set
			{
				if(value!=Telefonocliente)
				{
					Telefonocliente = value;
				}
			}
		}
		public string CELULARCLIENTE
		{
			get{ return Celularcliente.ToString().Trim(); }
			set
			{
				if(value!=Celularcliente)
				{
					Celularcliente = value;
				}
			}
		}
		public string EMAILCLIENTE
		{
			get{ return Emailcliente.ToString().Trim(); }
			set
			{
				if(value!=Emailcliente)
				{
					Emailcliente = value;
				}
			}
		}
		public string CONTACTOENTREGA
		{
			get{ return Contactoentrega.ToString().Trim(); }
			set
			{
				if(value!=Contactoentrega)
				{
					Contactoentrega = value;
				}
			}
		}
		public string NOMBREENTREGA
		{
			get{ return Nombreentrega.ToString().Trim(); }
			set
			{
				if(value!=Nombreentrega)
				{
					Nombreentrega = value;
				}
			}
		}
		public string DIRECCIONENTREGA
		{
			get{ return Direccionentrega.ToString().Trim(); }
			set
			{
				if(value!=Direccionentrega)
				{
					Direccionentrega = value;
				}
			}
		}
		public string COLENTREGA
		{
			get{ return Colentrega.ToString().Trim(); }
			set
			{
				if(value!=Colentrega)
				{
					Colentrega = value;
				}
			}
		}
		public string CIUDADENTREGA
		{
			get{ return Ciudadentrega.ToString().Trim(); }
			set
			{
				if(value!=Ciudadentrega)
				{
					Ciudadentrega = value;
				}
			}
		}
		public string TELEFONOENTREGA
		{
			get{ return Telefonoentrega.ToString().Trim(); }
			set
			{
				if(value!=Telefonoentrega)
				{
					Telefonoentrega = value;
				}
			}
		}
		public string CELULARENTREGA
		{
			get{ return Celularentrega.ToString().Trim(); }
			set
			{
				if(value!=Celularentrega)
				{
					Celularentrega = value;
				}
			}
		}
		public string EMAILENTREGA
		{
			get{ return Emailentrega.ToString().Trim(); }
			set
			{
				if(value!=Emailentrega)
				{
					Emailentrega = value;
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
        public decimal SUBTOTALTOT
        {
            get { return SubtotalTot; }
            set
            {
                if (value != SubtotalTot)
                {
                    SubtotalTot = value;
                }
            }
        }
        public decimal IMPUESTOTRASLADADO
		{
			get{ return Impuestotrasladado; }
			set
			{
				if(value!=Impuestotrasladado)
				{
					Impuestotrasladado = value;
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
		public string COMENTARIOS
		{
			get{ return Comentarios.ToString().Trim(); }
			set
			{
				if(value!=Comentarios)
				{
					Comentarios = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string BANCO1
		{
			get{ return Banco1.ToString().Trim(); }
			set
			{
				if(value!=Banco1)
				{
					Banco1 = value;
				}
			}
		}
		public string NOMBRECUENTA1
		{
			get{ return Nombrecuenta1.ToString().Trim(); }
			set
			{
				if(value!=Nombrecuenta1)
				{
					Nombrecuenta1 = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string NUMCUENTA1
		{
			get{ return Numcuenta1.ToString().Trim(); }
			set
			{
				if(value!=Numcuenta1)
				{
					Numcuenta1 = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string CLABECUENTA1
		{
			get{ return Clabecuenta1.ToString().Trim(); }
			set
			{
				if(value!=Clabecuenta1)
				{
					Clabecuenta1 = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string BANCO2
		{
			get{ return Banco2.ToString().Trim(); }
			set
			{
				if(value!=Banco2)
				{
					Banco2 = value;
				}
			}
		}
		public string NOMBRECUENTA2
		{
			get{ return Nombrecuenta2.ToString().Trim(); }
			set
			{
				if(value!=Nombrecuenta2)
				{
					Nombrecuenta2 = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string NUMCUENTA2
		{
			get{ return Numcuenta2.ToString().Trim(); }
			set
			{
				if(value!=Numcuenta2)
				{
					Numcuenta2 = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string CLABECUENTA2
		{
			get{ return Clabecuenta2.ToString().Trim(); }
			set
			{
				if(value!=Clabecuenta2)
				{
					Clabecuenta2 = value;
				}
			}
		}
	}
}
