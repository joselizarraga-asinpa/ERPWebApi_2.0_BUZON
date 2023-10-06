using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{
      
      //Clase creada por generador de código
      
      public class BusquedaDocumento: IEntidadBase
      {
        private Int16 Id;
        private Int16 Idpincliente;
        private Int16 Idempresa;
        private Int16 Idsucursal;
        private Int64 Iddocumento;
        private string TipoDocumento;
        private string Busqueda;
        private string CliProv;
        private string Folio;
        private string FolioFiscal;
        private decimal Total;
        private string Moneda;
        private DateTime Fecha;        
        private string Almacen;
        private string Estatus;
        private string EstatusFiscal;
        private string NoDocumento;
        private DateTime Desde;
        private DateTime Hasta;
        private Int16 Pagina;
        private string Paginas;
        private Int16 TotalPaginas;
        private Int64 IddocumentoOrigen;
        private Int64 IdDocFiscal;
        private string FolioOrigen;
        private string uuid;
        private string Orden;
        private string Asc;


        //public PinCliente PinCliente { get; set;}
        //public Empresa Empresa { get; set;}
        //public Sucursal Sucursal { get; set;}
        //public Documento Documento { get; set;}

        //Constructor
        public BusquedaDocumento()
        {
            Id = 0; 
            Idpincliente = 0; 
            Idempresa = 0; 
            Idsucursal = 0; 
            Iddocumento = 0;
            TipoDocumento = "";
            Busqueda = "";
            CliProv = "";
            Folio = "";
            FolioFiscal = "";
            Fecha = System.DateTime.Today;
            Total = 0;
            Moneda = "";
            Almacen = "";
            Estatus = "";
            EstatusFiscal = "";
            NoDocumento = "";
            Desde = System.DateTime.Today;
            Hasta = System.DateTime.Today;
            Pagina = 0; 
            Paginas = ""; 
            TotalPaginas = 0;
            IddocumentoOrigen = 0;
            IdDocFiscal = 0;
            FolioOrigen = "";
            uuid = "";
            Orden = "";
            Asc = "";

            //PinCliente = new PinCliente();
            //Empresa = new Empresa();
            //Sucursal = new Sucursal();
            //Documento = new Documento();
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
          public Int16 IDEMPRESA
          {
              get{ return Idempresa; }
              set
              {
                  if(value!=Idempresa)
                  {
                      
                      Idempresa = value;
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
        public string TIPODOCUMENTO
        {
            get { return TipoDocumento.ToString().Trim(); }
            set
            {
                if (value != TipoDocumento)
                {
                    
                    TipoDocumento = value;
                }
            }
        }        
          public string BUSQUEDA
          {
              get{ return Busqueda.ToString().Trim(); }
              set
              {
                  if(value!=Busqueda)
                  {
                      
                      Busqueda = value;
                  }
              }
          }
        public string CLIPROV
        {
            get { return CliProv.ToString().Trim(); }
            set
            {
                if (value != CliProv)
                {
                    
                    CliProv = value;
                }
            }
        }
        [DataMember(IsRequired = true)]
        public string FOLIO
        {
            get { return Folio.ToString().Trim(); }
            set
            {
                if (value != Folio)
                {
                    
                    Folio = value;
                }
            }
        }
        public string FOLIOFISCAL
        {
            get { return FolioFiscal.ToString().Trim(); }
            set
            {
                if (value != FolioFiscal)
                {
                    FolioFiscal = value;
                }
            }
        }
        [DataMember(IsRequired = true)]
        public decimal TOTAL
        {
            get { return Total; }
            set
            {
                Total = value;
            }
        }
        [DataMember(IsRequired = true)]
        public string MONEDA
        {
            get { return Moneda; }
            set
            {
                Moneda = value;
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
        
        public string ALMACEN
        {
            get { return Almacen.ToString().Trim(); }
            set
            {
                if (value != Almacen)
                {
                    
                    Almacen = value;
                }
            }
        }
        public string ESTATUS
          {
              get{ return Estatus.ToString().Trim(); }
              set
              {
                  if(value!=Estatus)
                  {
                      
                      Estatus = value;
                  }
              }
          }
        public string ESTATUSFISCAL
        {
            get { return EstatusFiscal.ToString().Trim(); }
            set
            {
                if (value != EstatusFiscal)
                {
                    EstatusFiscal = value;
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
          public DateTime DESDE
          {
              get{ return Desde; }
              set
              {
                  if (value != null)
                  {
                      if(value!=Desde)
                      {
                          
                          Desde = value;
                      }
                  }
              }
          }
          [DataMember(IsRequired = true)]
          public DateTime HASTA
          {
              get{ return Hasta; }
              set
              {
                  if (value != null)
                  {
                      if(value!=Hasta)
                      {
                          
                          Hasta = value;
                      }
                  }
              }
          }
          [DataMember(IsRequired = true)]
          public Int16 PAGINA
          {
              get{ return Pagina; }
              set
              {
                  if(value!=Pagina)
                  {
                      
                      Pagina = value;
                  }
              }
          }          
          public string PAGINAS
          {
              get{ return Paginas.ToString().Trim(); }
              set
              {
                  if(value!=Paginas)
                  {
                      
                      Paginas = value;
                  }
              }
          }          
          public Int16 TOTALPAGINAS
          {
              get{ return TotalPaginas; }
              set
              {
                  if(value!= TotalPaginas)
                  {
                      
                    TotalPaginas = value;
                  }
              }
          }
        public Int64 IDDOCUMENTOORIGEN
        {
            get { return IddocumentoOrigen; }
            set
            {
                if (value != IddocumentoOrigen)
                {
                    
                    IddocumentoOrigen = value;
                }
            }
        }
        public Int64 IDDOCFISCAL
        {
            get { return IdDocFiscal; }
            set
            {
                if (value != IdDocFiscal)
                {
                    IdDocFiscal = value;
                }
            }
        }
        public string FOLIOORIGEN
        {
            get { return FolioOrigen.ToString().Trim(); }
            set
            {
                if (value != FolioOrigen)
                {
                    
                    FolioOrigen = value;
                }
            }
        }
        public string UUID
        {
            get { return uuid.ToString().Trim(); }
            set
            {
                if (value != uuid)
                {
                    uuid = value;
                }
            }
        }
        public string ORDEN
        {
            get { return Orden.ToString().Trim(); }
            set
            {
                if (value != Orden)
                {
                    Orden = value;
                }
            }
        }
        public string ASC
        {
            get { return Asc.ToString().Trim(); }
            set
            {
                if (value != Asc)
                {
                    Asc = value;
                }
            }
        }
    }
}
