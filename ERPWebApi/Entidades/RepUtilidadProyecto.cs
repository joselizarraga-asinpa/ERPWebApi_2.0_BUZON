using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class RepUtilidadProyecto: IEntidadBase
	{
        public long IdDocumento;
		private string Folio;
		private string Dirigidoa;
		private string Destino;
		private string Cliente;
		private string Obs;
		private string Grupo;
        private string GrupoFlujo;
        private Int16 Orden;
		private string Concepto;
        private DateTime Fecha;
        private decimal Importe;
		private decimal Factor;
        private decimal PorcentajeProyecto;


        //Constructor
        public RepUtilidadProyecto()
		{
            IdDocumento = 0;
            Folio = ""; 
			Dirigidoa = ""; 
			Destino = ""; 
			Cliente = ""; 
			Obs = ""; 
			Grupo = "";
            GrupoFlujo = "";
            Orden = 0; 
			Concepto = ""; 
            Fecha = System.DateTime.Today;
            Importe = 0; 
			Factor = 0;
            PorcentajeProyecto = 0;


        }

        public long IDDOCUMENTO
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
		public string DIRIGIDOA
		{
			get{ return Dirigidoa.ToString().Trim(); }
			set
			{
				if(value!=Dirigidoa)
				{
					Dirigidoa = value;
				}
			}
		}
		public string DESTINO
		{
			get{ return Destino.ToString().Trim(); }
			set
			{
				if(value!=Destino)
				{
					Destino = value;
				}
			}
		}
		public string CLIENTE
		{
			get{ return Cliente.ToString().Trim(); }
			set
			{
				if(value!=Cliente)
				{
					Cliente = value;
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
		public string GRUPO
		{
			get{ return Grupo.ToString().Trim(); }
			set
			{
				if(value!=Grupo)
				{
					Grupo = value;
				}
			}
		}
        public string GRUPOFLUJO
        {
            get { return GrupoFlujo.ToString().Trim(); }
            set
            {
                if (value != GrupoFlujo)
                {
                    GrupoFlujo = value;
                }
            }
        }
        public Int16 ORDEN
		{
			get{ return Orden; }
			set
			{
				if(value!=Orden)
				{
					Orden = value;
				}
			}
		}
		public string CONCEPTO
		{
			get{ return Concepto.ToString().Trim(); }
			set
			{
				if(value!=Concepto)
				{
					Concepto = value;
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
		public decimal FACTOR
		{
			get{ return Factor; }
			set
			{
				if(value!=Factor)
				{
					Factor = value;
				}
			}
		}
        public decimal PORCENTAJEPROYECTO
        {
            get { return PorcentajeProyecto; }
            set
            {
                if (value != PorcentajeProyecto)
                {
                    PorcentajeProyecto = value;
                }
            }
        }
    }
}
