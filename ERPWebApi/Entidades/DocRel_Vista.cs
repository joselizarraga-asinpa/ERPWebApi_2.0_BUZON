using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{
      
      //Clase creada por generador de código
      
      public class DocRel_Vista: IEntidadBase
      {
        private string Tipo;
        private string Nombretipodoc;
        private string Folio;
        private Int16 Idtipodocgenerar;
        private Int64 Id;
        private string IdsDocDetalle;
        private Int32 IdProductoSel;
        private string ObsProdSel;
        private decimal PorcAplicado;
        private decimal CantidadProdSel;
        private decimal Importe;


        //Constructor
        public DocRel_Vista()
        {
            Tipo = ""; 
            Nombretipodoc = ""; 
            Folio = ""; 
            Id = 0;
            Idtipodocgenerar = 0;
            IdsDocDetalle= "";
            IdProductoSel = 0;
            ObsProdSel = "";
            PorcAplicado = 0;
            CantidadProdSel = 1;
            Importe = 0;
        }
          
          [DataMember(IsRequired = true)]
          public string TIPO
          {
              get{ return Tipo.ToString().Trim(); }
              set
              {
                  if(value!=Tipo)
                  {
                      
                      Tipo = value;
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
        public Int16 IDTIPODOCGENERAR
        {
            get { return Idtipodocgenerar; }
            set
            {
                if (value != Idtipodocgenerar)
                {
                    
                    Idtipodocgenerar = value;
                }
            }
        }
        public string IDSDOCDETALLE
        {
            get { return IdsDocDetalle.ToString().Trim(); }
            set
            {
                if (value != IdsDocDetalle)
                {
                    
                    IdsDocDetalle = value;
                }
            }
        }
       
        public string OBSPRODSEL
        {
            get { return ObsProdSel.ToString().Trim(); }
            set
            {
                if (value != ObsProdSel)
                {
                    ObsProdSel = value;
                }
            }
        }

        public Int32 IDPRODUCTOSEL
        {
            get { return IdProductoSel; }
            set
            {
                if (value != IdProductoSel)
                {

                    IdProductoSel = value;
                }
            }
        }

        public Decimal PORCAPLICADO
        {
            get { return PorcAplicado; }
            set
            {
                if (value != PorcAplicado)
                {

                    PorcAplicado = value;
                }
            }
        }

        public decimal CANTIDADPRODSEL
        {
            get { return CantidadProdSel; }
            set
            {
                if (value != CantidadProdSel)
                {

                    CantidadProdSel = value;
                }
            }
        }

        public Decimal IMPORTE
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
