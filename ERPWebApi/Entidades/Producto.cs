using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{
      
      //Clase creada por generador de código
      
      public class Producto: IEntidadBase
      {
        private Int32 Id;
        private Int16 Idpincliente;
        private Int16 Idtipoproducto;
        private Int16 Idtipounidad;
        private Int16 Idimpuesto;
        private Int16 IdimpuestoArancel;
        private Int16 Idempresa;
        private Int16 Idstatus;
        private Int32 Idcliprov;
        private Int16 IdMoneda;
        private Int32 Idformula;        
        private string Nombreproducto;
        private string Codigo;
        private decimal Costo;          
        private decimal Publico;
        private decimal Margen;
        private decimal Neto;
        private decimal Unidad;
        private string Infotecnica;
        private Int16 Cajacolectiva;
        private bool CambiaNombreDoc;
        private bool Manejalote;
        private bool Manejacaducidad;
        private bool RedondearAprovechamiento;
        private string TipoCosto;
        private string TipoPrecioVenta;        
        private String ExpresionFormula;
        private bool ImpuestosComponentes;
        private bool MostrarId;
        private string ClaveSat;
        private string ClasClienteComp;
        private bool ComponenteEntrega;
        private bool Inventario;

        //public PinCliente PinCliente { get; set;}
        //public TipoProducto TipoProducto { get; set;}
        //public TipoUnidad TipoUnidad { get; set;}
        //public Impuesto Impuesto { get; set;}
        //public Empresa Empresa { get; set;}
        //public Status Status { get; set;}
        //public CliProv CliProv { get; set;}
        //public List<Existencia> Existencia { get; set; }
        //public List<ProductoClas> ProductoClas { get; set; }
        //public List<ProductoCodigo> ProductoCodigo { get; set; }
        //public List<ProductoPaquete> ProductoPaquete { get; set; }

        //Constructor
        public Producto()
          {
            Id = 0; 
            Idpincliente = 0; 
            Idtipoproducto = 0; 
            Idtipounidad = 0; 
            Idimpuesto = 0;
            IdimpuestoArancel = 0;
            Idempresa = 0; 
            Idstatus = 0; 
            Idcliprov = 0;
            IdMoneda = 0;
            Nombreproducto = "";
            Codigo = "";
            Costo = 0;               
            Publico = 0; 
            Margen = 0; 
            Neto = 0; 
            Unidad = 0; 
            Infotecnica = ""; 
            Cajacolectiva = 0;
            CambiaNombreDoc = false;
            Manejalote = false; 
            Manejacaducidad = false;
            RedondearAprovechamiento = false;
            TipoCosto = "U";
            TipoPrecioVenta = "C";
            Idformula = 0;
            ExpresionFormula = "";
            ImpuestosComponentes = false;
            MostrarId = true;
            ClaveSat = "";
            ClasClienteComp = "";
            ComponenteEntrega = false;
            Inventario = false;

        //PinCliente = new PinCliente();
        //TipoProducto = new TipoProducto();
        //TipoUnidad = new TipoUnidad();
        //Impuesto = new Impuesto();
        //Empresa = new Empresa();
        //Status = new Status();
        //CliProv = new CliProv();
        //Existencia = new List<Existencia>(); 
        //ProductoClas = new List<ProductoClas>(); 
        //ProductoCodigo = new List<ProductoCodigo>(); 
        //ProductoPaquete = new List<ProductoPaquete>(); 
        }
          
          public Int32 ID
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
          public Int16 IDTIPOPRODUCTO
          {
              get{ return Idtipoproducto; }
              set
              {
                  if(value!=Idtipoproducto)
                  {
                      
                      Idtipoproducto = value;
                  }
              }
          }
          public Int16 IDTIPOUNIDAD
          {
              get{ return Idtipounidad; }
              set
              {
                  if(value!=Idtipounidad)
                  {
                      
                      Idtipounidad = value;
                  }
              }
          }
          [DataMember(IsRequired = true)]
          public Int16 IDIMPUESTO
          {
              get{ return Idimpuesto; }
              set
              {
                  if(value!=Idimpuesto)
                  {
                      
                      Idimpuesto = value;
                  }
              }
          }
        public Int16 IDIMPUESTOARANCEL
        {
            get { return IdimpuestoArancel; }
            set
            {
                if (value != IdimpuestoArancel)
                {

                    IdimpuestoArancel = value;
                }
            }
        }
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
          public Int16 IDSTATUS
          {
              get{ return Idstatus; }
              set
              {
                  if(value!=Idstatus)
                  {
                      
                      Idstatus = value;
                  }
              }
          }
          [DataMember(IsRequired = true)]
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
        public Int16 IDMONEDA
        {
            get { return IdMoneda; }
            set
            {
                if (value != IdMoneda)
                {

                    IdMoneda = value;
                }
            }
        }
        [DataMember(IsRequired = true)]
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
        public string CODIGO
        {
            get
            {
                if (Codigo != null)
                    return Codigo.ToString().Trim();
                else
                    return "";
            }
            set
            {
                if (value != Codigo)
                {

                    Codigo = value;
                }
            }
        }
        [DataMember(IsRequired = true)]
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
          [DataMember(IsRequired = true)]
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
          public decimal MARGEN
          {
              get{ return Margen; }
              set
              {
                  if(value!=Margen)
                  {
                      
                      Margen = value;
                  }
              }
          }
          public decimal NETO
          {
              get{ return Neto; }
              set
              {
                  if(value!=Neto)
                  {
                      
                      Neto = value;
                  }
              }
          }
          [DataMember(IsRequired = true)]
          public decimal UNIDAD
          {
              get{ return Unidad; }
              set
              {
                  if(value!=Unidad)
                  {
                      
                      Unidad = value;
                  }
              }
          }
          [DataMember(IsRequired = true)]
          public string INFOTECNICA
          {
              get{ return Infotecnica.ToString().Trim(); }
              set
              {
                  if(value!=Infotecnica)
                  {
                      
                      Infotecnica = value;
                  }
              }
          }
          [DataMember(IsRequired = true)]
          public Int16 CAJACOLECTIVA
          {
              get{ return Cajacolectiva; }
              set
              {
                  if(value!=Cajacolectiva)
                  {
                      
                      Cajacolectiva = value;
                  }
              }
          }
        [DataMember(IsRequired = true)]
        public bool CAMBIANOMBREDOC
        {
            get { return CambiaNombreDoc; }
            set
            {
                if (value != CambiaNombreDoc)
                {
                    
                    CambiaNombreDoc = value;
                }
            }
        }
        [DataMember(IsRequired = true)]
          public bool MANEJALOTE
          {
              get{ return Manejalote; }
              set
              {
                  if(value!=Manejalote)
                  {
                      
                      Manejalote = value;
                  }
              }
          }
          [DataMember(IsRequired = true)]
          public bool MANEJACADUCIDAD
          {
              get{ return Manejacaducidad; }
              set
              {
                  if(value!=Manejacaducidad)
                  {
                      
                      Manejacaducidad = value;
                  }
              }
          }
        public bool REDONDEARAPROVECHAMIENTO
        {
            get { return RedondearAprovechamiento; }
            set
            {
                if (value != RedondearAprovechamiento)
                {
                    
                    RedondearAprovechamiento = value;
                }
            }
        }
        [DataMember(IsRequired = true)]
        public string TIPOCOSTO
        {
            get { return TipoCosto.ToString().Trim(); }
            set
            {
                if (value != TipoCosto)
                {
                    
                    TipoCosto = value;
                }
            }
        }
        [DataMember(IsRequired = true)]
        public string TIPOPRECIOVENTA
        {
            get { return TipoPrecioVenta.ToString().Trim(); }
            set
            {
                if (value != TipoPrecioVenta)
                {
                    
                    TipoPrecioVenta = value;
                }
            }
        }

        [DataMember(IsRequired = true)]
        public Int32 IDFORMULA
        {
            get { return Idformula; }
            set
            {
                if (value != Idformula)
                {
                    
                    Idformula = value;
                }
            }
        }
        public string EXPRESIONFORMULA
        {
            get { return ExpresionFormula; }
            set
            {
                if (value != ExpresionFormula)
                {
                    
                    ExpresionFormula = value;
                }
            }
        }
        public bool IMPUESTOSCOMPONENTES
        {
            get { return ImpuestosComponentes; }
            set
            {
                if (value != ImpuestosComponentes)
                {

                    ImpuestosComponentes = value;
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

        public string CLAVESAT
        {
            get { return ClaveSat; }
            set
            {
                if (value != ClaveSat)
                {

                    ClaveSat = value;
                }
            }
        }

        public string CLASCLIENTECOMP
        {
            get { return ClasClienteComp; }
            set
            {
                if (value != ClasClienteComp)
                {

                    ClasClienteComp = value;
                }
            }
        }

        public bool COMPONENTEENTREGA
        {
            get { return ComponenteEntrega; }
            set
            {
                if (value != ComponenteEntrega)
                {

                    ComponenteEntrega = value;
                }
            }
        }
        public bool INVENTARIO
        {
            get { return Inventario; }
            set
            {
                if (value != Inventario)
                {
                    Inventario = value;
                }
            }
        }
    }
}
