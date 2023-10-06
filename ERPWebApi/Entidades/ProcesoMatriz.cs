using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class ProcesoMatriz: IEntidadBase
	{
		private Int16 Id;
		private Int16 Idproceso;
		private Int16 Idpincliente;
		private string Etapa;
		private decimal Porcentaje;
		private decimal Orden;
		private string Valor;
		private decimal Avance;
		private string Folio;
        private decimal Realizado;
        private decimal PorRealizar;
		
		
		//Constructor
		public ProcesoMatriz()
		{
			Id = 0; 
			Idproceso = 0; 
			Idpincliente = 0; 
			Etapa = ""; 
			Porcentaje = 0; 
			Orden = 0; 
			Valor = ""; 
			Avance = 0; 
			Folio = "";
            Realizado = 0;
            PorRealizar = 0;


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
		public string ETAPA
		{
			get{ return Etapa.ToString().Trim(); }
			set
			{
				if(value!=Etapa)
				{
					
					Etapa = value;
				}
			}
		}
		public decimal PORCENTAJE
		{
			get{ return Porcentaje; }
			set
			{
				if(value!=Porcentaje)
				{
					
					Porcentaje = value;
				}
			}
		}
		public decimal ORDEN
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
		public string VALOR
		{
			get{ return Valor.ToString().Trim(); }
			set
			{
				if(value!=Valor)
				{
					
					Valor = value;
				}
			}
		}
		public decimal AVANCE
		{
			get{ return Avance; }
			set
			{
				if(value!=Avance)
				{
					
					Avance = value;
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
        public decimal REALIZADO
        {
            get { return Realizado; }
            set
            {
                if(value!= Realizado)
                {
                    
                    Realizado = value;
                }
            }
        }
        public decimal PORREALIZAR
        {
            get { return PorRealizar; }
            set
            {
                if (value != PorRealizar)
                {
                    
                    PorRealizar = value;
                }
            }
        }
    }
}
