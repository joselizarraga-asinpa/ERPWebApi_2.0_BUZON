using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class ListaPrecio: IEntidadBase
	{
		private Int16 Id;
		private Int16 Idempresa;
		private string Nombrelistaprecio;
		private DateTime Desde;
		private DateTime Hasta;
		private bool Activa;
        private bool Cliente;


        //Constructor
        public ListaPrecio()
		{
			Id = 0; 
			Idempresa = 0; 
			Nombrelistaprecio = ""; 
			Desde = System.DateTime.Today;
			Hasta = System.DateTime.Today;
			Activa = false;
            Cliente = true;


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
		[DataMember(IsRequired = true)]
		public string NOMBRELISTAPRECIO
		{
			get{ return Nombrelistaprecio.ToString().Trim(); }
			set
			{
				if(value!=Nombrelistaprecio)
				{
					Nombrelistaprecio = value;
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
		public bool ACTIVA
		{
			get{ return Activa; }
			set
			{
				if(value!=Activa)
				{
					Activa = value;
				}
			}
		}
        public bool CLIENTE
        {
            get { return Cliente; }
            set
            {
                if (value != Cliente)
                {
                    Cliente = value;
                }
            }
        }
    }
}
