using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class Telefono: IEntidadBase
	{
		private Int64 Id;
		private Int64 Iddatosgenerales;
		private Int64 Iddomicilio;
		private string Tipotelefono;
		private string Numerotelefono;
        private bool Fiscal;
        private bool Entrega;


        //Constructor
        public Telefono()
		{
			Id = 0; 
			Iddatosgenerales = 0; 
			Iddomicilio = 0; 
			Tipotelefono = ""; 
			Numerotelefono = "";
            Fiscal = false;
            Entrega = false;

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
		public Int64 IDDATOSGENERALES
		{
			get{ return Iddatosgenerales; }
			set
			{
				if(value!=Iddatosgenerales)
				{
					
					Iddatosgenerales = value;
				}
			}
		}
		public Int64 IDDOMICILIO
		{
			get{ return Iddomicilio; }
			set
			{
				if(value!=Iddomicilio)
				{
					
					Iddomicilio = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string TIPOTELEFONO
		{
			get{ return Tipotelefono.ToString().Trim(); }
			set
			{
				if(value!=Tipotelefono)
				{
					
					Tipotelefono = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string NUMEROTELEFONO
		{
			get{ return Numerotelefono.ToString().Trim(); }
			set
			{
				if(value!=Numerotelefono)
				{
					
					Numerotelefono = value;
				}
			}
		}
        public bool FISCAL
        {
            get { return Fiscal; }
            set
            {
                if (value != Fiscal)
                {
                    Fiscal = value;
                }
            }
        }
        public bool ENTREGA
        {
            get { return Entrega; }
            set
            {
                if (value != Entrega)
                {
                    Entrega = value;
                }
            }
        }
    }
}
