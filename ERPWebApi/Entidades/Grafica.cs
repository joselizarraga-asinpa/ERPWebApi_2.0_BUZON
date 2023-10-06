using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class Grafica: IEntidadBase
	{
		private Int16 Id;
		private Int16 Idpincliente;
		private Int16 Idtipografica;
		private Int16 Idproceso;
        private Int16 IdGrupoGrafica;
        private long Idprocesomatriz;
		private string Nombregrafica;        
        private string Folio;
		private bool Porcentajes;
		private Int16 Orden;
        private string Nombretipografica;
        private decimal Alto;
        private decimal Ancho;


        //Constructor
        public Grafica()
		{
			Id = 0; 
			Idpincliente = 0; 
			Idtipografica = 0;
            IdGrupoGrafica = 0;
            Idproceso = 0; 
			Idprocesomatriz = 0; 
			Nombregrafica = ""; 
			Folio = ""; 
			Porcentajes = false; 
			Orden = 0;
            Nombretipografica = "";
            Alto = 0;
            Ancho = 0;


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
		public Int16 IDPINCLIENTE
		{
			get{ return Idpincliente; }
			set
			{
				if(value!=Idpincliente)
				{
					
					Idpincliente = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int16 IDTIPOGRAFICA
		{
			get{ return Idtipografica; }
			set
			{
				if(value!=Idtipografica)
				{
					
					Idtipografica = value;
				}
			}
		}

        public Int16 IDGRUPOGRAFICA
        {
            get { return IdGrupoGrafica; }
            set
            {
                if (value != IdGrupoGrafica)
                {

                    IdGrupoGrafica = value;
                }
            }
        }
        public Int16 IDPROCESO
		{
			get{ return Idproceso; }
			set
			{
				if(value!=Idproceso)
				{
					
					Idproceso = value;
				}
			}
		}
		public long IDPROCESOMATRIZ
		{
			get{ return Idprocesomatriz; }
			set
			{
				if(value!=Idprocesomatriz)
				{
					
					Idprocesomatriz = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string NOMBREGRAFICA
		{
			get{ return Nombregrafica.ToString().Trim(); }
			set
			{
				if(value!=Nombregrafica)
				{
					
					Nombregrafica = value;
				}
			}
		}
		public string FOLIO
		{
			get{ return Folio.ToString().Trim(); }
			set
			{
				if(value!=Folio)
				{
					
					Folio = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public bool PORCENTAJES
		{
			get{ return Porcentajes; }
			set
			{
				if(value!=Porcentajes)
				{
					
					Porcentajes = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public Int16 ORDEN
		{
			get{ return Orden; }
			set
			{
				if(value!=Orden)
				{
					
					Orden = value;
				}
			}
		}
        public string NOMBRETIPOGRAFICA
        {
            get { return Nombretipografica.ToString().Trim(); }
            set
            {
                if (value != Nombretipografica)
                {
                    
                    Nombretipografica = value;
                }
            }
        }
        public decimal ALTO
        {
            get { return Alto; }
            set
            {
                if(value!=Alto)
                {
                    
                    Alto = value;
                }
            }
        }
        public decimal ANCHO
        {
            get { return Ancho; }
            set
            {
                if (value != Ancho)
                {
                    
                    Ancho = value;
                }
            }
        }
    }
}
