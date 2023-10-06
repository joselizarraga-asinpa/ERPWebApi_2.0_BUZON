using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{
      
      //Clase creada por generador de código
      
      public class RepMateriales: IEntidadBase
      {
            private string Folio;
            private long IdDocumento;
            private DateTime Fecha;
            private string Direccion;
            private string Cotizacion;
            private string Dirigidoa;
            private string Codigo;
            private string Nombreproducto;
            private string Descripcion;          
            private string Nombretipoproducto;
            private string Nombretipounidad;        
            private decimal Volumen;
            private decimal Comprado;
            private decimal SaldoPorComprar;
            private decimal Unitario;
            private decimal Subtotal;
            private decimal Total;
            private string Abreviaturatipounidad;          
          
          //Constructor
          public RepMateriales()
          {
            Folio = "";
            IdDocumento = 0;
            Fecha = System.DateTime.Today;              
            Direccion = ""; 
            Cotizacion = "";
            Dirigidoa = "";
            Codigo = "";              
            Nombreproducto = ""; 
            Descripcion = "";              
            Nombretipoproducto = "";
            Nombretipounidad = ""; 
            Volumen = 0;
            Comprado = 0;
            SaldoPorComprar = 0;
            Unitario = 0; 
            Subtotal = 0; 
            Total = 0;
            Abreviaturatipounidad = ""; 
            
          }

        [DataMember(IsRequired = true)]
        public long IDDOCUMENTO
        {
            get { return IdDocumento; }
            set
            {
                if (value != IdDocumento)
                {
                    
                    IdDocumento = value;
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
          public DateTime FECHA
          {
              get{ return Fecha; }
              set
              {
                  if (value != null)
                  {
                      if(value!=Fecha)
                      {
                          
                          Fecha = value;
                      }
                  }
              }
          }          
          public string DIRECCION
          {
              get{ return Direccion.ToString().Trim(); }
              set
              {
                  if(value!=Direccion)
                  {
                      
                      Direccion = value;
                  }
              }
          }
          public string COTIZACION
          {
              get{ return Cotizacion.ToString().Trim(); }
              set
              {
                  if(value!=Cotizacion)
                  {
                      
                      Cotizacion = value;
                  }
              }
          }        
        public string DIRIGIDOA
        {
            get { return Dirigidoa.ToString().Trim(); }
            set
            {
                if (value != Dirigidoa)
                {
                    
                    Dirigidoa = value;
                }
            }
        }
        public string CODIGO
        {
            get { return Codigo.ToString().Trim(); }
            set
            {
                if (value != Codigo)
                {
                    
                    Codigo = value;
                }
            }
        }

        public string NOMBREPRODUCTO
          {
              get{ return Nombreproducto.ToString().Trim(); }
              set
              {
                  if(value!=Nombreproducto)
                  {
                      
                      Nombreproducto = value;
                  }
              }
          }
          public string DESCRIPCION
          {
              get{ return Descripcion.ToString().Trim(); }
              set
              {
                  if(value!=Descripcion)
                  {
                      
                      Descripcion = value;
                  }
              }
          }
            public string NOMBRETIPOPRODUCTO
        {
                get { return Nombretipoproducto.ToString().Trim(); }
                set
                {
                    if (value != Nombretipoproducto)
                    {
                        
                    Nombretipoproducto = value;
                    }
                }
            }
            public string NOMBRETIPOUNIDAD
          {
              get{ return Nombretipounidad.ToString().Trim(); }
              set
              {
                  if(value!=Nombretipounidad)
                  {
                      
                      Nombretipounidad = value;
                  }
              }
          }          
          public decimal VOLUMEN
          {
              get{ return Volumen; }
              set
              {
                  if(value!=Volumen)
                  {
                      
                      Volumen = value;
                  }
              }
          }
        public decimal COMPRADO
        {
            get { return Comprado; }
            set
            {
                if (value != Comprado)
                {

                    Comprado = value;
                }
            }
        }
        public decimal SALDOPORCOMPRAR
        {
            get { return SaldoPorComprar; }
            set
            {
                if (value != SaldoPorComprar)
                {

                    SaldoPorComprar = value;
                }
            }
        }
        public decimal UNITARIO
          {
              get{ return Unitario; }
              set
              {
                  if(value!=Unitario)
                  {
                      
                      Unitario = value;
                  }
              }
          }
          public decimal SUBTOTAL
          {
              get{ return Subtotal; }
              set
              {
                  if(value!=Subtotal)
                  {
                      
                      Subtotal = value;
                  }
              }
          }
          public decimal TOTAL
          {
              get{ return Total; }
              set
              {
                  if(value!=Total)
                  {
                      
                      Total = value;
                  }
              }
          }
          public string ABREVIATURATIPOUNIDAD
          {
              get{ return Abreviaturatipounidad.ToString().Trim(); }
              set
              {
                  if(value!= Abreviaturatipounidad)
                  {
                      
                    Abreviaturatipounidad = value;
                  }
              }
          }          
    }
}
