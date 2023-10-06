using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class ImagenDet: IEntidadBase
	{
		private Int32 Id;
		private Int16 Idtipoimagen;
		private Int16 Idfuncionalidad;
		private Int64 Idref;
		private Int32 Idimagen;
		private Int16 Idstatus;
        private string Nombreimagen;
        private string Nombretipoimagen;
        private string Nombrestatus;
        private DateTime Modificacion;
        private Int16 Orden;
        private byte[] Contenidoimagen;

        //Constructor
        public ImagenDet()
		{
			Id = 0; 
			Idtipoimagen = 0; 
			Idfuncionalidad = 0; 
			Idref = 0; 
			Idimagen = 0; 
			Idstatus = 0; 
			Modificacion = System.DateTime.Today;
            Nombreimagen = "";
            Nombretipoimagen = "";
            Nombrestatus = "";
            Orden = 1;
            Contenidoimagen = Array.Empty<byte>();
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
		public Int16 IDTIPOIMAGEN
		{
			get{ return Idtipoimagen; }
			set
			{
				if(value!=Idtipoimagen)
				{
					Idtipoimagen = value;
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
		public Int32 IDIMAGEN
		{
			get{ return Idimagen; }
			set
			{
				if(value!=Idimagen)
				{
					Idimagen = value;
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
        public string NOMBREIMAGEN
        {
            get { return Nombreimagen.ToString().Trim(); }
            set
            {
                if (value != Nombreimagen)
                {
                    Nombreimagen = value;
                }
            }
        }
        public string NOMBRETIPOIMAGEN
        {
            get { return Nombretipoimagen.ToString().Trim(); }
            set
            {
                if (value != Nombretipoimagen)
                {
                    Nombretipoimagen = value;
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
        public Int16 ORDEN
        {
            get { return Orden; }
            set
            {
                if (value != Orden)
                {
                    Orden = value;
                }
            }
        }
        public byte[] CONTENIDOIMAGEN
        {
            get { return Contenidoimagen; }
            set
            {
                if (value != Contenidoimagen)
                {
                    Contenidoimagen = value;
                }
            }
        }
    }
}
