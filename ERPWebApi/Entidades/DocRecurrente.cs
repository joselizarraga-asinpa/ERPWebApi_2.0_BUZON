using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class DocRecurrente: IEntidadBase
	{
		private Int32 Id;
		private Int16 Idsucursal;
		private Int32 Idcliprov;
		private Int16 Idtipodocumento;
		private Int64 Iddocfuente;
		private string Nombredocrecurrente;
		private string Periodicidad;
        private Int16 InicioEjecucion;
		private bool Activo;
		private DateTime Desde;
		private DateTime Hasta;
		private DateTime Ultimaejecución;
		
		
		//Constructor
		public DocRecurrente()
		{
			Id = 0; 
			Idsucursal = 0; 
			Idcliprov = 0; 
			Idtipodocumento = 0; 
			Iddocfuente = 0; 
			Nombredocrecurrente = ""; 
			Periodicidad = "";
            InicioEjecucion = 0;
            Activo = false;
            Desde = DateTime.Parse("01/01/2000");
			Hasta = DateTime.Parse("01/01/2000");
            Ultimaejecución = DateTime.Parse("01/01/2000");

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
		public Int64 IDDOCFUENTE
		{
			get{ return Iddocfuente; }
			set
			{
				if(value!=Iddocfuente)
				{
					Iddocfuente = value;
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
		[DataMember(IsRequired = true)]
		public string PERIODICIDAD
		{
			get{ return Periodicidad.ToString().Trim(); }
			set
			{
				if(value!=Periodicidad)
				{
					Periodicidad = value;
				}
			}
		}
        public Int16 INICIOEJECUCION
        {
            get { return InicioEjecucion; }
            set
            {
                InicioEjecucion = value;
            }
        }
        [DataMember(IsRequired = true)]
		public bool ACTIVO
		{
			get{ return Activo; }
			set
			{
				if(value!=Activo)
				{
					Activo = value;
				}
			}
		}
		public DateTime DESDE
		{
			get{ return Desde; }
			set
			{
				if (value != null)
				{
					if(value!=Desde)
					{
						Desde = value;
					}
				}
			}
		}
		public DateTime HASTA
		{
			get{ return Hasta; }
			set
			{
				if (value != null)
				{
					if(value!=Hasta)
					{
						Hasta = value;
					}
				}
			}
		}
		public DateTime ULTIMAEJECUCIÓN
		{
			get{ return Ultimaejecución; }
			set
			{
				if (value != null)
				{
					if(value!=Ultimaejecución)
					{
						Ultimaejecución = value;
					}
				}
			}
		}
	}
}
