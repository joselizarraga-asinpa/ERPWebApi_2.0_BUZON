using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{
      
      //Clase creada por generador de código
      
      public class RepCotizacion: IEntidadBase
      {
          private string Folio;
          private long IdDocumento;
          private DateTime Fecha;
          private string Cliente;
          private string Direccion;
          private string Cotizacion;
          private string ClasDocCliProv;
          private Int16 Num;
          private string Nombreproducto;
          private string Descripcion;
          private string ClasOrigen;
          private string Nombretipounidad;
          private decimal Volumen;
          private decimal Unitario;
          private decimal Subtotal;
          private decimal Total;
          private string Ubicacion;
          private decimal Numextra1;
          private decimal Numextra2;
          private decimal Numextra3;
          private string Numextra1alias;
          private string Numextra2alias;
          private string Numextra3alias;
          private string Cristal;
          private string TotalLetra;
          private string Comentarios;
          
          
          //Constructor
          public RepCotizacion()
          {
              Folio = "";
              IdDocumento = 0;
              Fecha = System.DateTime.Today;
              Cliente = ""; 
              Direccion = ""; 
              Cotizacion = "";
              ClasDocCliProv = "";
              Num = 0; 
              Nombreproducto = ""; 
              Descripcion = "";
              ClasOrigen = "";
              Nombretipounidad = ""; 
              Volumen = 0; 
              Unitario = 0; 
              Subtotal = 0; 
              Total = 0; 
              Ubicacion = ""; 
              Numextra1 = 0; 
              Numextra2 = 0; 
              Numextra3 = 0; 
              Numextra1alias = ""; 
              Numextra2alias = ""; 
              Numextra3alias = ""; 
              Cristal = "";
              TotalLetra = "";
              Comentarios = "";
            
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
          public string CLIENTE
          {
              get{ return Cliente.ToString().Trim(); }
              set
              {
                  if(value!=Cliente)
                  {
                      
                      Cliente = value;
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
          public string CLASDOCCLIPROV
        {
            get { return ClasDocCliProv.ToString().Trim(); }
            set
            {
                if (value != ClasDocCliProv)
                {
                    
                    ClasDocCliProv = value;
                }
            }
        }
        public Int16 NUM
          {
              get{ return Num; }
              set
              {
                  if(value!=Num)
                  {
                      
                      Num = value;
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
            public string CLASORIGEN
            {
                get { return ClasOrigen.ToString().Trim(); }
                set
                {
                    if (value != ClasOrigen)
                    {
                        
                        ClasOrigen = value;
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
          public string UBICACION
          {
              get{ return Ubicacion.ToString().Trim(); }
              set
              {
                  if(value!=Ubicacion)
                  {
                      
                      Ubicacion = value;
                  }
              }
          }
          public decimal NUMEXTRA1
          {
              get{ return Numextra1; }
              set
              {
                  if(value!=Numextra1)
                  {
                      
                      Numextra1 = value;
                  }
              }
          }
          public decimal NUMEXTRA2
          {
              get{ return Numextra2; }
              set
              {
                  if(value!=Numextra2)
                  {
                      
                      Numextra2 = value;
                  }
              }
          }
          public decimal NUMEXTRA3
          {
              get{ return Numextra3; }
              set
              {
                  if(value!=Numextra3)
                  {
                      
                      Numextra3 = value;
                  }
              }
          }
          public string NUMEXTRA1ALIAS
          {
              get{ return Numextra1alias.ToString().Trim(); }
              set
              {
                  if(value!=Numextra1alias)
                  {
                      
                      Numextra1alias = value;
                  }
              }
          }
          public string NUMEXTRA2ALIAS
          {
              get{ return Numextra2alias.ToString().Trim(); }
              set
              {
                  if(value!=Numextra2alias)
                  {
                      
                      Numextra2alias = value;
                  }
              }
          }
          public string NUMEXTRA3ALIAS
          {
              get{ return Numextra3alias.ToString().Trim(); }
              set
              {
                  if(value!=Numextra3alias)
                  {
                      
                      Numextra3alias = value;
                  }
              }
          }
          public string CRISTAL
          {
              get{ return Cristal.ToString().Trim(); }
              set
              {
                  if(value!=Cristal)
                  {
                      
                      Cristal = value;
                  }
              }
          }
        public string TOTALLETRA
        {
            get { return TotalLetra.ToString().Trim(); }
            set
            {
                if (value != TotalLetra)
                {
                    
                    TotalLetra = value;
                }
            }
        }
        public string COMENTARIOS
        {
            get { return Comentarios.ToString().Trim(); }
            set
            {
                if (value != Comentarios)
                {
                    
                    Comentarios = value;
                }
            }
        }
    }
}
