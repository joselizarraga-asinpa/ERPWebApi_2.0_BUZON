using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class RepResumenAlmacenInventarios : IEntidadBase
	{
		private DateTime Desdefecha;
		private DateTime Hastafecha;
        private Int16 Idempresa;
        private Int16 Idsucursal;
        private Int16 Idalmacen;        
		private string Nombrealmacen;
        private string Nombretipodoc;
		private decimal Cantidad;
        private decimal ImporteCosto;
        private decimal Importe;

        //Constructor
        public RepResumenAlmacenInventarios()
		{
			Desdefecha = System.DateTime.Today;
			Hastafecha = System.DateTime.Today;
            Idempresa = 0;
            Idsucursal = 0;
			Idalmacen = 0;            
			Nombrealmacen = ""; 
            Nombretipodoc = ""; 
			Cantidad = 0;
            ImporteCosto = 0;
            Importe = 0;

    }
		
		public DateTime DESDEFECHA
		{
			get{ return Desdefecha; }
			set
			{
				if (value != null)
				{
					if(value!=Desdefecha)
					{
						
						Desdefecha = value;
					}
				}
			}
		}
		public DateTime HASTAFECHA
		{
			get{ return Hastafecha; }
			set
			{
				if (value != null)
				{
					if(value!=Hastafecha)
					{
						
						Hastafecha = value;
					}
				}
			}
		}
        public Int16 IDEMPRESA
        {
            get { return Idempresa; }
            set
            {
                if (value != Idempresa)
                {

                    Idempresa = value;
                }
            }
        }
        public Int16 IDSUCURSAL
        {
            get { return Idsucursal; }
            set
            {
                if (value != Idsucursal)
                {

                    Idsucursal = value;
                }
            }
        }
        public Int16 IDALMACEN
		{
			get{ return Idalmacen; }
			set
			{
				if(value!=Idalmacen)
				{
					
					Idalmacen = value;
				}
			}
		}

		public string NOMBREALMACEN
		{
			get{ return Nombrealmacen.ToString().Trim(); }
			set
			{
				if(value!=Nombrealmacen)
				{
					
					Nombrealmacen = value;
				}
			}
		}
		
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
		
		public decimal CANTIDAD
		{
			get{ return Cantidad; }
			set
			{
				if(value!=Cantidad)
				{
					
					Cantidad = value;
				}
			}
		}
        public decimal IMPORTECOSTO
        {
            get { return ImporteCosto; }
            set
            {
                if (value != ImporteCosto)
                {
                    
                    ImporteCosto = value;
                }
            }
        }
        
        public decimal IMPORTE
        {
            get { return Importe; }
            set
            {
                if (value != Importe)
                {

                    Importe = value;
                }
            }
        }
        
    }
}
