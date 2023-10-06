using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class RepSaldoInventarios: IEntidadBase
	{
		private DateTime Fecha;
        private Int16 Idempresa;
        private Int16 Idsucursal;
        private Int16 Idalmacen;
		private Int32 Idproducto;
		private string Clasificaciones;
		private Int32 Id;
		private string Nombrealmacen;
		private string Proveedor;
		private string Nombreproducto;
		private string Nombretipoproducto;
		private float Unidad;
		private string Nombretipounidad;
		private string Codigo;
		private decimal Saldo;
        private decimal ExistenciaActual;
        private decimal ImporteCosto;
        private decimal Importe;


        //Constructor
        public RepSaldoInventarios()
		{
			Fecha = System.DateTime.Today;
            Idempresa = 0;
            Idsucursal = 0;
            Idalmacen = 0; 
			Idproducto = 0; 
			Clasificaciones = ""; 
			Id = 0; 
			Nombrealmacen = ""; 
			Proveedor = ""; 
			Nombreproducto = ""; 
			Nombretipoproducto = ""; 
			Unidad = 0; 
			Nombretipounidad = ""; 
			Codigo = ""; 
			Saldo = 0;
            ExistenciaActual = 0;
            ImporteCosto = 0;
            Importe = 0;
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
		public Int32 ID
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
		public string PROVEEDOR
		{
			get{ return Proveedor.ToString().Trim(); }
			set
			{
				if(value!=Proveedor)
				{
					
					Proveedor = value;
				}
			}
		}
		
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
		
		public string NOMBRETIPOPRODUCTO
		{
			get{ return Nombretipoproducto.ToString().Trim(); }
			set
			{
				if(value!=Nombretipoproducto)
				{
					
					Nombretipoproducto = value;
				}
			}
		}
		
		public float UNIDAD
		{
			get{ return Unidad; }
			set
			{
				if(value!=Unidad)
				{
					
					Unidad = value;
				}
			}
		}
		public string NOMBRETIPOUNIDAD
		{
			get{ return Nombretipounidad.ToString().Trim(); }
			set
			{
				if(value!=Nombretipounidad)
				{
					
					Nombretipounidad = value;
				}
			}
		}
		
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

        public decimal EXISTENCIAACTUAL
        {
            get { return ExistenciaActual; }
            set
            {
                if (value != ExistenciaActual)
                {
                    ExistenciaActual = value;
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
