using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class BusquedaGeneral: IEntidadBase
	{
		private Int16 Id;
        private Int16 Idpincliente;
        private Int16 Idempresa;
		private Int16 Idsucursal;
		private string Funcionalidad;
		private Int64 Identidad;
		private string Busqueda;
        private string Tipo;
        private string Cliprov;
        private DateTime Fecha;
        private decimal Total;
        private string Moneda;       		
		private string Observaciones;
        private string Estatus;
        private DateTime Desde;
        private DateTime Hasta;
        private Int16 Pagina;
        private string Paginas;
		private Int16 Totalpaginas;
        private int Totalreg;
        private string Orden;
        private string Asc;

        //Constructor
        public BusquedaGeneral()
		{
			Id = 0;
            Idpincliente = 0;
            Idempresa = 0; 
			Idsucursal = 0; 
			Funcionalidad = ""; 
			Identidad = 0; 
			Busqueda = ""; 
			Tipo = ""; 
			Cliprov = ""; 
			Estatus = ""; 
			Observaciones = "";
            Total = 0;
            Moneda = "";
            Fecha = System.DateTime.Today;
            Desde = System.DateTime.Today;
            Hasta = System.DateTime.Today;
            Paginas = ""; 
			Totalpaginas = 0;
            Totalreg = 0;
            Orden = "";
            Asc = "";


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
            get { return Idpincliente; }
            set
            {
                if (value != Idpincliente)
                {
                    
                    Idpincliente = value;
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
		public Int16 IDSUCURSAL
		{
			get{ return Idsucursal; }
			set
			{
				if(value!=Idsucursal)
				{
					
					Idsucursal = value;
				}
			}
		}
		public string FUNCIONALIDAD
		{
			get{ return Funcionalidad.ToString().Trim(); }
			set
			{
				if(value!=Funcionalidad)
				{
					
					Funcionalidad = value;
				}
			}
		}
		public Int64 IDENTIDAD
		{
			get{ return Identidad; }
			set
			{
				if(value!=Identidad)
				{
					
					Identidad = value;
				}
			}
		}
		public string BUSQUEDA
		{
			get{ return Busqueda.ToString().Trim(); }
			set
			{
				if(value!=Busqueda)
				{
					
					Busqueda = value;
				}
			}
		}
        public string TIPO
        {
            get { return Tipo.ToString().Trim(); }
            set
            {
                if (value != Tipo)
                {

                    Tipo = value;
                }
            }
        }
        public string CLIPROV
        {
            get { return Cliprov.ToString().Trim(); }
            set
            {
                if (value != Cliprov)
                {

                    Cliprov = value;
                }
            }
        }
        public DateTime FECHA
        {
            get { return Fecha; }
            set
            {
                if (value != null)
                {
                    if (value != Fecha)
                    {

                        Fecha = value;
                    }
                }
            }
        }
        [DataMember(IsRequired = true)]
        public decimal TOTAL
        {
            get { return Total; }
            set
            {
                if (value != Total)
                    Total = value;
            }
        }
        [DataMember(IsRequired = true)]
        public string MONEDA
        {
            get { return Moneda; }
            set
            {
                if (value != Moneda)
                    Moneda = value;
            }
        }
        
		public string OBSERVACIONES
		{
			get{ return Observaciones.ToString().Trim(); }
			set
			{
				if(value!=Observaciones)
				{
					
					Observaciones = value;
				}
			}
		}
        public string ESTATUS
        {
            get { return Estatus.ToString().Trim(); }
            set
            {
                if (value != Estatus)
                {

                    Estatus = value;
                }
            }
        }

        [DataMember(IsRequired = true)]
        public DateTime DESDE
        {
            get { return Desde; }
            set
            {
                if (value != null)
                {
                    if (value != Desde)
                    {
                        
                        Desde = value;
                    }
                }
            }
        }
        [DataMember(IsRequired = true)]
        public DateTime HASTA
        {
            get { return Hasta; }
            set
            {
                if (value != null)
                {
                    if (value != Hasta)
                    {
                        
                        Hasta = value;
                    }
                }
            }
        }
        [DataMember(IsRequired = true)]
        public Int16 PAGINA
        {
            get { return Pagina; }
            set
            {
                if (value != Pagina)
                {
                    
                    Pagina = value;
                }
            }
        }
        public string PAGINAS
		{
			get{ return Paginas.ToString().Trim(); }
			set
			{
				if(value!=Paginas)
				{
					
					Paginas = value;
				}
			}
		}
		public Int16 TOTALPAGINAS
		{
			get{ return Totalpaginas; }
			set
			{
				if(value!=Totalpaginas)
				{
					
					Totalpaginas = value;
				}
			}
		}
        public int TOTALREG
        {
            get { return Totalreg; }
            set
            {
                if (value != Totalreg)
                {
                    
                    Totalreg = value;
                }
            }
        }
        public string ORDEN
        {
            get { return Orden.ToString().Trim(); }
            set
            {
                if (value != Orden)
                {
                    Orden = value;
                }
            }
        }
        public string ASC
        {
            get { return Asc.ToString().Trim(); }
            set
            {
                if (value != Asc)
                {
                    Asc = value;
                }
            }
        }
    }
}
