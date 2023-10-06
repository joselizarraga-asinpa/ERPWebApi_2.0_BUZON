using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class RepAuxiliarInventarios: IEntidadBase
	{
		private DateTime Desdefecha;
		private DateTime Hastafecha;
        private Int16 Idempresa;
        private Int16 Idsucursal;
        private Int16 Idalmacen;        
        private Int32 Idproducto;
		private string Clasificaciones;
		private Int32 Id;
		private string Nombrealmacen;
		private string Nombreproducto;
		private string Nombretipoproducto;
		private decimal Unidad;
		private string Nombretipounidad;
		private string Codigo;        
        private string Nombretipodoc;
		private string Folio;
		private string NombreCliProv;
		private DateTime Fecha;
		private string Obs;
		private decimal Cantidad;
        private decimal Costo;
        private decimal ImporteCosto;
        private decimal Unitario;
        private decimal Importe;
        private string Lote;
        private DateTime Caducidad;
        private string Serie1;
        private string Serie2;
        private string Serie3;
        private string Serie4;
        private string Serie5;

        private bool LoteVisible;
        private bool CaducidadVisible;
        private bool Serie1Visible;
        private bool Serie2Visible;
        private bool Serie3Visible;
        private bool Serie4Visible;
        private bool Serie5Visible;


        //Constructor
        public RepAuxiliarInventarios()
		{
			Desdefecha = System.DateTime.Today;
			Hastafecha = System.DateTime.Today;
            Idempresa = 0;
            Idsucursal = 0;
			Idalmacen = 0;            
            Idproducto = 0; 
			Clasificaciones = ""; 
			Id = 0; 
			Nombrealmacen = ""; 
			Nombreproducto = ""; 
			Nombretipoproducto = ""; 
			Unidad = 0; 
			Nombretipounidad = ""; 
			Codigo = "";
            Lote = "";
            Caducidad = DateTime.Parse("01/01/2000");
            Serie1 = "";
            Serie2 = "";
            Serie3 = "";
            Serie4 = "";
            Serie5 = "";
            Nombretipodoc = ""; 
			Folio = "";
            NombreCliProv = ""; 
			Fecha = System.DateTime.Today;
			Obs = ""; 
			Cantidad = 0;
            Costo = 0;
            ImporteCosto = 0;
            Unitario = 0;
            Importe = 0;

            LoteVisible = false;
            CaducidadVisible = false;
            Serie1Visible = false;
            Serie2Visible = false;
            Serie3Visible = false;
            Serie4Visible = false;
            Serie5Visible = false;

    }
		
		public DateTime DESDEFECHA
		{
			get{ return Desdefecha; }
			set
			{
				if (value != null)
				{
					if(value!=Desdefecha)
					{
						
						Desdefecha = value;
					}
				}
			}
		}
		public DateTime HASTAFECHA
		{
			get{ return Hastafecha; }
			set
			{
				if (value != null)
				{
					if(value!=Hastafecha)
					{
						
						Hastafecha = value;
					}
				}
			}
		}
        public Int16 IDEMPRESA
        {
            get { return Idempresa; }
            set
            {
                if (value != Idempresa)
                {

                    Idempresa = value;
                }
            }
        }
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
        public Int16 IDALMACEN
		{
			get{ return Idalmacen; }
			set
			{
				if(value!=Idalmacen)
				{
					
					Idalmacen = value;
				}
			}
		}

        public Int32 IDPRODUCTO
		{
			get{ return Idproducto; }
			set
			{
				if(value!=Idproducto)
				{
					
					Idproducto = value;
				}
			}
		}
		public string CLASIFICACIONES
		{
			get{ return Clasificaciones.ToString().Trim(); }
			set
			{
				if(value!=Clasificaciones)
				{
					
					Clasificaciones = value;
				}
			}
		}
		public Int32 ID
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
		
		public string NOMBREALMACEN
		{
			get{ return Nombrealmacen.ToString().Trim(); }
			set
			{
				if(value!=Nombrealmacen)
				{
					
					Nombrealmacen = value;
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
		
		public string NOMBRETIPOPRODUCTO
		{
			get{ return Nombretipoproducto.ToString().Trim(); }
			set
			{
				if(value!=Nombretipoproducto)
				{
					
					Nombretipoproducto = value;
				}
			}
		}
		
		public decimal UNIDAD
		{
			get{ return Unidad; }
			set
			{
				if(value!=Unidad)
				{
					
					Unidad = value;
				}
			}
		}
		public string NOMBRETIPOUNIDAD
		{
			get{ return Nombretipounidad.ToString().Trim(); }
			set
			{
				if(value!=Nombretipounidad)
				{
					
					Nombretipounidad = value;
				}
			}
		}
		
		public string CODIGO
		{
			get{ return Codigo.ToString().Trim(); }
			set
			{
				if(value!=Codigo)
				{
					
					Codigo = value;
				}
			}
		}

        public string LOTE
        {
            get { return Lote.ToString().Trim(); }
            set
            {
                Lote = value;                
            }
        }

        public DateTime CADUCIDAD
        {
            get { return Caducidad; }
            set
            {
                Caducidad = value;                
            }
        }

        public string SERIE1
        {
            get { return Serie1.ToString().Trim(); }
            set
            {
                Serie1 = value;
            }
        }

        public string SERIE2
        {
            get { return Serie2.ToString().Trim(); }
            set
            {
                Serie2 = value;
            }
        }

        public string SERIE3
        {
            get { return Serie3.ToString().Trim(); }
            set
            {
                Serie3 = value;
            }
        }

        public string SERIE4
        {
            get { return Serie4.ToString().Trim(); }
            set
            {
                Serie4 = value;
            }
        }

        public string SERIE5
        {
            get { return Serie5.ToString().Trim(); }
            set
            {
                Serie5 = value;
            }
        }

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
		public string NOMBRECLIPROV
		{
			get{ return NombreCliProv.ToString().Trim(); }
			set
			{
				if(value!= NombreCliProv)
				{
					
                    NombreCliProv = value;
				}
			}
		}
		
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
        public decimal COSTO
        {
            get { return Costo; }
            set
            {
                if (value != Costo)
                {
                    
                    Costo = value;
                }
            }
        }
        public decimal IMPORTECOSTO
        {
            get { return ImporteCosto; }
            set
            {
                if (value != ImporteCosto)
                {
                    
                    ImporteCosto = value;
                }
            }
        }
        public decimal UNITARIO
        {
            get { return Unitario; }
            set
            {
                if (value != Unitario)
                {

                    Unitario = value;
                }
            }
        }
        public decimal IMPORTE
        {
            get { return Importe; }
            set
            {
                if (value != Importe)
                {

                    Importe = value;
                }
            }
        }
        public bool LOTEVISIBLE
        {
            get { return LoteVisible; }
            set
            {
                LoteVisible = value;
            }
        }
        public bool CADUCIDADVISIBLE
        {
            get { return CaducidadVisible; }
            set
            {
                CaducidadVisible = value;
            }
        }
        public bool SERIE1VISIBLE
        {
            get { return Serie1Visible; }
            set
            {
                Serie1Visible = value;
            }
        }
        public bool SERIE2VISIBLE
        {
            get { return Serie2Visible; }
            set
            {
                Serie2Visible = value;
            }
        }
        public bool SERI31VISIBLE
        {
            get { return Serie3Visible; }
            set
            {
                Serie3Visible = value;
            }
        }
        public bool SERIE4VISIBLE
        {
            get { return Serie4Visible; }
            set
            {
                Serie4Visible = value;
            }
        }
        public bool SERIE5VISIBLE
        {
            get { return Serie5Visible; }
            set
            {
                Serie5Visible = value;
            }
        }
    }
}
