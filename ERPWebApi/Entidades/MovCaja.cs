using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class MovCaja: IEntidadBase
	{
		private Int64 Id;
		private Int64 Iddocumento;
		private Int16 Idmetodopago;
		private Int16 Idcaja;
		private Int32 Idcortecaja;
		private Int16 Idbancocliprov;
		private Int16 Idcuentabanco;
		private DateTime Fecha;
		private decimal Saldocorte;
		private decimal Importepago;
		private string Cuentapago;
		private string Foliooperacion;
		private string Obs;

        [DataMember(IsRequired = true)]
        public virtual List<MovCajaDetalle> lMovCajaDetalle { get; set; }
        
        //Constructor
        public MovCaja()
		{
			Id = 0; 
			Iddocumento = 0; 
			Idmetodopago = 0; 
			Idcaja = 0; 
			Idcortecaja = 0; 
			Idbancocliprov = 0; 
			Idcuentabanco = 0; 
			Fecha = System.DateTime.Today;
			Saldocorte = 0; 
			Importepago = 0; 
			Cuentapago = ""; 
			Foliooperacion = ""; 
			Obs = "";

            lMovCajaDetalle = new List<MovCajaDetalle>();


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
		public Int16 IDCAJA
		{
			get{ return Idcaja; }
			set
			{
				if(value!=Idcaja)
				{
					
					Idcaja = value;
				}
			}
		}
		public Int32 IDCORTECAJA
		{
			get{ return Idcortecaja; }
			set
			{
				if(value!=Idcortecaja)
				{
					
					Idcortecaja = value;
				}
			}
		}
		public Int16 IDBANCOCLIPROV
		{
			get{ return Idbancocliprov; }
			set
			{
				if(value!=Idbancocliprov)
				{
					
					Idbancocliprov = value;
				}
			}
		}
		public Int16 IDCUENTABANCO
		{
			get{ return Idcuentabanco; }
			set
			{
				if(value!=Idcuentabanco)
				{
					
					Idcuentabanco = value;
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
		public decimal SALDOCORTE
		{
			get{ return Saldocorte; }
			set
			{
				if(value!=Saldocorte)
				{
					
					Saldocorte = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public decimal IMPORTEPAGO
		{
			get{ return Importepago; }
			set
			{
				if(value!=Importepago)
				{
					
					Importepago = value;
				}
			}
		}
		public string CUENTAPAGO
		{
			get{ return Cuentapago.ToString().Trim(); }
			set
			{
				if(value!=Cuentapago)
				{
					
					Cuentapago = value;
				}
			}
		}
		public string FOLIOOPERACION
		{
			get{ return Foliooperacion.ToString().Trim(); }
			set
			{
				if(value!=Foliooperacion)
				{
					
					Foliooperacion = value;
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
	}
}
