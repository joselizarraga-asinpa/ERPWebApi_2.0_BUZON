using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class ProductoCompTipoProd: IEntidadBase
	{
		private Int32 Idproducto;
		private Int16 Idtipoproducto;
		private float Cantidad;
		private Int32 Idformula;
        private string Componente;
        private string ExpresionFormula;
        private bool MostrarId;
		
		
		//Constructor
		public ProductoCompTipoProd()
		{
			Idproducto = 0; 
			Idtipoproducto = 0; 
			Cantidad = 0; 
			Idformula = 0;
            Componente = "";
            ExpresionFormula = "";
            MostrarId = true;
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
		public Int16 IDTIPOPRODUCTO
		{
			get{ return Idtipoproducto; }
			set
			{
				if(value!=Idtipoproducto)
				{
					
					Idtipoproducto = value;
				}
			}
		}
		[DataMember(IsRequired = true)]
		public float CANTIDAD
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
		public Int32 IDFORMULA
		{
			get{ return Idformula; }
			set
			{
				if(value!=Idformula)
				{
					
					Idformula = value;
				}
			}
		}
        public string COMPONENTE
        {
            get { return Componente; }
            set
            {
                if(value!=Componente)
                {
                    
                    Componente = value;
                }
            }
        }
        public string EXPRESIONFORMULA
        {
            get { return ExpresionFormula; }
            set
            {
                if (value != ExpresionFormula)
                {
                    
                    ExpresionFormula = value;
                }
            }
        }
        public bool MOSTRARID
        {
            get { return MostrarId; }
            set
            {
                if(value != MostrarId)
                {
                    
                    MostrarId = value;
                }
            }
        }
    }
}
