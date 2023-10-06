using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class DocRecurrenteDoc: IEntidadBase
	{
		private Int32 Iddocrecurrente;
		private Int64 Iddocumento;
        private bool Descargado;
        private bool EnviadoEmail;
		
		//Constructor
		public DocRecurrenteDoc()
		{
			Iddocrecurrente = 0; 
			Iddocumento = 0;
            Descargado = false;
            EnviadoEmail = false;

        }
		
		[DataMember(IsRequired = true)]
		public Int32 IDDOCRECURRENTE
		{
			get{ return Iddocrecurrente; }
			set
			{
				if(value!=Iddocrecurrente)
				{
					Iddocrecurrente = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
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
        public bool DESCARGADO
        {
            get { return Descargado; }
            set
            {
                Descargado = value;
            }
        }
        public bool ENVIADOEMAIL
        {
            get { return EnviadoEmail; }
            set
            {
                EnviadoEmail = value;
            }
        }

    }
}
