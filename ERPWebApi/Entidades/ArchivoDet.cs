using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class ArchivoDet: IEntidadBase
	{
		private Int32 Id;
		private Int16 Idtipoarchivo;
		private Int16 Idfuncionalidad;
		private Int64 Idref;
		private Int32 Idarchivo;
		private Int16 Idstatus;
        private string Nombrearchivo;
        private string Nombretipoarchivo;
        private string Nombrestatus;
        private DateTime Modificacion;
		
		
		//Constructor
		public ArchivoDet()
		{
			Id = 0; 
			Idtipoarchivo = 0; 
			Idfuncionalidad = 0; 
			Idref = 0; 
			Idarchivo = 0; 
			Idstatus = 0; 
			Modificacion = System.DateTime.Today;
            Nombrearchivo = "";
            Nombretipoarchivo = "";
            Nombrestatus = "";
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
		public Int16 IDTIPOARCHIVO
		{
			get{ return Idtipoarchivo; }
			set
			{
				if(value!=Idtipoarchivo)
				{
					Idtipoarchivo = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int16 IDFUNCIONALIDAD
		{
			get{ return Idfuncionalidad; }
			set
			{
				if(value!=Idfuncionalidad)
				{
					Idfuncionalidad = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int64 IDREF
		{
			get{ return Idref; }
			set
			{
				if(value!=Idref)
				{
					Idref = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int32 IDARCHIVO
		{
			get{ return Idarchivo; }
			set
			{
				if(value!=Idarchivo)
				{
					Idarchivo = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int16 IDSTATUS
		{
			get{ return Idstatus; }
			set
			{
				if(value!=Idstatus)
				{
					Idstatus = value;
				}
			}
		}
        public string NOMBREARCHIVO
        {
            get { return Nombrearchivo.ToString().Trim(); }
            set
            {
                if (value != Nombrearchivo)
                {
                    Nombrearchivo = value;
                }
            }
        }
        public string NOMBRETIPOARCHIVO
        {
            get { return Nombretipoarchivo.ToString().Trim(); }
            set
            {
                if (value != Nombretipoarchivo)
                {
                    Nombretipoarchivo = value;
                }
            }
        }
        public string NOMBRESTATUS
        {
            get { return Nombrestatus.ToString().Trim(); }
            set
            {
                if (value != Nombrestatus)
                {
                    Nombrestatus = value;
                }
            }
        }
        public DateTime MODIFICACION
		{
			get{ return Modificacion; }
			set
			{
				if (value != null)
				{
					if(value!=Modificacion)
					{
						Modificacion = value;
					}
				}
			}
		}
	}
}
