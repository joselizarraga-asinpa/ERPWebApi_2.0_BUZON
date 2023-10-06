using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{
      
      //Clase creada por generador de código
      
      public class TipoDocGenerar: IEntidadBase
      {
          private Int16 Idtipodoc;
          private Int16 Idtipodocgenerar;
          private string Nombretipodoc;
          private bool Multiples;
          private Int16 Orden;
          private bool AnclarFolio;
          
          //public TipoDocGenerar TipoDocGenerar { get; set;}
          
          //Constructor
          public TipoDocGenerar()
          {
              Idtipodoc = 0; 
              Idtipodocgenerar = 0;
              Nombretipodoc = "";
              Multiples = false; 
              Orden = 0;
              AnclarFolio = false;
              //TipoDocGenerar = new TipoDocGenerar();
        }
          
          [DataMember(IsRequired = true)]
          public Int16 IDTIPODOC
          {
              get{ return Idtipodoc; }
              set
              {
                  if(value!=Idtipodoc)
                  {
                      
                      Idtipodoc = value;
                  }
              }
          }
          [DataMember(IsRequired = true)]
          public Int16 IDTIPODOCGENERAR
          {
              get{ return Idtipodocgenerar; }
              set
              {
                  if(value!=Idtipodocgenerar)
                  {
                      
                      Idtipodocgenerar = value;
                  }
              }
          }        
        public string NOMBRETIPODOC
        {
            get { return Nombretipodoc.ToString().Trim(); }
            set
            {
                if (value != Nombretipodoc)
                {
                    
                    Nombretipodoc = value;
                }
            }
        }
        [DataMember(IsRequired = true)]
          public bool MULTIPLES
          {
              get{ return Multiples; }
              set
              {
                  if(value!=Multiples)
                  {
                      
                      Multiples = value;
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
        [DataMember(IsRequired = true)]
        public bool ANCLARFOLIO
        {
            get { return AnclarFolio; }
            set
            {
                if (value != AnclarFolio)
                {
                    
                    AnclarFolio = value;
                }
            }
        }
    }
}
