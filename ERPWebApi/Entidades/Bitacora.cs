using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class Bitacora: IEntidadBase
	{
		private Int64 Id;
		private Int16 Idbitacoraaccion;
		private Int16 Idfuncionalidad;
		private Int16 Idaplicacion;
		private Int16 Idusuario;
		private Int64 Idreferencia;
		private DateTime Fecha;
        private DateTime FechaSimple;
        private string Actividad;
        private string Nombreusuario;
		
		
		//Constructor
		public Bitacora()
		{
			Id = 0; 
			Idbitacoraaccion = 0; 
			Idfuncionalidad = 0; 
			Idaplicacion = 0; 
			Idusuario = 0; 
			Idreferencia = 0; 
			Fecha = System.DateTime.Today;
            FechaSimple = System.DateTime.Today;
            Actividad = "";
            Nombreusuario = "";

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
		public Int16 IDBITACORAACCION
		{
			get{ return Idbitacoraaccion; }
			set
			{
				if(value!=Idbitacoraaccion)
				{
					Idbitacoraaccion = value;
				}
			}
		}
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
		public Int16 IDAPLICACION
		{
			get{ return Idaplicacion; }
			set
			{
				if(value!=Idaplicacion)
				{
					Idaplicacion = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int16 IDUSUARIO
		{
			get{ return Idusuario; }
			set
			{
				if(value!=Idusuario)
				{
					Idusuario = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int64 IDREFERENCIA
		{
			get{ return Idreferencia; }
			set
			{
				if(value!=Idreferencia)
				{
					Idreferencia = value;
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
        public DateTime FECHASIMPLE
        {
            get { return FechaSimple; }
            set
            {
                if (value != null)
                {
                    if (value != FechaSimple)
                    {
                        FechaSimple = value;
                    }
                }
            }
        }
        public string ACTIVIDAD
		{
			get{ return Actividad.ToString().Trim(); }
			set
			{
				if(value!=Actividad)
				{
					Actividad = value;
				}
			}
		}
        public string NOMBREUSUARIO
        {
            get { return Nombreusuario.ToString().Trim(); }
            set
            {
                if (value != Nombreusuario)
                {
                    Nombreusuario = value;
                }
            }
        }
    }
}
