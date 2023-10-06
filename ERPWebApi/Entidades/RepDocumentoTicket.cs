using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class RepDocumentoTicket: IEntidadBase
	{
		private Int64 Iddocumento;
		private string Registro;
        private Int16 Alineacion;
		
		
		//Constructor
		public RepDocumentoTicket()
		{
			Iddocumento = 0; 
			Registro = "";
            Alineacion = 0;
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
        public Int16 ALINEACION
        {
            get { return Alineacion; }
            set
            {
                if (value != Alineacion)
                {
                    Alineacion = value;
                }
            }
        }
    }
}
