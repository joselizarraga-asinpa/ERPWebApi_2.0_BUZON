using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{
      
      //Clase creada por generador de código
      
      public class Documento: IEntidadBase
      {
          private Int64 Id;
          private Int16 Idtipodocumento;
          private Int64 Iddocfuente;
          private Int32 Idcliprov;
          private Int16 Idsucursal;
          private Int16 Idalmacen;
          private Int16 Idpersonal;
          private Int16 Idmoneda;
          private Int64 Iddocfiscal;
          private string Folio;
          private DateTime Fecha;
          private DateTime Cancelado;
          private DateTime Cerrado;
          private decimal Tipocambio;
          private decimal Descuento;
          private decimal Factorutilidad;
          private bool Credito;
          private string Obs;
          private string NoDocumento;
          private DateTime FeDocumento;
          private string DirigidoA;
          private string Destino;
          private bool MostrarId;
          
          //public TipoDocumento TipoDocumento { get; set;}
          //public CliProv CliProv { get; set;}
          //public Sucursal Sucursal { get; set;}
          //public Personal Personal { get; set;}
          //public Moneda Moneda { get; set;}
          public List<DocDetalle> lDocDetalle { get; set; }
        
          public virtual List<Existencia> lExistencia { get; set; }
        //public List<DocInventario> DocInventario { get; set; }
        //public List<MovCaja> MovCaja { get; set; }
        //public List<MovCajaDetalle> MovCajaDetalle { get; set; }

        //Constructor
        public Documento()
          {
                Id = 0; 
                Idtipodocumento = 0; 
                Iddocfuente = 0; 
                Idcliprov = 0; 
                Idsucursal = 0;
                Idalmacen = 0;
                Idpersonal = 0; 
                Idmoneda = 0; 
                Iddocfiscal = 0; 
                Folio = ""; 
                Fecha = System.DateTime.Today;
                Cancelado = System.DateTime.Today;
                Cerrado = System.DateTime.Today;
                FeDocumento = System.DateTime.Today;
                Tipocambio = 0; 
                Descuento = 0; 
                Factorutilidad = 0; 
                Credito = false; 
                Obs = "";            
                NoDocumento = "";
                DirigidoA = "";
                Destino = "";
                MostrarId = true;

              //TipoDocumento = new TipoDocumento();
              //CliProv = new CliProv();
              //Sucursal = new Sucursal();
              //Personal = new Personal();
              //Moneda = new Moneda();
              lDocDetalle = new List<DocDetalle>();
              lExistencia = new List<Existencia>();
            //DocInventario = new List<DocInventario>(); 
            //MovCaja = new List<MovCaja>(); 
            //MovCajaDetalle = new List<MovCajaDetalle>(); 
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
          public Int16 IDTIPODOCUMENTO
          {
              get{ return Idtipodocumento; }
              set
              {
                  if(value!=Idtipodocumento)
                  {
                      
                      Idtipodocumento = value;
                  }
              }
          }
          public Int64 IDDOCFUENTE
          {
              get{ return Iddocfuente; }
              set
              {
                  if(value!=Iddocfuente)
                  {
                      
                      Iddocfuente = value;
                  }
              }
          }
          public Int32 IDCLIPROV
          {
              get{ return Idcliprov; }
              set
              {
                  if(value!=Idcliprov)
                  {
                      
                      Idcliprov = value;
                  }
              }
          }
          [DataMember(IsRequired = true)]
          public Int16 IDSUCURSAL
          {
              get{ return Idsucursal; }
              set
              {
                  if(value!=Idsucursal)
                  {
                      
                      Idsucursal = value;
                  }
              }
          }
        [DataMember(IsRequired = true)]
        public Int16 IDALMACEN
        {
            get { return Idalmacen; }
            set
            {
                if (value != Idalmacen)
                {
                    
                    Idalmacen = value;
                }
            }
        }
        [DataMember(IsRequired = true)]
          public Int16 IDPERSONAL
          {
              get{ return Idpersonal; }
              set
              {
                  if(value!=Idpersonal)
                  {
                      
                      Idpersonal = value;
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
          public Int64 IDDOCFISCAL
          {
              get{ return Iddocfiscal; }
              set
              {
                  if(value!=Iddocfiscal)
                  {
                      
                      Iddocfiscal = value;
                  }
              }
          }
          [DataMember(IsRequired = true)]
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
          [DataMember(IsRequired = true)]
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
          public DateTime CANCELADO
          {
              get{ return Cancelado; }
              set
              {
                  if (value != null)
                  {
                      if(value!=Cancelado)
                      {
                          
                          Cancelado = value;
                      }
                  }
              }
          }
          public DateTime CERRADO
          {
              get{ return Cerrado; }
              set
              {
                  if (value != null)
                  {
                      if(value!=Cerrado)
                      {
                          
                          Cerrado = value;
                      }
                  }
              }
          }
          [DataMember(IsRequired = true)]
          public decimal TIPOCAMBIO
          {
              get{ return Tipocambio; }
              set
              {
                  if(value!=Tipocambio)
                  {
                      
                      Tipocambio = value;
                  }
              }
          }
          [DataMember(IsRequired = true)]
          public decimal DESCUENTO
          {
              get{ return Descuento; }
              set
              {
                  if(value!=Descuento)
                  {
                      
                      Descuento = value;
                  }
              }
          }
          [DataMember(IsRequired = true)]
          public decimal FACTORUTILIDAD
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
        public string NODOCUMENTO
        {
            get { return NoDocumento.ToString().Trim(); }
            set
            {
                if (value != NoDocumento)
                {
                    
                    NoDocumento = value;
                }
            }
        }

        [DataMember(IsRequired = true)]
        public DateTime FEDOCUMENTO
        {
            get { return FeDocumento; }
            set
            {
                if (value != null)
                {
                    if (value != FeDocumento)
                    {
                        
                        FeDocumento = value;
                    }
                }
            }
        }
        public string DIRIGIDOA
        {
            get { return DirigidoA.ToString().Trim(); }
            set
            {
                if (value != DirigidoA)
                {
                    
                    DirigidoA = value;
                }
            }
        }
        public string DESTINO
        {
            get { return Destino.ToString().Trim(); }
            set
            {
                if (value != Destino)
                {
                    
                    Destino = value;
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
