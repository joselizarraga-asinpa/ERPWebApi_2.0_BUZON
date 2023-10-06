using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{
      
      //Clase creada por generador de código
      
      public class ProductoCodigo: IEntidadBase
      {
          private Int64 Id;
          private Int32 Idproducto;
          private string Codigo;
          private bool Compra;
          private bool Venta;
          private Int16 Orden;
          
          public Producto Producto { get; set;}
          
          //Constructor
          public ProductoCodigo()
          {
              Id = 0; 
              Idproducto = 0; 
              Codigo = ""; 
              Compra = false; 
              Venta = false; 
              Orden = 0; 
              
              Producto = new Producto();
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
          [DataMember(IsRequired = true)]
          public string CODIGO
          {
              get{ return Codigo.ToString().Trim(); }
              set
              {
                  if(value!=Codigo)
                  {
                      
                      Codigo = value;
                  }
              }
          }
          [DataMember(IsRequired = true)]
          public bool COMPRA
          {
              get{ return Compra; }
              set
              {
                  if(value!=Compra)
                  {
                      
                      Compra = value;
                  }
              }
          }
          [DataMember(IsRequired = true)]
          public bool VENTA
          {
              get{ return Venta; }
              set
              {
                  if(value!=Venta)
                  {
                      
                      Venta = value;
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
      }
}
