using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class CFDIBUZON_VISTA: IEntidadBase
	{
		private Int16 Idpincliente;
		private Int16 Idempresa;
		private Int16 Idsucursal;
		private Int64 Iddocumento;
		private Int64 Iddocfiscal;        
        private string Tipodocumento;
		private string Folio;
		private string Cliprov;
		private DateTime Fechadocumento;
		private DateTime Fechabuzon;
		private decimal Total;
		private string Moneda;
		private string Foliofiscal;
		private string Status;
		
		
		//Constructor
		public CFDIBUZON_VISTA()
		{
			Idpincliente = 0; 
			Idempresa = 0; 
			Idsucursal = 0; 
			Iddocumento = 0; 
			Iddocfiscal = 0;            
            Tipodocumento = ""; 
			Folio = ""; 
			Cliprov = ""; 
			Fechadocumento = System.DateTime.Today;
			Fechabuzon = System.DateTime.Today;
			Total = 0; 
			Moneda = ""; 
			Foliofiscal = ""; 
			Status = ""; 
			
		}
		
		public Int16 IDPINCLIENTE
		{
			get{ return Idpincliente; }
			set
			{
				if(value!=Idpincliente)
				{
					Idpincliente = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int16 IDEMPRESA
		{
			get{ return Idempresa; }
			set
			{
				if(value!=Idempresa)
				{
					Idempresa = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int16 IDSUCURSAL
		{
			get{ return Idsucursal; }
			set
			{
				if(value!=Idsucursal)
				{
					Idsucursal = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int64 IDDOCUMENTO
		{
			get{ return Iddocumento; }
			set
			{
				if(value!=Iddocumento)
				{
					Iddocumento = value;
				}
			}
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
		public string TIPODOCUMENTO
		{
			get{ return Tipodocumento.ToString().Trim(); }
			set
			{
				if(value!=Tipodocumento)
				{
					Tipodocumento = value;
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
		public string CLIPROV
		{
			get{ return Cliprov.ToString().Trim(); }
			set
			{
				if(value!=Cliprov)
				{
					Cliprov = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public DateTime FECHADOCUMENTO
		{
			get{ return Fechadocumento; }
			set
			{
				if (value != null)
				{
					if(value!=Fechadocumento)
					{
						Fechadocumento = value;
					}
				}
			}
		}
		[DataMember(IsRequired = true)]
		public DateTime FECHABUZON
		{
			get{ return Fechabuzon; }
			set
			{
				if (value != null)
				{
					if(value!=Fechabuzon)
					{
						Fechabuzon = value;
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
		[DataMember(IsRequired = true)]
		public string STATUS
		{
			get{ return Status.ToString().Trim(); }
			set
			{
				if(value!=Status)
				{
					Status = value;
				}
			}
		}
	}
}
