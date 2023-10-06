using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class RepEtiquetas: IEntidadBase
	{
		private Int64 Iddocumento;
		private string Direccion;
        private string Dirigido;
        private string Registro;
        private decimal Cantidad;
		
		
		//Constructor
		public RepEtiquetas()
		{
			Iddocumento = 0; 
			Direccion = "";
            Dirigido = "";
            Registro = "";
            Cantidad = 0;
        }
		
		public Int64 IDDOCUMENTO
		{
			get{ return Iddocumento; }
			set
			{
				if(value!=Iddocumento)
				{
					Iddocumento = value;
				}
			}
		}
		public string DIRECCION
		{
			get{ return Direccion.ToString(); }
			set
			{
				if(value!=Direccion)
				{
					Direccion = value;
				}
			}
		}
        public string DIRIGIDO
        {
            get { return Dirigido.ToString(); }
            set
            {
                if (value != Dirigido)
                {
                    Dirigido = value;
                }
            }
        }
        public string REGISTRO
		{
			get{ return Registro.ToString(); }
			set
			{
				if(value!=Registro)
				{
					Registro = value;
				}
			}
		}
        public decimal CANTIDAD
        {
            get { return Cantidad; }
            set
            {
                if(value != Cantidad)
                {
                    Cantidad = value;
                }
            }
        }

    }
}
