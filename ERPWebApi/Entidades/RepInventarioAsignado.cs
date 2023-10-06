using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class RepInventarioAsignado: IEntidadBase
	{
		private Int16 Idempresa;
		private Int16 Idsucursal;
		private Int16 Idalmacen;
		private Int32 Idproducto;
        private Int32 Idcliprov;
        private string Clasificaciones;
		private string Nombrealmacen;
		private string Nombreproducto;
		private string Codigo;
		private string Cliente;
		private DateTime Fecha;
		private string Vehiculo;
		private string Serie1;
		private string Serie2;
		private string Tituloserie1;
		private string Tituloserie2;
		private string Equipoasignado;
		private string Equipocodigo;
		private string Equiposerie1;
		private string Equipotituloserie1;
		private string Folioasignacion;
        private string Estatus;
        private string Sustitutocodigo;
        private string Sustitutotituloserie1;
        private string Sustitutoserie1;


        //Constructor
        public RepInventarioAsignado()
		{
			Idempresa = 0; 
			Idsucursal = 0; 
			Idalmacen = 0; 
			Idproducto = 0;
            Idcliprov = 0;
            Clasificaciones = ""; 
			Nombrealmacen = ""; 
			Nombreproducto = ""; 
			Codigo = ""; 
			Cliente = ""; 
			Fecha = System.DateTime.Today;
			Vehiculo = ""; 
			Serie1 = ""; 
			Serie2 = ""; 
			Tituloserie1 = ""; 
			Tituloserie2 = ""; 
			Equipoasignado = ""; 
			Equipocodigo = ""; 
			Equiposerie1 = ""; 
			Equipotituloserie1 = ""; 
			Folioasignacion = "";
            Estatus = "";
            Sustitutocodigo = "";
            Sustitutotituloserie1 = "";
            Sustitutoserie1 = "";

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
		public Int32 IDPRODUCTO
		{
			get{ return Idproducto; }
			set
			{
				if(value!=Idproducto)
				{
					Idproducto = value;
				}
			}
		}
        public Int32 IDCLIPROV
        {
            get { return Idcliprov; }
            set
            {
                if (value != Idcliprov)
                {
                    Idcliprov = value;
                }
            }
        }
        public string CLASIFICACIONES
		{
			get{ return Clasificaciones.ToString().Trim(); }
			set
			{
				if(value!=Clasificaciones)
				{
					Clasificaciones = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
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
		[DataMember(IsRequired = true)]
		public string NOMBREPRODUCTO
		{
			get{ return Nombreproducto.ToString().Trim(); }
			set
			{
				if(value!=Nombreproducto)
				{
					Nombreproducto = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public string CODIGO
		{
			get{ return Codigo.ToString().Trim(); }
			set
			{
				if(value!=Codigo)
				{
					Codigo = value;
				}
			}
		}
		public string CLIENTE
		{
			get{ return Cliente.ToString().Trim(); }
			set
			{
				if(value!=Cliente)
				{
					Cliente = value;
				}
			}
		}
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
		public string VEHICULO
		{
			get{ return Vehiculo.ToString().Trim(); }
			set
			{
				if(value!=Vehiculo)
				{
					Vehiculo = value;
				}
			}
		}
		public string SERIE1
		{
			get{ return Serie1.ToString().Trim(); }
			set
			{
				if(value!=Serie1)
				{
					Serie1 = value;
				}
			}
		}
		public string SERIE2
		{
			get{ return Serie2.ToString().Trim(); }
			set
			{
				if(value!=Serie2)
				{
					Serie2 = value;
				}
			}
		}
		public string TITULOSERIE1
		{
			get{ return Tituloserie1.ToString().Trim(); }
			set
			{
				if(value!=Tituloserie1)
				{
					Tituloserie1 = value;
				}
			}
		}
		public string TITULOSERIE2
		{
			get{ return Tituloserie2.ToString().Trim(); }
			set
			{
				if(value!=Tituloserie2)
				{
					Tituloserie2 = value;
				}
			}
		}
		public string EQUIPOASIGNADO
		{
			get{ return Equipoasignado.ToString().Trim(); }
			set
			{
				if(value!=Equipoasignado)
				{
					Equipoasignado = value;
				}
			}
		}
		public string EQUIPOCODIGO
		{
			get{ return Equipocodigo.ToString().Trim(); }
			set
			{
				if(value!=Equipocodigo)
				{
					Equipocodigo = value;
				}
			}
		}
		public string EQUIPOSERIE1
		{
			get{ return Equiposerie1.ToString().Trim(); }
			set
			{
				if(value!=Equiposerie1)
				{
					Equiposerie1 = value;
				}
			}
		}
		public string EQUIPOTITULOSERIE1
		{
			get{ return Equipotituloserie1.ToString().Trim(); }
			set
			{
				if(value!=Equipotituloserie1)
				{
					Equipotituloserie1 = value;
				}
			}
		}
		public string FOLIOASIGNACION
		{
			get{ return Folioasignacion.ToString().Trim(); }
			set
			{
				if(value!=Folioasignacion)
				{
					Folioasignacion = value;
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
        public string SUSTITUTOCODIGO
        {
            get { return Sustitutocodigo.ToString().Trim(); }
            set
            {
                if (value != Sustitutocodigo)
                {
                    Sustitutocodigo = value;
                }
            }
        }
        public string SUSTITUTOTITULOSERIE1
        {
            get { return Sustitutotituloserie1.ToString().Trim(); }
            set
            {
                if (value != Sustitutotituloserie1)
                {
                    Sustitutotituloserie1 = value;
                }
            }
        }
        public string SUSTITUTOSERIE1
        {
            get { return Sustitutoserie1.ToString().Trim(); }
            set
            {
                if (value != Sustitutoserie1)
                {
                    Sustitutoserie1 = value;
                }
            }
        }
    }
}
