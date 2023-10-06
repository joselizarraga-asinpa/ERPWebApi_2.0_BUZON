using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class RepPerdidasGanancias: IEntidadBase
	{

		private DateTime Desde;
		private DateTime Hasta;
        private Int16 IdPinCliente;
        private Int16 IdEmpresa;
        private string Empresa;
		private Int16 Anio;
		private Int16 Numeromes;
		private string Mes;
		private string Ingreso;
		private Int16 Numgrupo;
		private string Grupo;
		private string Concepto;
		private decimal Importe;
		
		
		//Constructor
		public RepPerdidasGanancias()
		{
			Desde = System.DateTime.Today;
			Hasta = System.DateTime.Today;
            IdPinCliente = 0;
            IdEmpresa = 0;
            Empresa = ""; 
			Anio = 0; 
			Numeromes = 0; 
			Mes = ""; 
			Ingreso = ""; 
			Numgrupo = 0; 
			Grupo = ""; 
			Concepto = ""; 
			Importe = 0; 
			
		}

        public Int16 IDPINCLIENTE
        {
            get { return IdPinCliente; }
            set
            {
                if (value != IdPinCliente)
                {
                    IdPinCliente = value;
                }
            }
        }

        public DateTime DESDE
		{
			get{ return Desde; }
			set
			{
				if (value != null)
				{
					if(value!=Desde)
					{
						Desde = value;
					}
				}
			}
		}
		public DateTime HASTA
		{
			get{ return Hasta; }
			set
			{
				if (value != null)
				{
					if(value!=Hasta)
					{
						Hasta = value;
					}
				}
			}
		}
        public Int16 IDEMPRESA
        {
            get { return IdEmpresa; }
            set
            {
                if (value != IdEmpresa)
                {
                    IdEmpresa = value;
                }
            }
        }
        public string EMPRESA
		{
			get{ return Empresa.ToString().Trim(); }
			set
			{
				if(value!=Empresa)
				{
					Empresa = value;
				}
			}
		}
		public Int16 ANIO
		{
			get{ return Anio; }
			set
			{
				if(value!=Anio)
				{
					Anio = value;
				}
			}
		}
		public Int16 NUMEROMES
		{
			get{ return Numeromes; }
			set
			{
				if(value!=Numeromes)
				{
					Numeromes = value;
				}
			}
		}
		public string MES
		{
			get{ return Mes.ToString().Trim(); }
			set
			{
				if(value!=Mes)
				{
					Mes = value;
				}
			}
		}
		public string INGRESO
		{
			get{ return Ingreso.ToString().Trim(); }
			set
			{
				if(value!=Ingreso)
				{
					Ingreso = value;
				}
			}
		}
		public Int16 NUMGRUPO
		{
			get{ return Numgrupo; }
			set
			{
				if(value!=Numgrupo)
				{
					Numgrupo = value;
				}
			}
		}
		public string GRUPO
		{
			get{ return Grupo.ToString().Trim(); }
			set
			{
				if(value!=Grupo)
				{
					Grupo = value;
				}
			}
		}
		public string CONCEPTO
		{
			get{ return Concepto.ToString().Trim(); }
			set
			{
				if(value!=Concepto)
				{
					Concepto = value;
				}
			}
		}
		public decimal IMPORTE
		{
			get{ return Importe; }
			set
			{
				if(value!=Importe)
				{
					Importe = value;
				}
			}
		}
	}
}
