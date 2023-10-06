using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class Cfdi: IEntidadBase
	{
		private Int64 Iddocfiscal;
		private string Serie;
		private string Nodocumento;
		private DateTime Feemision;
		private DateTime Fetimbrado;
		private string Version;
		private string Ceremisor;
		private string Cersat;
		private string Sellodigital;
		private string Sellodigitalsat;
        private string Xml;
		private byte[] Qr;
		private string Cadenaoriginal;
		private DateTime Feemail;
		private string Usuario;
		
		
		//Constructor
		public Cfdi()
		{
			Iddocfiscal = 0; 
			Serie = ""; 
			Nodocumento = ""; 
			Feemision = System.DateTime.Today;
			Fetimbrado = System.DateTime.Today;
			Version = ""; 
			Ceremisor = ""; 
			Cersat = ""; 
			Sellodigital = ""; 
			Sellodigitalsat = "";
            Xml = "";
            Qr = null; 
			Cadenaoriginal = ""; 
			Feemail = System.DateTime.Today;
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
		public DateTime FEEMISION
		{
			get{ return Feemision; }
			set
			{
				if (value != null)
				{
					if(value!=Feemision)
					{
						Feemision = value;
					}
				}
			}
		}
		public DateTime FETIMBRADO
		{
			get{ return Fetimbrado; }
			set
			{
				if (value != null)
				{
					if(value!=Fetimbrado)
					{
						Fetimbrado = value;
					}
				}
			}
		}
		public string VERSION
		{
			get{ return Version.ToString().Trim(); }
			set
			{
				if(value!=Version)
				{
					Version = value;
				}
			}
		}
		public string CEREMISOR
		{
			get{ return Ceremisor.ToString().Trim(); }
			set
			{
				if(value!=Ceremisor)
				{
					Ceremisor = value;
				}
			}
		}
		public string CERSAT
		{
			get{ return Cersat.ToString().Trim(); }
			set
			{
				if(value!=Cersat)
				{
					Cersat = value;
				}
			}
		}
		public string SELLODIGITAL
		{
			get{ return Sellodigital.ToString().Trim(); }
			set
			{
				if(value!=Sellodigital)
				{
					Sellodigital = value;
				}
			}
		}
		public string SELLODIGITALSAT
		{
			get{ return Sellodigitalsat.ToString().Trim(); }
			set
			{
				if(value!=Sellodigitalsat)
				{
					Sellodigitalsat = value;
				}
			}
		}
        public string XML
        {
            get { return Xml; }
            set
            {
                if (value != Xml)
                {
                    Xml = value;
                }
            }
        }
        public byte[] QR
		{
			get{ return Qr; }
			set
			{
				if(value!=Qr)
				{
					Qr = value;
				}
			}
		}
		public string CADENAORIGINAL
		{
			get{ return Cadenaoriginal.ToString().Trim(); }
			set
			{
				if(value!=Cadenaoriginal)
				{
					Cadenaoriginal = value;
				}
			}
		}
		public DateTime FEEMAIL
		{
			get{ return Feemail; }
			set
			{
				if (value != null)
				{
					if(value!=Feemail)
					{
						Feemail = value;
					}
				}
			}
		}
		public string USUARIO
		{
			get{ return Usuario.ToString().Trim(); }
			set
			{
				if(value!=Usuario)
				{
					Usuario = value;
				}
			}
		}
	}
}
