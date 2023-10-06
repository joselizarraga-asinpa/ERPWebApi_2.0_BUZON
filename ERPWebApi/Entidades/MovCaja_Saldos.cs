using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class MovCaja_Saldos: IEntidadBase
	{
		private Int64 Id;
        private Int32 IdCliProv;
        private Int16 IdMetodoPagoPreponderante;
        private string Folio;
        private string Origen;
        private string NoDocumento;
        private string Nombretipodoc;
		private DateTime Fecha;
		private decimal Total;
		private decimal Saldo;		
		
		//Constructor
		public MovCaja_Saldos()
		{
			Id = 0;
            IdCliProv = 0;
            IdMetodoPagoPreponderante = 0;
            Folio = "";
            Origen = "";
            NoDocumento = "";
            Nombretipodoc = ""; 
			Fecha = System.DateTime.Today;
			Total = 0; 
			Saldo = 0; 
			
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
        public Int32 IDCLIPROV
        {
            get { return IdCliProv; }
            set
            {
                if (value != IdCliProv)
                {

                    IdCliProv = value;
                }
            }
        }
        public Int16 IDMETODOPAGOPREPONDERANTE
        {
            get { return IdMetodoPagoPreponderante; }
            set
            {
                if (value != IdMetodoPagoPreponderante)
                {

                    IdMetodoPagoPreponderante = value;
                }
            }
        }
        [DataMember(IsRequired = true)]
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
        public string ORIGEN
        {
            get { return Origen.ToString().Trim(); }
            set
            {
                if (value != Origen)
                {
                    
                    Origen = value;
                }
            }
        }
        public string NODOCUMENTO
        {
            get { return NoDocumento.ToString().Trim(); }
            set
            {
                if (value != NoDocumento)
                {
                    
                    NoDocumento = value;
                }
            }
        }
        [DataMember(IsRequired = true)]
		public string NOMBRETIPODOC
		{
			get{ return Nombretipodoc.ToString().Trim(); }
			set
			{
				if(value!=Nombretipodoc)
				{
					
					Nombretipodoc = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public DateTime FECHA
		{
			get{ return Fecha; }
			set
			{
				if (value != null)
				{
					if(value!=Fecha)
					{
						
						Fecha = value;
					}
				}
			}
		}
		public decimal TOTAL
		{
			get{ return Total; }
			set
			{
				if(value!=Total)
				{
					
					Total = value;
				}
			}
		}
		public decimal SALDO
		{
			get{ return Saldo; }
			set
			{
				if(value!=Saldo)
				{
					
					Saldo = value;
				}
			}
		}
	}
}
