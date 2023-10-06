using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{
      
      //Clase creada por generador de código
      
      public class Impuesto: IEntidadBase
      {
          private Int16 Id;
          private Int16 Idmoneda;
          private string NombreImpuesto;
          private string Abreviatura;
          private decimal Tasa;
          private decimal Tasaret;

          public string NOMBREMONEDA { get; set; }

        //public Moneda Moneda { get; set;}
        //public List<Producto> Producto { get; set; }

        //Constructor
        public Impuesto()
          {
              Id = 0; 
              Idmoneda = 0;
              NombreImpuesto = ""; 
              Abreviatura = ""; 
              Tasa = 0; 
              Tasaret = 0; 
              
              //Moneda = new Moneda();
              //Producto = new List<Producto>(); 
          }
          
          public Int16 ID
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
          public Int16 IDMONEDA
          {
              get{ return Idmoneda; }
              set
              {
                  if(value!=Idmoneda)
                  {
                      
                      Idmoneda = value;
                  }
              }
          }
          [DataMember(IsRequired = true)]
          public string NOMBREIMPUESTO
          {
              get{ return NombreImpuesto.ToString().Trim(); }
              set
              {
                  if(value!= NombreImpuesto)
                  {
                      
                    NombreImpuesto = value;
                  }
              }
          }
          [DataMember(IsRequired = true)]
          public string ABREVIATURA
          {
              get{ return Abreviatura.ToString().Trim(); }
              set
              {
                  if(value!=Abreviatura)
                  {
                      
                      Abreviatura = value;
                  }
              }
          }
          [DataMember(IsRequired = true)]
          public decimal TASA
          {
              get{ return Tasa; }
              set
              {
                  if(value!=Tasa)
                  {
                      
                      Tasa = value;
                  }
              }
          }
          [DataMember(IsRequired = true)]
          public decimal TASARET
          {
              get{ return Tasaret; }
              set
              {
                  if(value!=Tasaret)
                  {
                      
                      Tasaret = value;
                  }
              }
          }
      }
}
