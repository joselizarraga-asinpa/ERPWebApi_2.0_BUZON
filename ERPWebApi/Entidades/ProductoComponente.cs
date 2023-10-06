using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{
      
      //Clase creada por generador de código
      
      public class ProductoComponente: IEntidadBase
      {
          private long Idproducto;
          private long Idproductocomp;
          private decimal Cantidad;
          private Int32 Idformula;
          private string ExpresionFormula;
          private string Componente;
          private bool MostrarId;
          private bool AfectaCosto;

        //public Producto Producto { get; set;}
        //public Formula Formula { get; set;}

        //Constructor
        public ProductoComponente()
        {
            Idproducto = 0; 
            Idproductocomp = 0; 
            Cantidad = 0; 
            Idformula = 0;
            Componente = "";
            ExpresionFormula = "";
            MostrarId = true;
            AfectaCosto = true;

            //Producto = new Producto();
            //Formula = new Formula();
        }
          
          [DataMember(IsRequired = true)]
          public long IDPRODUCTO
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
          public long IDPRODUCTOCOMP
          {
              get{ return Idproductocomp; }
              set
              {
                  if(value!=Idproductocomp)
                  {
                      
                      Idproductocomp = value;
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
                if (value != Componente)
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
                if (value != MostrarId)
                {
                    
                    MostrarId = value;
                }
            }
        }
        public bool AFECTACOSTO
        {
            get { return AfectaCosto; }
            set
            {
                if (value != AfectaCosto)
                {

                    AfectaCosto = value;
                }
            }
        }
    }
}
