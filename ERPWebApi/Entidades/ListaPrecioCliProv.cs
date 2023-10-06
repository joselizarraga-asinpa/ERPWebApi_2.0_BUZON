using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class ListaPrecioCliProv: IEntidadBase
	{
		private Int16 Idlistaprecio;
		private Int32 Idcliprov;
        private string NombreListaPrecio;
        private string TipoAsignacion;


        //Constructor
        public ListaPrecioCliProv()
		{
			Idlistaprecio = 0; 
			Idcliprov = 0;
            NombreListaPrecio = "";
            TipoAsignacion = "";

        }
		
		[DataMember(IsRequired = true)]
		public Int16 IDLISTAPRECIO
		{
			get{ return Idlistaprecio; }
			set
			{
				if(value!=Idlistaprecio)
				{
					Idlistaprecio = value;
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
        public string NOMBRELISTAPRECIO
        {
            get { return NombreListaPrecio; }
            set
            {
                NombreListaPrecio = value;
            }
        }
        public string TIPOASIGNACION
        {
            get { return TipoAsignacion; }
            set
            {
                TipoAsignacion = value;
            }
        }
    }
}
