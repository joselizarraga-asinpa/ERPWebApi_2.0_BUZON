using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class DocFiscal: IEntidadBase
	{
		private Int64 Id;
		private Int16 Idtipodocumento;
        private Int16 Idsucursal;
        private Int32 Idcliprov;
		private Int16 Idmetodopago;
		private Int16 Idusocfdi;
        private Int16 IdCondicionpago;
        private Int64 Iddocfiscal;
		private Int64 Idcfdi;
        private Int16 Idtiporelacioncfdi;
        private string Serie;
        private Int64 Folio;
		private string Foliofiscal;
		private bool Global;
        private bool Complementos;
        private bool GuardaComplementos;
        private Int16 Plazo;
		private DateTime Fecha;
		private DateTime Timbrado;
		private DateTime Cancelado;
		private string Obs;
        private Int64 IdDocumento;


        //Constructor
        public DocFiscal()
		{
			Id = 0; 
			Idtipodocumento = 0;
            Idsucursal = 0;
            Idcliprov = 0; 
			Idmetodopago = 0; 
			Idusocfdi = 0;
            IdCondicionpago = 0;
            Iddocfiscal = 0; 
			Idcfdi = 0;
            Idtiporelacioncfdi = 0;
            Serie = "";
            Folio = 0; 
			Foliofiscal = ""; 
			Global = false;
            Complementos = false;
            GuardaComplementos = false;
            Plazo = 0; 
			Fecha = System.DateTime.Today;
			Timbrado = System.DateTime.Parse("01/01/2000");
            Cancelado = System.DateTime.Parse("01/01/2000");
            Obs = "";
            IdDocumento = 0;


        }
		
		public Int64 ID
		{
			get{ return Id; }
			set
			{
				if(value!=Id)
				{
					
					Id = value;
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
        public Int16 IDSUCURSAL
        {
            get { return Idsucursal; }
            set
            {
                if (value != Idsucursal)
                {

                    Idsucursal = value;
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
		[DataMember(IsRequired = true)]
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
		public Int64 IDCFDI
		{
			get{ return Idcfdi; }
			set
			{
				if(value!=Idcfdi)
				{
					
					Idcfdi = value;
				}
			}
		}
        public Int16 IDTIPORELACIONCFDI
        {
            get { return Idtiporelacioncfdi; }
            set
            {
                if (value != Idtiporelacioncfdi)
                {

                    Idtiporelacioncfdi = value;
                }
            }
        }
        public string SERIE
        {
            get { return Serie.ToString().Trim(); }
            set
            {
                if (value != Serie)
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
		public bool GLOBAL
		{
			get{ return Global; }
			set
			{
				if(value!=Global)
				{
					
					Global = value;
				}
			}
		}
        public bool COMPLEMENTOS
        {
            get { return Complementos; }
            set
            {
                if (value != Complementos)
                {

                    Complementos = value;
                }
            }
        }

        public bool GUARDACOMPLEMENTOS
        {
            get { return GuardaComplementos; }
            set
            {
                if (value != GuardaComplementos)
                {

                    GuardaComplementos = value;
                }
            }
        }
        public Int16 IDCONDICIONPAGO
		{
			get{ return IdCondicionpago; }
			set
			{
				if(value!=IdCondicionpago)
				{
					
					IdCondicionpago = value;
				}
			}
		}
		public Int16 PLAZO
		{
			get{ return Plazo; }
			set
			{
				if(value!=Plazo)
				{
					
					Plazo = value;
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
		public DateTime CANCELADO
		{
			get{ return Cancelado; }
			set
			{
				if (value != null)
				{
					if(value!=Cancelado)
					{
						
						Cancelado = value;
					}
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
        public Int64 IDDOCUMENTO
        {
            get { return IdDocumento; }
            set
            {
                if (value != IdDocumento)
                {

                    IdDocumento = value;
                }
            }
        }
    }
}
