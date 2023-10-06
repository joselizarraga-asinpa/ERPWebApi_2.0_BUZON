using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class RepAprovechamientos: IEntidadBase
	{
        private long IdDocumento;
		private string Folio;
		private string Cotizacion;
		private string Dirigidoa;
		private Int16 Registrosobrante;
		private string Nombreproductopadre;
		private string Nombreproductocomp;
		private decimal Numextra1;
		private decimal Numextra2;
		private decimal Numextra3;
		private string Numextra1alias;
		private string Numextra2alias;
		private string Numextra3alias;
		private decimal Cantidad;
		private decimal Gastoorigen;
		private decimal Totalgastoorigen;
        private decimal Cantidadsobrante;
        private decimal Gastosobrante;
        private decimal Saldocantidad;
        private decimal Saldogasto;
		private Int16 Registroaplicado;
		private decimal Numextra1aplicado;
		private decimal Numextra2aplicado;
		private decimal Numextra3aplicado;
		private string Numextra1aliasapl;
		private string Numextra2aliasapl;
		private string Numextra3aliasapl;
		private decimal Cantidaddestino;
		private decimal Gastodestino;
		private decimal Gastototal;
        private decimal Cantidadaprovechada;
        private decimal Gastoaprovechado;
        private decimal PrecioUnitario;
        private decimal TotalAprovechado;


        //Constructor
        public RepAprovechamientos()
		{
            IdDocumento = 0;
            Folio = ""; 
			Cotizacion = ""; 
			Dirigidoa = ""; 
			Registrosobrante = 0; 
			Nombreproductopadre = ""; 
			Nombreproductocomp = ""; 
			Numextra1 = 0; 
			Numextra2 = 0; 
			Numextra3 = 0; 
			Numextra1alias = ""; 
			Numextra2alias = ""; 
			Numextra3alias = ""; 
			Cantidad = 0; 
			Gastoorigen = 0; 
			Totalgastoorigen = 0;
            Cantidadsobrante = 0;
            Gastosobrante = 0;
            Saldocantidad = 0;
            Saldogasto = 0; 
			Registroaplicado = 0; 
			Numextra1aplicado = 0; 
			Numextra2aplicado = 0; 
			Numextra3aplicado = 0; 
			Numextra1aliasapl = ""; 
			Numextra2aliasapl = ""; 
			Numextra3aliasapl = ""; 
			Cantidaddestino = 0; 
			Gastodestino = 0; 
			Gastototal = 0;
            Cantidadaprovechada = 0;
            Gastoaprovechado = 0;
            PrecioUnitario = 0;
            TotalAprovechado = 0;


        }

        [DataMember(IsRequired = true)]
        public long IDDOCUMENTO
        {
            get { return IdDocumento; }
            set
            {
                if (value != IdDocumento)
                {
                    
                    IdDocumento = value;
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
		public string COTIZACION
		{
			get{ return Cotizacion.ToString().Trim(); }
			set
			{
				if(value!=Cotizacion)
				{
					
					Cotizacion = value;
				}
			}
		}
		public string DIRIGIDOA
		{
			get{ return Dirigidoa.ToString().Trim(); }
			set
			{
				if(value!=Dirigidoa)
				{
					
					Dirigidoa = value;
				}
			}
		}
		public Int16 REGISTROSOBRANTE
		{
			get{ return Registrosobrante; }
			set
			{
				if(value!=Registrosobrante)
				{
					
					Registrosobrante = value;
				}
			}
		}
		public string NOMBREPRODUCTOPADRE
		{
			get{ return Nombreproductopadre.ToString().Trim(); }
			set
			{
				if(value!=Nombreproductopadre)
				{
					
					Nombreproductopadre = value;
				}
			}
		}
		public string NOMBREPRODUCTOCOMP
		{
			get{ return Nombreproductocomp.ToString().Trim(); }
			set
			{
				if(value!=Nombreproductocomp)
				{
					
					Nombreproductocomp = value;
				}
			}
		}
		public decimal NUMEXTRA1
		{
			get{ return Numextra1; }
			set
			{
				if(value!=Numextra1)
				{
					
					Numextra1 = value;
				}
			}
		}
		public decimal NUMEXTRA2
		{
			get{ return Numextra2; }
			set
			{
				if(value!=Numextra2)
				{
					
					Numextra2 = value;
				}
			}
		}
		public decimal NUMEXTRA3
		{
			get{ return Numextra3; }
			set
			{
				if(value!=Numextra3)
				{
					
					Numextra3 = value;
				}
			}
		}
		public string NUMEXTRA1ALIAS
		{
			get{ return Numextra1alias.ToString().Trim(); }
			set
			{
				if(value!=Numextra1alias)
				{
					
					Numextra1alias = value;
				}
			}
		}
		public string NUMEXTRA2ALIAS
		{
			get{ return Numextra2alias.ToString().Trim(); }
			set
			{
				if(value!=Numextra2alias)
				{
					
					Numextra2alias = value;
				}
			}
		}
		public string NUMEXTRA3ALIAS
		{
			get{ return Numextra3alias.ToString().Trim(); }
			set
			{
				if(value!=Numextra3alias)
				{
					
					Numextra3alias = value;
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
		[DataMember(IsRequired = true)]
		public decimal GASTOORIGEN
		{
			get{ return Gastoorigen; }
			set
			{
				if(value!=Gastoorigen)
				{
					
					Gastoorigen = value;
				}
			}
		}
		public decimal TOTALGASTOORIGEN
		{
			get{ return Totalgastoorigen; }
			set
			{
				if(value!=Totalgastoorigen)
				{
					
					Totalgastoorigen = value;
				}
			}
		}
        [DataMember(IsRequired = true)]
        public decimal CANTIDADSOBRANTE
        {
            get { return Cantidadsobrante; }
            set
            {
                if (value != Cantidadsobrante)
                {
                    
                    Cantidadsobrante = value;
                }
            }
        }
        [DataMember(IsRequired = true)]
		public decimal GASTOSOBRANTE
		{
			get{ return Gastosobrante; }
			set
			{
				if(value!=Gastosobrante)
				{
					
					Gastosobrante = value;
				}
			}
		}
        public decimal SALDOCANTIDAD
        {
            get { return Saldocantidad; }
            set
            {
                if (value != Saldocantidad)
                {
                    
                    Saldocantidad = value;
                }
            }
        }
        public decimal SALDOGASTO
		{
			get{ return Saldogasto; }
			set
			{
				if(value!=Saldogasto)
				{
					
					Saldogasto = value;
				}
			}
		}
		public Int16 REGISTROAPLICADO
		{
			get{ return Registroaplicado; }
			set
			{
				if(value!=Registroaplicado)
				{
					
					Registroaplicado = value;
				}
			}
		}
		public decimal NUMEXTRA1APLICADO
		{
			get{ return Numextra1aplicado; }
			set
			{
				if(value!=Numextra1aplicado)
				{
					
					Numextra1aplicado = value;
				}
			}
		}
		public decimal NUMEXTRA2APLICADO
		{
			get{ return Numextra2aplicado; }
			set
			{
				if(value!=Numextra2aplicado)
				{
					
					Numextra2aplicado = value;
				}
			}
		}
		public decimal NUMEXTRA3APLICADO
		{
			get{ return Numextra3aplicado; }
			set
			{
				if(value!=Numextra3aplicado)
				{
					
					Numextra3aplicado = value;
				}
			}
		}
		public string NUMEXTRA1ALIASAPL
		{
			get{ return Numextra1aliasapl.ToString().Trim(); }
			set
			{
				if(value!=Numextra1aliasapl)
				{
					
					Numextra1aliasapl = value;
				}
			}
		}
		public string NUMEXTRA2ALIASAPL
		{
			get{ return Numextra2aliasapl.ToString().Trim(); }
			set
			{
				if(value!=Numextra2aliasapl)
				{
					
					Numextra2aliasapl = value;
				}
			}
		}
		public string NUMEXTRA3ALIASAPL
		{
			get{ return Numextra3aliasapl.ToString().Trim(); }
			set
			{
				if(value!=Numextra3aliasapl)
				{
					
					Numextra3aliasapl = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public decimal CANTIDADDESTINO
		{
			get{ return Cantidaddestino; }
			set
			{
				if(value!=Cantidaddestino)
				{
					
					Cantidaddestino = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public decimal GASTODESTINO
		{
			get{ return Gastodestino; }
			set
			{
				if(value!=Gastodestino)
				{
					
					Gastodestino = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public decimal GASTOTOTAL
		{
			get{ return Gastototal; }
			set
			{
				if(value!=Gastototal)
				{
					
					Gastototal = value;
				}
			}
		}
        [DataMember(IsRequired = true)]
        public decimal CANTIDADAPROVECHADA
        {
            get { return Cantidadaprovechada; }
            set
            {
                if (value != Cantidadaprovechada)
                {
                    
                    Cantidadaprovechada = value;
                }
            }
        }
        [DataMember(IsRequired = true)]
		public decimal GASTOAPROVECHADO
		{
			get{ return Gastoaprovechado; }
			set
			{
				if(value!=Gastoaprovechado)
				{
					
					Gastoaprovechado = value;
				}
			}
		}
        [DataMember(IsRequired = true)]
        public decimal PRECIOUNITARIO
        {
            get { return PrecioUnitario; }
            set
            {
                if (value != PrecioUnitario)
                {
                    
                    PrecioUnitario = value;
                }
            }
        }
        [DataMember(IsRequired = true)]
        public decimal TOTALAPROVECHADO
        {
            get { return TotalAprovechado; }
            set
            {
                if (value != TotalAprovechado)
                {
                    
                    TotalAprovechado = value;
                }
            }
        }
    }
}
