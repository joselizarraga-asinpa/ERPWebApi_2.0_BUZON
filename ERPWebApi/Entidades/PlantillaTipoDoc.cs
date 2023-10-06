using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{
      
      //Clase creada por generador de código
      
      public class PlantillaTipoDoc: IEntidadBase
      {
          private Int16 Id;
          private Int16 Idgrupotipodoc;
          private Int16 Idplantillaaplicar;
          private string Nombreplantilla;
          private string Folios;
          private string Cliprov;
          private string Ingreso;
          private bool Fiscal;
          private bool Credito;
          private bool Manejadinero;
          private bool Descuentos;
          private bool Factorutilidad;
          private bool Desglozarimpuestos;
          private bool Validaotrotipodoc;
          private bool Apartainventario;
          private bool Inventario;
          private string Entrada;
          private bool Conceptos;
          private bool Recurrente;
          private bool Modificarfecha;
          private bool Global;
          private string Tipocosteo;
          
          //public GrupoTipoDoc GrupoTipoDoc { get; set;}
          
          //Constructor
          public PlantillaTipoDoc()
          {
              Id = 0; 
              Idgrupotipodoc = 0; 
              Idplantillaaplicar = 0; 
              Nombreplantilla = ""; 
              Folios = ""; 
              Cliprov = ""; 
              Ingreso = ""; 
              Fiscal = false; 
              Credito = false; 
              Manejadinero = false; 
              Descuentos = false; 
              Factorutilidad = false; 
              Desglozarimpuestos = false; 
              Validaotrotipodoc = false; 
              Apartainventario = false; 
              Inventario = false; 
              Entrada = ""; 
              Conceptos = false; 
              Recurrente = false; 
              Modificarfecha = false; 
              Global = false; 
              Tipocosteo = ""; 
              
              //GrupoTipoDoc = new GrupoTipoDoc();
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
          public Int16 IDGRUPOTIPODOC
          {
              get{ return Idgrupotipodoc; }
              set
              {
                  if(value!=Idgrupotipodoc)
                  {
                      
                      Idgrupotipodoc = value;
                  }
              }
          }
          public Int16 IDPLANTILLAAPLICAR
          {
              get{ return Idplantillaaplicar; }
              set
              {
                  if(value!=Idplantillaaplicar)
                  {
                      
                      Idplantillaaplicar = value;
                  }
              }
          }
          [DataMember(IsRequired = true)]
          public string NOMBREPLANTILLA
          {
              get{ return Nombreplantilla.ToString().Trim(); }
              set
              {
                  if(value!=Nombreplantilla)
                  {
                      
                      Nombreplantilla = value;
                  }
              }
          }
          [DataMember(IsRequired = true)]
          public string FOLIOS
          {
              get{ return Folios.ToString().Trim(); }
              set
              {
                  if(value!=Folios)
                  {
                      
                      Folios = value;
                  }
              }
          }
          [DataMember(IsRequired = true)]
          public string CLIPROV
          {
              get{ return Cliprov.ToString().Trim(); }
              set
              {
                  if(value!=Cliprov)
                  {
                      
                      Cliprov = value;
                  }
              }
          }
          [DataMember(IsRequired = true)]
          public string INGRESO
          {
              get{ return Ingreso.ToString().Trim(); }
              set
              {
                  if(value!=Ingreso)
                  {
                      
                      Ingreso = value;
                  }
              }
          }
          [DataMember(IsRequired = true)]
          public bool FISCAL
          {
              get{ return Fiscal; }
              set
              {
                  if(value!=Fiscal)
                  {
                      
                      Fiscal = value;
                  }
              }
          }
          [DataMember(IsRequired = true)]
          public bool CREDITO
          {
              get{ return Credito; }
              set
              {
                  if(value!=Credito)
                  {
                      
                      Credito = value;
                  }
              }
          }
          [DataMember(IsRequired = true)]
          public bool MANEJADINERO
          {
              get{ return Manejadinero; }
              set
              {
                  if(value!=Manejadinero)
                  {
                      
                      Manejadinero = value;
                  }
              }
          }
          [DataMember(IsRequired = true)]
          public bool DESCUENTOS
          {
              get{ return Descuentos; }
              set
              {
                  if(value!=Descuentos)
                  {
                      
                      Descuentos = value;
                  }
              }
          }
          [DataMember(IsRequired = true)]
          public bool FACTORUTILIDAD
          {
              get{ return Factorutilidad; }
              set
              {
                  if(value!=Factorutilidad)
                  {
                      
                      Factorutilidad = value;
                  }
              }
          }
          [DataMember(IsRequired = true)]
          public bool DESGLOZARIMPUESTOS
          {
              get{ return Desglozarimpuestos; }
              set
              {
                  if(value!=Desglozarimpuestos)
                  {
                      
                      Desglozarimpuestos = value;
                  }
              }
          }
          [DataMember(IsRequired = true)]
          public bool VALIDAOTROTIPODOC
          {
              get{ return Validaotrotipodoc; }
              set
              {
                  if(value!=Validaotrotipodoc)
                  {
                      
                      Validaotrotipodoc = value;
                  }
              }
          }
          [DataMember(IsRequired = true)]
          public bool APARTAINVENTARIO
          {
              get{ return Apartainventario; }
              set
              {
                  if(value!=Apartainventario)
                  {
                      
                      Apartainventario = value;
                  }
              }
          }
          [DataMember(IsRequired = true)]
          public bool INVENTARIO
          {
              get{ return Inventario; }
              set
              {
                  if(value!=Inventario)
                  {
                      
                      Inventario = value;
                  }
              }
          }
          [DataMember(IsRequired = true)]
          public string ENTRADA
          {
              get{ return Entrada.ToString().Trim(); }
              set
              {
                  if(value!=Entrada)
                  {
                      
                      Entrada = value;
                  }
              }
          }
          [DataMember(IsRequired = true)]
          public bool CONCEPTOS
          {
              get{ return Conceptos; }
              set
              {
                  if(value!=Conceptos)
                  {
                      
                      Conceptos = value;
                  }
              }
          }
          [DataMember(IsRequired = true)]
          public bool RECURRENTE
          {
              get{ return Recurrente; }
              set
              {
                  if(value!=Recurrente)
                  {
                      
                      Recurrente = value;
                  }
              }
          }
          [DataMember(IsRequired = true)]
          public bool MODIFICARFECHA
          {
              get{ return Modificarfecha; }
              set
              {
                  if(value!=Modificarfecha)
                  {
                      
                      Modificarfecha = value;
                  }
              }
          }
          [DataMember(IsRequired = true)]
          public bool GLOBAL
          {
              get{ return Global; }
              set
              {
                  if(value!=Global)
                  {
                      
                      Global = value;
                  }
              }
          }
          [DataMember(IsRequired = true)]
          public string TIPOCOSTEO
          {
              get{ return Tipocosteo.ToString().Trim(); }
              set
              {
                  if(value!=Tipocosteo)
                  {
                      
                      Tipocosteo = value;
                  }
              }
          }
      }
}
