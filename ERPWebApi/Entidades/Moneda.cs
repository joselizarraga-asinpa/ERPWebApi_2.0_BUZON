using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{
      
      //Clase creada por generador de código
      
      public class Moneda: IEntidadBase
      {
          private Int16 Id;
          private string Nombremoneda;
          private string Abreviatura;

          
          //public List<Documento> Documento { get; set; }
          //public List<Impuesto> Impuesto { get; set; }
          //public List<MovCaja> MovCaja { get; set; }
          //public List<TipoCambio> TipoCambio { get; set; }
          //public List<TipoDocMoneda> TipoDocMoneda { get; set; }
          
          //Constructor
          public Moneda()
          {
              Id = 0; 
              Nombremoneda = ""; 
              Abreviatura = ""; 
              
              //Documento = new List<Documento>(); 
              //Impuesto = new List<Impuesto>(); 
              //MovCaja = new List<MovCaja>(); 
              //TipoCambio = new List<TipoCambio>(); 
              //TipoDocMoneda = new List<TipoDocMoneda>(); 
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
          public string NOMBREMONEDA
          {
              get{ return Nombremoneda.ToString().Trim(); }
              set
              {
                  if(value!=Nombremoneda)
                  {
                      
                      Nombremoneda = value;
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
      }
}
