using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{
      
      //Clase creada por generador de código
      
    public class ProductoClas: IEntidadBase
    {
        private Int32 Idproducto;
        private Int32 Idclas;
        private decimal Costo;
        private string NombreClasificacion;
        private bool Solicitaendoc;


        public List<ProductoClas> lProductoClas;          
          
        //Constructor
        public ProductoClas()
        {
            Idproducto = 0; 
            Idclas = 0;
            Costo = 0;
            NombreClasificacion = "";
            Solicitaendoc = false;
            lProductoClas = new List<ProductoClas>();            
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
          public Int32 IDCLAS
          {
              get{ return Idclas; }
              set
              {
                  if(value!=Idclas)
                  {
                      
                      Idclas = value;
                  }
              }
          }
            [DataMember(IsRequired = true)]
            public decimal COSTO
            {
                get
                {
                    return Costo;
                }
                set
                {
                    if (value != Costo)
                    {
                        
                        Costo = value;
                    }
                }
            }        
        public string NOMBRECLASIFICACION
        {
            get { return NombreClasificacion.ToString().Trim(); }
            set
            {
                if (value != NombreClasificacion)
                {

                    NombreClasificacion = value;
                }
            }
        }
        public bool SOLICITAENDOC
        {
            get { return Solicitaendoc; }
            set
            {
                if (value != Solicitaendoc)
                {
                    Solicitaendoc = value;
                }
            }
        }
    }
}
