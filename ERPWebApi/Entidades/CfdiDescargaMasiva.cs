using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class CfdiDescargaMasiva: IEntidadBase
	{
		private Int32 Id;
		private string Rfcsolicitante;
		private string Rfcemisor;
		private string Rfcreceptor;
		private DateTime Fechainicial;
		private DateTime Fechafinal;
		private DateTime Fechasolicitud;
		private DateTime Fechaverificacion;
		private DateTime Fechadescarga;
		private string Idsolicitud;
		private string Iddescarga;
		private string Idpaquete;
		private Int32 Estadosolicitud;
        private string EstadosolicitudDesc;
        private Int16 Codigoestadosolicitud;
        private string CodigoestadosolicitudDesc;
        private string Mensajesolicitud;
		private string Mensajeverificacion;
		private string Rutaarchivo;
		private string Computadora;
        private bool Pendientes;
		
		
		//Constructor
		public CfdiDescargaMasiva()
		{
			Id = 0; 
			Rfcsolicitante = ""; 
			Rfcemisor = ""; 
			Rfcreceptor = ""; 
			Fechainicial = System.DateTime.Today;
			Fechafinal = System.DateTime.Today;
			Fechasolicitud = System.DateTime.Today;
            Fechaverificacion = System.DateTime.Parse("01/01/2000");
            Fechadescarga = System.DateTime.Parse("01/01/2000");
            Idsolicitud = ""; 
			Iddescarga = ""; 
			Idpaquete = ""; 
			Estadosolicitud = 0;
            EstadosolicitudDesc = "";
            Codigoestadosolicitud = 0;
            CodigoestadosolicitudDesc = "";
            Mensajesolicitud = ""; 
			Mensajeverificacion = ""; 
			Rutaarchivo = ""; 
			Computadora = "";
            Pendientes = true;

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
		[DataMember(IsRequired = true)]
		public string RFCSOLICITANTE
		{
			get{ return Rfcsolicitante.ToString().Trim(); }
			set
			{
				if(value!=Rfcsolicitante)
				{
					Rfcsolicitante = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string RFCEMISOR
		{
			get{ return Rfcemisor.ToString().Trim(); }
			set
			{
				if(value!=Rfcemisor)
				{
					Rfcemisor = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string RFCRECEPTOR
		{
			get{ return Rfcreceptor.ToString().Trim(); }
			set
			{
				if(value!=Rfcreceptor)
				{
					Rfcreceptor = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public DateTime FECHAINICIAL
		{
			get{ return Fechainicial; }
			set
			{
				if (value != null)
				{
					if(value!=Fechainicial)
					{
						Fechainicial = value;
					}
				}
			}
		}
		[DataMember(IsRequired = true)]
		public DateTime FECHAFINAL
		{
			get{ return Fechafinal; }
			set
			{
				if (value != null)
				{
					if(value!=Fechafinal)
					{
						Fechafinal = value;
					}
				}
			}
		}
		public DateTime FECHASOLICITUD
		{
			get{ return Fechasolicitud; }
			set
			{
				if (value != null)
				{
					if(value!=Fechasolicitud)
					{
						Fechasolicitud = value;
					}
				}
			}
		}
		public DateTime FECHAVERIFICACION
		{
			get{ return Fechaverificacion; }
			set
			{
				if (value != null)
				{
					if(value!=Fechaverificacion)
					{
						Fechaverificacion = value;
					}
				}
			}
		}
		public DateTime FECHADESCARGA
		{
			get{ return Fechadescarga; }
			set
			{
				if (value != null)
				{
					if(value!=Fechadescarga)
					{
						Fechadescarga = value;
					}
				}
			}
		}
		public string IDSOLICITUD
		{
			get{ return Idsolicitud.ToString().Trim(); }
			set
			{
				if(value!=Idsolicitud)
				{
					Idsolicitud = value;
				}
			}
		}
		public string IDDESCARGA
		{
			get{ return Iddescarga.ToString().Trim(); }
			set
			{
				if(value!=Iddescarga)
				{
					Iddescarga = value;
				}
			}
		}
		public string IDPAQUETE
		{
			get{ return Idpaquete.ToString().Trim(); }
			set
			{
				if(value!=Idpaquete)
				{
					Idpaquete = value;
				}
			}
		}
		public Int32 ESTADOSOLICITUD
		{
			get{ return Estadosolicitud; }
			set
			{
				if(value!=Estadosolicitud)
				{
					Estadosolicitud = value;
				}
			}
		}
        public string ESTADOSOLICITUDDESC
        {
            get { return EstadosolicitudDesc.ToString().Trim(); }
            set
            {
                if (value != EstadosolicitudDesc)
                {
                    EstadosolicitudDesc = value;
                }
            }
        }
        public Int16 CODIGOESTADOSOLICITUD
		{
			get{ return Codigoestadosolicitud; }
			set
			{
				if(value!=Codigoestadosolicitud)
				{
					Codigoestadosolicitud = value;
				}
			}
		}
        public string CODIGOESTADOSOLICITUDDESC
        {
            get { return CodigoestadosolicitudDesc.ToString().Trim(); }
            set
            {
                if (value != CodigoestadosolicitudDesc)
                {
                    CodigoestadosolicitudDesc = value;
                }
            }
        }
        public string MENSAJESOLICITUD
		{
			get{ return Mensajesolicitud.ToString().Trim(); }
			set
			{
				if(value!=Mensajesolicitud)
				{
					Mensajesolicitud = value;
				}
			}
		}
		public string MENSAJEVERIFICACION
		{
			get{ return Mensajeverificacion.ToString().Trim(); }
			set
			{
				if(value!=Mensajeverificacion)
				{
					Mensajeverificacion = value;
				}
			}
		}
		public string RUTAARCHIVO
		{
			get{ return Rutaarchivo.ToString().Trim(); }
			set
			{
				if(value!=Rutaarchivo)
				{
					Rutaarchivo = value;
				}
			}
		}
		public string COMPUTADORA
		{
			get{ return Computadora.ToString().Trim(); }
			set
			{
				if(value!=Computadora)
				{
					Computadora = value;
				}
			}
		}
        public bool PENDIENTES
        {
            get { return Pendientes; }
            set
            {
                if (value != Pendientes)
                    Pendientes = value;
            }
        }

    }
}
