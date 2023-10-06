using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class ProductoProv: IEntidadBase
	{
		private Int32 Id;
		private Int32 Idproducto;
		private Int32 Idcliprov;
        private Int16 IdMoneda;        
        private Int16 Orden;
        private string NombreProveedor;
        private decimal PrecioCompra;
        private string NombreMoneda;


        //Constructor
        public ProductoProv()
		{
			Id = 0; 
			Idproducto = 0; 
			Idcliprov = 0;
            IdMoneda = 0;
            NombreMoneda = "";
            Orden = 0;
            NombreProveedor = "";
            PrecioCompra = 0;

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
		[DataMember(IsRequired = true)]
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
		[DataMember(IsRequired = true)]
		public Int32 IDCLIPROV
		{
			get{ return Idcliprov; }
			set
			{
				if(value!=Idcliprov)
				{
					
					Idcliprov = value;
				}
			}
		}
        [DataMember(IsRequired = true)]
        public Int16 IDMONEDA
        {
            get { return IdMoneda; }
            set
            {
                if (value != IdMoneda)
                {

                    IdMoneda = value;
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
        public string NOMBREPROVEEDOR
        {
            get {return NombreProveedor; }
            set
            {
                if(value!= NombreProveedor)
                {
                    
                    NombreProveedor = value;
                }
            }
        }
        public decimal PRECIOCOMPRA
        {
            get { return PrecioCompra; }
            set
            {
                if (value != PrecioCompra)
                {
                    PrecioCompra = value;
                }
            }
        }
        public string NOMBREMONEDA
        {
            get { return NombreMoneda; }
            set
            {
                if (value != NombreMoneda)
                {
                    NombreMoneda = value;
                }
            }
        }

    }
}
