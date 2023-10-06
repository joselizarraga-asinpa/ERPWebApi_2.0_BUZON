using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class TipoAplicacionCampo: IEntidadBase
	{
		private Int16 Id;
		private Int16 Idtipoaplicacion;
		private Int16 Idtipodato;
		private Int16 Idfuncionalidadrel;
		private Int16 Idtipoaplicacionrel;
		private Int32 Idformula;
		private string Nombretipoaplicacioncampo;
		private string Nombrecontrol;
        private string Descripcion;
        private bool Obligatorio;
		private bool Multiplesdetalles;
		private Int16 Ordencaptura;
		private Int16 Ordengrid;
		
		
		//Constructor
		public TipoAplicacionCampo()
		{
			Id = 0; 
			Idtipoaplicacion = 0; 
			Idtipodato = 0; 
			Idfuncionalidadrel = 0; 
			Idtipoaplicacionrel = 0; 
			Idformula = 0; 
			Nombretipoaplicacioncampo = ""; 
			Nombrecontrol = "";
            Descripcion = "";
            Obligatorio = false; 
			Multiplesdetalles = false; 
			Ordencaptura = 0; 
			Ordengrid = 0; 
			
		}
		
		public Int16 ID
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
		public Int16 IDTIPOAPLICACION
		{
			get{ return Idtipoaplicacion; }
			set
			{
				if(value!=Idtipoaplicacion)
				{
					Idtipoaplicacion = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int16 IDTIPODATO
		{
			get{ return Idtipodato; }
			set
			{
				if(value!=Idtipodato)
				{
					Idtipodato = value;
				}
			}
		}
		public Int16 IDFUNCIONALIDADREL
		{
			get{ return Idfuncionalidadrel; }
			set
			{
				if(value!=Idfuncionalidadrel)
				{
					Idfuncionalidadrel = value;
				}
			}
		}
		public Int16 IDTIPOAPLICACIONREL
		{
			get{ return Idtipoaplicacionrel; }
			set
			{
				if(value!=Idtipoaplicacionrel)
				{
					Idtipoaplicacionrel = value;
				}
			}
		}
		public Int32 IDFORMULA
		{
			get{ return Idformula; }
			set
			{
				if(value!=Idformula)
				{
					Idformula = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string NOMBRETIPOAPLICACIONCAMPO
		{
			get{ return Nombretipoaplicacioncampo.ToString().Trim(); }
			set
			{
				if(value!=Nombretipoaplicacioncampo)
				{
					Nombretipoaplicacioncampo = value;
				}
			}
		}
		public string NOMBRECONTROL
		{
			get{ return Nombrecontrol.ToString().Trim(); }
			set
			{
				if(value!=Nombrecontrol)
				{
					Nombrecontrol = value;
				}
			}
		}

        public string DESCRIPCION
        {
            get { return Descripcion.ToString().Trim(); }
            set
            {
                if (value != Descripcion)
                {
                    Descripcion = value;
                }
            }
        }

        [DataMember(IsRequired = true)]
		public bool OBLIGATORIO
		{
			get{ return Obligatorio; }
			set
			{
				if(value!=Obligatorio)
				{
					Obligatorio = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public bool MULTIPLESDETALLES
		{
			get{ return Multiplesdetalles; }
			set
			{
				if(value!=Multiplesdetalles)
				{
					Multiplesdetalles = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int16 ORDENCAPTURA
		{
			get{ return Ordencaptura; }
			set
			{
				if(value!=Ordencaptura)
				{
					Ordencaptura = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int16 ORDENGRID
		{
			get{ return Ordengrid; }
			set
			{
				if(value!=Ordengrid)
				{
					Ordengrid = value;
				}
			}
		}
	}
}
