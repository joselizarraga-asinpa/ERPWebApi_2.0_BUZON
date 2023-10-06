using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{
      
      //Clase creada por generador de código
      
      public class Formula: IEntidadBase
      {
          private Int32 Id;
          private Int16 Idpincliente;
          private string Nombreformula;
          private string Expresionformula;
        private bool MostrarId;


        //Constructor
        public Formula()
          {
            Id = 0; 
            Idpincliente = 0; 
            Nombreformula = ""; 
            Expresionformula = "";
            MostrarId = true;            
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
          public Int16 IDPINCLIENTE
          {
              get{ return Idpincliente; }
              set
              {
                  if(value!=Idpincliente)
                  {
                      
                      Idpincliente = value;
                  }
              }
          }
          [DataMember(IsRequired = true)]
          public string NOMBREFORMULA
          {
              get{ return Nombreformula.ToString().Trim(); }
              set
              {
                  if(value!=Nombreformula)
                  {
                      
                      Nombreformula = value;
                  }
              }
          }
          [DataMember(IsRequired = true)]
          public string EXPRESIONFORMULA
          {
              get{ return Expresionformula.ToString().Trim(); }
              set
              {
                  if(value!=Expresionformula)
                  {
                      
                      Expresionformula = value;
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
    }
}
