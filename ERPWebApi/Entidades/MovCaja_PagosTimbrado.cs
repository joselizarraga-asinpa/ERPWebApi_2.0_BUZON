using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class MovCaja_PagosTimbrado: IEntidadBase
	{
        private long Id;
		private DateTime Fecha;
		private Int64 Iddocumento;
		private string Folio;
		private string Nombretipodoc;
		private DateTime Timbrado;
		private decimal Total;
		private decimal Pagado;
		
		
		//Constructor
		public MovCaja_PagosTimbrado()
		{
            Id = 0;
            Fecha = System.DateTime.Today;
			Iddocumento = 0; 
			Folio = ""; 
			Nombretipodoc = ""; 
			Timbrado = System.DateTime.Today;
			Total = 0; 
			Pagado = 0; 
			
		}

        [DataMember(IsRequired = true)]
        public Int64 ID
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
		public DateTime TIMBRADO
		{
			get{ return Timbrado; }
			set
			{
				if (value != null)
				{
					if(value!=Timbrado)
					{
						Timbrado = value;
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
	}
}
