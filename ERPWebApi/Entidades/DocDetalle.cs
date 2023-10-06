using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{
      
      //Clase creada por generador de código
      
      public class DocDetalle: IEntidadBase
      {
        private Int64 Id;
        private Int64 Iddocumento;
        private Int64 Iddocaplicado;
        private Int64 Idexistencia;          
        private Int32 Idproducto;
        private Int64 Iddocdetallepadre;
        private Int64 Iddocdetallefuente;
        private Int16 Registro;
        private DateTime Fecha;
        private decimal Cantidad;
        private decimal CantidadAprovechada;
        private decimal Factor;
        private decimal Descuento;        
        private decimal Porcentaje;
        private bool PorcentajeManual;
        private decimal PorcentajeAprovechado;
        private decimal Costo;
        private bool CostoManual;
        private decimal Unitario;
        private decimal Publico;
        private decimal Ajuste;
        private decimal Tasaimpuesto;
        private decimal Tasaretimpuesto;
        private decimal TasaimpuestoArancel;
        private decimal Numextra1;
        private decimal Numextra2;
        private decimal Numextra3;
        private string Numextra1Alias;
        private string Numextra2Alias;
        private string Numextra3Alias;
        private string Obs;
        private string Comentarios;
        private bool Componentes;
        private bool MostrarId;

        [DataMember(IsRequired = true)]
        public virtual List<ClasDet> lClasDet { get; set; }
        
        [DataMember(IsRequired = true)]
        public virtual List<DocDetalle> lDocDetalle { get; set; }

        [DataMember(IsRequired = true)]
        public virtual List<Existencia> lExistencia { get; set; }

        //public Documento Documento { get; set;}
        //public Existencia Existencia { get; set;}
        //public Producto Producto { get; set;}
        //public List<DocDetalleClas> DocDetalleClas { get; set; }

        //Constructor
        public DocDetalle()
        {
            MasterDetailKey = "@IdDocDetallePadre";

            Id = 0; 
            Iddocumento = 0; 
            Iddocaplicado = 0; 
            Idexistencia = 0;               
            Idproducto = 0;
            Iddocdetallepadre = 0;
            Iddocdetallefuente = 0;
            Registro = 0;
            Fecha = DateTime.Now;
            Cantidad = 0;
            CantidadAprovechada = 0;
            Factor = 0; 
            Descuento = 0; 
            Porcentaje = 0;
            PorcentajeManual = false;
            PorcentajeAprovechado = 0;
            Costo = 0;
            CostoManual = false;
            Unitario = 0; 
            Publico = 0;
            Ajuste = 0;
            Tasaimpuesto = 0; 
            Tasaretimpuesto = 0;
            TasaimpuestoArancel = 0;
            Numextra1 = 0; 
            Numextra2 = 0; 
            Numextra3 = 0;
            Numextra1Alias = "";
            Numextra2Alias = "";
            Numextra3Alias = "";
            Obs = "";
            Comentarios = "";
            Componentes = false;
            MostrarId = true;

            lClasDet = new List<ClasDet>();
            lExistencia = new List<Existencia>();

              //Documento = new Documento();
              //Existencia = new Existencia();
              //Producto = new Producto();
              //DocDetalleClas = new List<DocDetalleClas>(); 
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
          public Int64 IDDOCDETALLEPADRE
          {
              get{ return Iddocdetallepadre; }
              set
              {
                  if(value!= Iddocdetallepadre)
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
        public Int16 REGISTRO
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
        public DateTime FECHA
        {
            get { return Fecha; }
            set
            {
                if(value != Fecha)
                {
                    Fecha = value;
                }
            }
        }
        [DataMember(IsRequired = true)]
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
            public decimal CANTIDADAPROVECHADA
            {
                get { return CantidadAprovechada; }
                set
                {
                    if (value != CantidadAprovechada)
                    {
                        
                    CantidadAprovechada = value;
                    }
                }
            }
        [DataMember(IsRequired = true)]
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
        public decimal PORCENTAJEAPROVECHADO
        {
            get { return PorcentajeAprovechado; }
            set
            {
                if (value != PorcentajeAprovechado)
                {
                    
                    PorcentajeAprovechado = value;
                }
            }
        }
        [DataMember(IsRequired = true)]
        public bool PORCENTAJEMANUAL
        {
            get { return PorcentajeManual; }
            set
            {
                if (value != PorcentajeManual)
                {
                    
                    PorcentajeManual = value;
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
        public bool COSTOMANUAL
        {
            get { return CostoManual; }
            set
            {
                if (value != CostoManual)
                {
                    
                    CostoManual = value;
                }
            }
        }
        [DataMember(IsRequired = true)]
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
        [DataMember(IsRequired = true)]
        public decimal AJUSTE
        {
            get { return Ajuste; }
            set
            {
                if (value != Ajuste)
                {
                    
                    Ajuste = value;
                }
            }
        }
        [DataMember(IsRequired = true)]
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
          [DataMember(IsRequired = true)]
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
        public decimal TASAIMPUESTOARANCEL
        {
            get { return TasaimpuestoArancel; }
            set
            {
                if (value != TasaimpuestoArancel)
                {

                    TasaimpuestoArancel = value;
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
            get { return Numextra1Alias.ToString().Trim(); }
            set
            {
                if (value != Numextra1Alias)
                {
                    
                    Numextra1Alias = value;
                }
            }
        }
        public string NUMEXTRA2ALIAS
        {
            get { return Numextra2Alias.ToString().Trim(); }
            set
            {
                if (value != Numextra2Alias)
                {
                    
                    Numextra2Alias = value;
                }
            }
        }
        public string NUMEXTRA3ALIAS
        {
            get { return Numextra3Alias.ToString().Trim(); }
            set
            {
                if (value != Numextra3Alias)
                {
                    
                    Numextra3Alias = value;
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
        [DataMember(IsRequired = true)]
        public bool COMPONENTES
        {
            get { return Componentes; }
            set
            {
                if (value != Componentes)
                {
                    
                    Componentes = value;
                }
            }
        }
        [DataMember(IsRequired = true)]
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
