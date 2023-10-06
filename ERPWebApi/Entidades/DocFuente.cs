using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class DocFuente: IEntidadBase
	{
		private Int64 Iddocumento;
		private Int64 Iddocfuente;
		private bool Todopendiente;
        private Int32 IdCliProv;
        private Int64 Id;
        private Int32 IdProducto;
        private string Codigo;
        private string Nombreproducto;
		private string Nombretipoproducto;        
        private decimal Cantidad;
		private decimal Existencia;
		private decimal Procesado;
		private decimal Porprocesar;
		
		
		//Constructor
		public DocFuente()
		{
			Iddocumento = 0; 
			Iddocfuente = 0; 
			Todopendiente = false;
            IdCliProv = 0;
            Id = 0;
            IdProducto = 0;
            Codigo = "";
            Nombreproducto = ""; 
			Nombretipoproducto = "";            
            Cantidad = 0; 
			Existencia = 0; 
			Procesado = 0; 
			Porprocesar = 0; 
			
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
		public Int64 IDDOCFUENTE
		{
			get{ return Iddocfuente; }
			set
			{
				if(value!=Iddocfuente)
				{
					
					Iddocfuente = value;
				}
			}
		}
		public bool TODOPENDIENTE
		{
			get{ return Todopendiente; }
			set
			{
				if(value!=Todopendiente)
				{
					
					Todopendiente = value;
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
        public Int64 ID
		{
			get{
                return Id; }
			set
			{
				if(value!=Id)
				{
					
					Id = value;
				}
			}
		}
        public Int32 IDPRODUCTO
        {
            get { return IdProducto; }
            set
            {
                if (value != IdProducto)
                {

                    IdProducto = value;
                }
            }
        }
        public string CODIGO
        {
            get { return Codigo.ToString().Trim(); }
            set
            {
                if (value != Codigo)
                {

                    Codigo = value;
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
		public decimal EXISTENCIA
		{
			get{ return Existencia; }
			set
			{
				if(value!=Existencia)
				{
					
					Existencia = value;
				}
			}
		}
		public decimal PROCESADO
		{
			get{ return Procesado; }
			set
			{
				if(value!=Procesado)
				{
					
					Procesado = value;
				}
			}
		}
		public decimal PORPROCESAR
		{
			get{ return Porprocesar; }
			set
			{
				if(value!=Porprocesar)
				{
					
					Porprocesar = value;
				}
			}
		}
	}
}
