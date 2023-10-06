using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class Sucursal: IEntidadBase
	{
		private Int16 Id;
		private Int16 Idempresa;
		private Int32 Idcliprov;
		private string Nombresucursal;
		private string Serie;
        private string SerieSat;
        private byte[] Logo;

        //Constructor
        public Sucursal()
		{
			Id = 0; 
			Idempresa = 0; 
			Idcliprov = 0; 
			Nombresucursal = ""; 
			Serie = "";
            SerieSat = "";
            Logo = Array.Empty<byte>();

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
		public Int16 IDEMPRESA
		{
			get{ return Idempresa; }
			set
			{
				if(value!=Idempresa)
				{
					
					Idempresa = value;
				}
			}
		}
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
		public string NOMBRESUCURSAL
		{
			get{ return Nombresucursal.ToString().Trim(); }
			set
			{
				if(value!=Nombresucursal)
				{
					
					Nombresucursal = value;
				}
			}
		}
		public string SERIE
		{
			get{ return Serie.ToString().Trim(); }
			set
			{
				if(value!=Serie)
				{
					
					Serie = value;
				}
			}
		}
        public string SERIESAT
        {
            get { return SerieSat.ToString().Trim(); }
            set
            {
                if (value != SerieSat)
                {

                    SerieSat = value;
                }
            }
        }

        public byte[] LOGO
        {
            get { return Logo; }
            set
            {
                if (value != Logo)
                {
                    Logo = value;
                }
            }
        }
    }
}
