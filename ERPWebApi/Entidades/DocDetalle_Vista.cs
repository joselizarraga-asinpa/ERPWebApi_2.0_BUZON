using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{
      
      //Clase creada por generador de código
      
      public class DocDetalle_Vista: IEntidadBase
      {
          private Int64 Id;
          private Int64 Iddocumento;
          private Int64 Iddocaplicado;
          private Int64 Idexistencia;
          private Int32 Idproducto;
          private Int64 Iddocdetallepadre;
          private Int64 Iddocdetallefuente;
          private decimal Registro;
          private decimal Cantidad;
          private decimal Factor;          
          private decimal Porcentaje;
          private decimal Costo;
          private decimal Unitario;
          private decimal Publico;
          private decimal Subtotal;
          private decimal Utilidadimporte;
          private decimal Descuento;
          private decimal Descuentoimporte;
          private decimal Totalantesimpuestos;
          private decimal Impuestotrasladado;
          private decimal Impuestoretenido;
          private decimal Total;
          private decimal Tasaimpuesto;
          private decimal Tasaretimpuesto;
          private decimal Numextra1;
          private decimal Numextra2;
          private decimal Numextra3;
          private string Numextra1alias;
          private string Numextra2alias;
          private string Numextra3alias;
          private string Nombreproducto;
          private string Obs;
          private string Comentarios;
          private string Componente;
          private bool Tienecomponentes;
        private Int16 IdTipoDocGenerar;
          
          //public Documento Documento { get; set;}
          //public Existencia Existencia { get; set;}
          //public Producto Producto { get; set;}
          
          //Constructor
          public DocDetalle_Vista()
          {
              Id = 0; 
              Iddocumento = 0; 
              Iddocaplicado = 0; 
              Idexistencia = 0; 
              Idproducto = 0; 
              Iddocdetallepadre = 0;
              Iddocdetallefuente = 0;
              Registro = 0;
              Cantidad = 0; 
              Factor = 0; 
              Descuento = 0; 
              Porcentaje = 0; 
              Costo = 0; 
              Unitario = 0; 
              Publico = 0; 
              Subtotal = 0; 
              Utilidadimporte = 0; 
              Descuentoimporte = 0; 
              Totalantesimpuestos = 0; 
              Impuestotrasladado = 0; 
              Impuestoretenido = 0; 
              Total = 0; 
              Tasaimpuesto = 0; 
              Tasaretimpuesto = 0; 
              Numextra1 = 0; 
              Numextra2 = 0; 
              Numextra3 = 0; 
              Numextra1alias = ""; 
              Numextra2alias = ""; 
              Numextra3alias = ""; 
              Nombreproducto = ""; 
              Obs = "";
              Comentarios = "";
              Componente = "0"; 
              Tienecomponentes = false;
              IdTipoDocGenerar = 0;

              //Documento = new Documento();
              //Existencia = new Existencia();
              //Producto = new Producto();
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
          public Int64 IDDOCUMENTO
          {
              get{ return Iddocumento; }
              set
              {
                  if(value!=Iddocumento)
                  {
                      
                      Iddocumento = value;
                  }
              }
          }
          public Int64 IDDOCAPLICADO
          {
              get{ return Iddocaplicado; }
              set
              {
                  if(value!=Iddocaplicado)
                  {
                      
                      Iddocaplicado = value;
                  }
              }
          }
          public Int64 IDEXISTENCIA
          {
              get{ return Idexistencia; }
              set
              {
                  if(value!=Idexistencia)
                  {
                      
                      Idexistencia = value;
                  }
              }
          }
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
          public Int64 IDDOCDETALLEPADRE
          {
              get{ return Iddocdetallepadre; }
              set
              {
                  if(value!=Iddocdetallepadre)
                  {
                      
                      Iddocdetallepadre = value;
                  }
              }
          }
        public Int64 IDDOCDETALLEFUENTE
        {
            get { return Iddocdetallefuente; }
            set
            {
                if (value != Iddocdetallefuente)
                {

                    Iddocdetallefuente = value;
                }
            }
        }
        [DataMember(IsRequired = true)]
            public decimal REGISTRO
            {
                get { return Registro; }
                set
                {
                    if (value != Registro)
                    {
                        
                        Registro = value;
                    }
                }
            }
        public decimal CANTIDAD
          {
              get{ return Cantidad; }
              set
              {
                  if(value!=Cantidad)
                  {
                      
                      Cantidad = value;
                  }
              }
          }
          public decimal FACTOR
          {
              get{ return Factor; }
              set
              {
                  if(value!=Factor)
                  {
                      
                      Factor = value;
                  }
              }
          }          
          public decimal PORCENTAJE
          {
              get{ return Porcentaje; }
              set
              {
                  if(value!=Porcentaje)
                  {
                      
                      Porcentaje = value;
                  }
              }
          }
          public decimal COSTO
          {
              get{ return Costo; }
              set
              {
                  if(value!=Costo)
                  {
                      
                      Costo = value;
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
          public decimal PUBLICO
          {
              get{ return Publico; }
              set
              {
                  if(value!=Publico)
                  {
                      
                      Publico = value;
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
          public decimal UTILIDADIMPORTE
          {
              get{ return Utilidadimporte; }
              set
              {
                  if(value!=Utilidadimporte)
                  {                      
                      Utilidadimporte = value;
                  }
              }
          }
        public decimal DESCUENTO
        {
            get { return Descuento; }
            set
            {
                if (value != Descuento)
                {

                    Descuento = value;
                }
            }
        }
        public decimal DESCUENTOIMPORTE
          {
              get{ return Descuentoimporte; }
              set
              {
                  if(value!=Descuentoimporte)
                  {
                      
                      Descuentoimporte = value;
                  }
              }
          }
          public decimal TOTALANTESIMPUESTOS
          {
              get{ return Totalantesimpuestos; }
              set
              {
                  if(value!=Totalantesimpuestos)
                  {
                      
                      Totalantesimpuestos = value;
                  }
              }
          }
          public decimal IMPUESTOTRASLADADO
          {
              get{ return Impuestotrasladado; }
              set
              {
                  if(value!=Impuestotrasladado)
                  {
                      
                      Impuestotrasladado = value;
                  }
              }
          }
          public decimal IMPUESTORETENIDO
          {
              get{ return Impuestoretenido; }
              set
              {
                  if(value!=Impuestoretenido)
                  {
                      
                      Impuestoretenido = value;
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
          public decimal TASAIMPUESTO
          {
              get{ return Tasaimpuesto; }
              set
              {
                  if(value!=Tasaimpuesto)
                  {
                      
                      Tasaimpuesto = value;
                  }
              }
          }          
          public decimal TASARETIMPUESTO
          {
              get{ return Tasaretimpuesto; }
              set
              {
                  if(value!=Tasaretimpuesto)
                  {
                      
                      Tasaretimpuesto = value;
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
          public string OBS
          {
              get{ return Obs.ToString().Trim(); }
              set
              {
                  if(value!=Obs)
                  {
                      
                      Obs = value;
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
        public string COMPONENTE
          {
              get{ return Componente.ToString().Trim(); ; }
              set
              {
                  if(value!=Componente)
                  {
                      
                      Componente = value;
                  }
              }
          }          
          public bool TIENECOMPONENTES
          {
              get{ return Tienecomponentes; }
              set
              {
                  if(value!=Tienecomponentes)
                  {
                      
                      Tienecomponentes = value;
                  }
              }
          }
          public Int16 IDTIPODOCGENERAR
        {
            get { return IdTipoDocGenerar; }
            set
            {
                if(value !=IdTipoDocGenerar)
                {
                    
                    IdTipoDocGenerar = value;
                }
            }
        }
      }
}
