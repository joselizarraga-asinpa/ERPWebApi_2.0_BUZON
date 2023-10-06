using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{
      
      //Clase creada por generador de código
      
      public class Status: IEntidadBase
      {
          private Int16 Id;
          private Int16 Idpincliente;
          private string Nombrestatus;
          private Int16 Idfuncionalidad;
          private bool Habilitado;
          
          //public PinCliente PinCliente { get; set;}
          //public Funcionalidad Funcionalidad { get; set;}
          //public List<CliProv> CliProv { get; set; }
          //public List<Producto> Producto { get; set; }
          
          //Constructor
          public Status()
          {
              Id = 0; 
              Idpincliente = 0; 
              Nombrestatus = ""; 
              Idfuncionalidad = 0; 
              Habilitado = false; 
              
              //PinCliente = new PinCliente();
              //Funcionalidad = new Funcionalidad();
              //CliProv = new List<CliProv>(); 
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
          public string NOMBRESTATUS
          {
              get{ return Nombrestatus.ToString().Trim(); }
              set
              {
                  if(value!=Nombrestatus)
                  {
                      
                      Nombrestatus = value;
                  }
              }
          }
          [DataMember(IsRequired = true)]
          public Int16 IDFUNCIONALIDAD
          {
              get{ return Idfuncionalidad; }
              set
              {
                  if(value!=Idfuncionalidad)
                  {
                      
                      Idfuncionalidad = value;
                  }
              }
          }
          [DataMember(IsRequired = true)]
          public bool HABILITADO
          {
              get{ return Habilitado; }
              set
              {
                  if(value!=Habilitado)
                  {
                      
                      Habilitado = value;
                  }
              }
          }
      }
}
