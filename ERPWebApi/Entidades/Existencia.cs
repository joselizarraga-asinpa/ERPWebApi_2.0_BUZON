using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{

	//Clase creada por generador de código

	public class Existencia: IEntidadBase
	{
		private Int64 Id;
		private Int32 Idproducto;
        private string NombreAlmacen;
        private Int16 Idalmacen;
		private Int32 Idclas1;
		private Int32 Idclas2;
		private Int32 Idclas3;
		private Int32 Idclas4;
		private Int32 Idclas5;
		private Int32 Idclas6;
		private Int32 Idclas7;
		private Int32 Idclas8;
		private Int32 Idclas9;
		private Int32 Idclas10;
		private string Lote;
		private DateTime Caducidad;
		private decimal Cantidad;
		private decimal Costo;
        private bool SaldosNeg;
        private string Serie1;
        private string Serie2;
        private string Serie3;
        private string Serie4;
        private string Serie5;

        [DataMember(IsRequired = true)]
        public virtual List<DocDetalle> lDocDetalle { get; set; }

        //Constructor
        public Existencia()
		{
            TransactionDetailType = Enumeradores.TypeAction.Main;

			Id = 0; 
			Idproducto = 0;
            NombreAlmacen = "";
            Idalmacen = 0; 
			Idclas1 = 0; 
			Idclas2 = 0; 
			Idclas3 = 0; 
			Idclas4 = 0; 
			Idclas5 = 0; 
			Idclas6 = 0; 
			Idclas7 = 0; 
			Idclas8 = 0; 
			Idclas9 = 0; 
			Idclas10 = 0; 
			Lote = ""; 
			Caducidad = System.DateTime.Today;
			Cantidad = 0; 
			Costo = 0;
            SaldosNeg = false;
            Serie1 = "";
            Serie2 = "";
            Serie3 = "";
            Serie4 = "";
            Serie5 = "";

            this.lDocDetalle = new List<DocDetalle>();
            //eDocDetalle = new DocDetalle();                        
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
            get { return NombreAlmacen; }
            set
            {
                if (value != NombreAlmacen)
                {
                    NombreAlmacen = value;
                }
            }
        }
        public Int32 IDCLAS1
		{
			get{ return Idclas1; }
			set
			{
				if(value!=Idclas1)
				{
					
					Idclas1 = value;
				}
			}
		}
		public Int32 IDCLAS2
		{
			get{ return Idclas2; }
			set
			{
				if(value!=Idclas2)
				{
					
					Idclas2 = value;
				}
			}
		}
		public Int32 IDCLAS3
		{
			get{ return Idclas3; }
			set
			{
				if(value!=Idclas3)
				{
					
					Idclas3 = value;
				}
			}
		}
		public Int32 IDCLAS4
		{
			get{ return Idclas4; }
			set
			{
				if(value!=Idclas4)
				{
					
					Idclas4 = value;
				}
			}
		}
		public Int32 IDCLAS5
		{
			get{ return Idclas5; }
			set
			{
				if(value!=Idclas5)
				{
					
					Idclas5 = value;
				}
			}
		}
		public Int32 IDCLAS6
		{
			get{ return Idclas6; }
			set
			{
				if(value!=Idclas6)
				{
					
					Idclas6 = value;
				}
			}
		}
		public Int32 IDCLAS7
		{
			get{ return Idclas7; }
			set
			{
				if(value!=Idclas7)
				{
					
					Idclas7 = value;
				}
			}
		}
		public Int32 IDCLAS8
		{
			get{ return Idclas8; }
			set
			{
				if(value!=Idclas8)
				{
					
					Idclas8 = value;
				}
			}
		}
		public Int32 IDCLAS9
		{
			get{ return Idclas9; }
			set
			{
				if(value!=Idclas9)
				{
					
					Idclas9 = value;
				}
			}
		}
		public Int32 IDCLAS10
		{
			get{ return Idclas10; }
			set
			{
				if(value!=Idclas10)
				{
					
					Idclas10 = value;
				}
			}
		}
		public string LOTE
		{
			get{ return Lote.ToString().Trim(); }
			set
			{
				if(value!=Lote)
				{
					
					Lote = value;
				}
			}
		}
		public DateTime CADUCIDAD
		{
			get{ return Caducidad; }
			set
			{
				if (value != null)
				{
					if(value!=Caducidad)
					{
						
						Caducidad = value;
					}
				}
			}
		}
		[DataMember(IsRequired = true)]
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
		public decimal COSTO
		{
			get{ return Costo; }
			set
			{
				if(value!=Costo)
				{
					
					Costo = value;
				}
			}
		}
        [DataMember(IsRequired = true)]
        public bool SALDOSNEG
        {
            get { return SaldosNeg; }
            set
            {
                if (value != SaldosNeg)
                {                    
                    SaldosNeg = value;
                }
            }
        }
        public string SERIE1
        {
            get { return Serie1.ToString().Trim(); }
            set
            {
                if (value != Serie1)
                {
                    Serie1 = value;
                }
            }
        }
        public string SERIE2
        {
            get { return Serie2.ToString().Trim(); }
            set
            {
                if (value != Serie2)
                {
                    Serie2 = value;
                }
            }
        }
        public string SERIE3
        {
            get { return Serie3.ToString().Trim(); }
            set
            {
                if (value != Serie3)
                {
                    Serie3 = value;
                }
            }
        }
        public string SERIE4
        {
            get { return Serie4.ToString().Trim(); }
            set
            {
                if (value != Serie4)
                {
                    Serie4 = value;
                }
            }
        }
        public string SERIE5
        {
            get { return Serie5.ToString().Trim(); }
            set
            {
                if (value != Serie5)
                {
                    Serie5 = value;
                }
            }
        }
    }
}
