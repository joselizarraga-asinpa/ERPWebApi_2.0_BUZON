using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{
      
      //Clase creada por generador de código
      
      public class TipoDocumento: IEntidadBase
      {
        private Int16 Id;
        private Int16 Idpincliente;
        private Int16 Iddocaplicar;
        private Int16 Idgrupotipodoc;
        private Int16 IdTipoTimbrado;
        private string Nombretipodoc;
        private string Abreviatura;
        private bool FolioManual;
        private string Folios;
        private string Cliprov;
        private string Ingreso;
        private bool Fiscal;
        private bool FiscalCancelaDocOrigen;
        private bool Credito;
        private bool Manejadinero;
        private bool Descuentos;
        private bool Factorutilidad;
        private decimal MultiploFactorutilidad;
        private bool Desglozarimpuestos;
        private bool Validaotrotipodoc;
        private bool Apartainventario;
        private bool Inventario;
        private string Entrada;
        private bool Conceptos;
        private bool Recurrente;
        private bool Modificarfecha;
        private bool Global;
        private bool Aprovechamiento;
        private string Tipocosteo;
        private string ValidaExistencia;
        private string ValidaComponentes;
        private decimal MultiploRedondeo;
        private bool ModificarCliProv;
        private string Serie;
        private string RedondeoDocFuente;
        private string TipoEdicion;
        private Int16 ModalidadPrecios;
        private bool ModificaPrecios;
        private bool TipoCambioUnico;
        private string Obs;
        private string VistaDefaultProductos;
        private string ImpresionDefault;
        private bool MostrarId;


        //public PinCliente PinCliente { get; set;}
        //public GrupoTipoDoc GrupoTipoDoc { get; set;}
        //public List<Documento> Documento { get; set; }
        //public List<TipoDocEmpresa> TipoDocEmpresa { get; set; }
        //public List<TipoDocGenerar> TipoDocGenerar { get; set; }
        //public List<TipoDocMetodoPago> TipoDocMetodoPago { get; set; }
        //public List<TipoDocMoneda> TipoDocMoneda { get; set; }
        //public List<TipoDocTipoPersonal> TipoDocTipoPersonal { get; set; }

        //Constructor
        public TipoDocumento()
        {
            Id = 0; 
            Idpincliente = 0; 
            Iddocaplicar = 0; 
            Idgrupotipodoc = 0;
            IdTipoTimbrado = 0;
            Nombretipodoc = ""; 
            Abreviatura = "";
            FolioManual = false;
            Folios = ""; 
            Cliprov = ""; 
            Ingreso = ""; 
            Fiscal = false;
            FiscalCancelaDocOrigen = false;
            Credito = false; 
            Manejadinero = false; 
            Descuentos = false; 
            Factorutilidad = false;
            MultiploFactorutilidad = 0;
            Desglozarimpuestos = false; 
            Validaotrotipodoc = false; 
            Apartainventario = false; 
            Inventario = false; 
            Entrada = ""; 
            Conceptos = false; 
            Recurrente = false; 
            Modificarfecha = false; 
            Global = false;
            Aprovechamiento = false;
            Tipocosteo = "";
            ValidaExistencia = "";
            ValidaComponentes = "";
            MultiploRedondeo = 0;
            ModificarCliProv = false;
            Serie = "";
            RedondeoDocFuente = "";
            TipoEdicion = "";
            ModalidadPrecios = 0;
            ModificaPrecios = true;
            TipoCambioUnico = false;
            Obs = "";
            VistaDefaultProductos = "P";
            ImpresionDefault = "";
            MostrarId = true;

            //PinCliente = new PinCliente();
            //GrupoTipoDoc = new GrupoTipoDoc();
            //Documento = new List<Documento>(); 
            //TipoDocEmpresa = new List<TipoDocEmpresa>(); 
            //TipoDocGenerar = new List<TipoDocGenerar>(); 
            //TipoDocMetodoPago = new List<TipoDocMetodoPago>(); 
            //TipoDocMoneda = new List<TipoDocMoneda>(); 
            //TipoDocTipoPersonal = new List<TipoDocTipoPersonal>(); 
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
          public Int16 IDDOCAPLICAR
          {
              get{ return Iddocaplicar; }
              set
              {
                  if(value!=Iddocaplicar)
                  {
                      
                      Iddocaplicar = value;
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
        [DataMember(IsRequired = true)]
        public Int16 IDTIPOTIMBRADO
        {
            get { return IdTipoTimbrado; }
            set
            {
                if (value != IdTipoTimbrado)
                {

                    IdTipoTimbrado = value;
                }
            }
        }
        [DataMember(IsRequired = true)]
          public string NOMBRETIPODOC
          {
              get{ return Nombretipodoc.ToString().Trim(); }
              set
              {
                  if(value!=Nombretipodoc)
                  {
                      
                      Nombretipodoc = value;
                  }
              }
          }
          public string ABREVIATURA
          {
              get{ return Abreviatura.ToString().Trim(); }
              set
              {
                  if(value!=Abreviatura)
                  {
                      
                      Abreviatura = value;
                  }
              }
          }
            [DataMember(IsRequired = true)]
            public bool FOLIOMANUAL
            {
                get { return FolioManual; }
                set
                {
                    if (value != FolioManual)
                    {
                        
                        FolioManual = value;
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
        public bool FISCALCANCELADOCORIGEN
        {
            get { return FiscalCancelaDocOrigen; }
            set
            {
                if (value != FiscalCancelaDocOrigen)
                {

                    FiscalCancelaDocOrigen = value;
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
          public decimal MULTIPLOFACTORUTILIDAD
        {
            get { return MultiploFactorutilidad; }
            set
            {
                MultiploFactorutilidad = value;
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
        public bool APROVECHAMIENTO
        {
            get { return Aprovechamiento; }
            set
            {
                if (value != Aprovechamiento)
                {
                    
                    Aprovechamiento = value;
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
        public string VALIDAEXISTENCIA
        {
            get { return ValidaExistencia.ToString().Trim(); }
            set
            {
                if (value != ValidaExistencia)
                {
                    
                    ValidaExistencia = value;
                }
            }
        }
        public string VALIDACOMPONENTES
        {
            get { return ValidaComponentes.ToString().Trim(); }
            set
            {
                if (value != ValidaComponentes)
                {
                    
                    ValidaComponentes = value;
                }
            }
        }
        public decimal MULTIPLOREDONDEO
        {
            get { return MultiploRedondeo; }
            set
            {
                if (value != MultiploRedondeo)
                {
                    
                    MultiploRedondeo = value;
                }
            }
        }

        public bool MODIFICARCLIPROV
        {
            get { return ModificarCliProv; }
            set
            {
                if(value != ModificarCliProv)
                {
                    ModificarCliProv = value;
                }
            }
        }

        public string SERIE
        {
            get { return Serie; }
            set
            {
                if(value != Serie)
                {
                    Serie = value;
                }
            }
        }

        public string REDONDEODOCFUENTE
        {
            get { return RedondeoDocFuente; }
            set
            {
                if (value != RedondeoDocFuente)
                {
                    RedondeoDocFuente = value;
                }
            }
        }

        public string TIPOEDICION
        {
            get { return TipoEdicion; }
            set
            {
                if (value != TipoEdicion)
                {
                    TipoEdicion = value;
                }
            }
        }
        public Int16 MODALIDADPRECIOS
        {
            get { return ModalidadPrecios; }
            set
            {
                if (value != ModalidadPrecios)
                {
                    ModalidadPrecios = value;
                }
            }
        }

        public bool MODIFICAPRECIOS
        {
            get { return ModificaPrecios; }
            set
            {
                if (value != ModificaPrecios)
                {
                    ModificaPrecios = value;
                }
            }
        }

        public bool TIPOCAMBIOUNICO
        {
            get { return TipoCambioUnico; }
            set
            {
                if (value != TipoCambioUnico)
                {
                    TipoCambioUnico = value;
                }
            }
        }

        public string OBS
        {
            get { return Obs; }
            set
            {
                if (value != Obs)
                {
                    Obs = value;
                }
            }
        }

        public string VISTADEFAULTPRODUCTOS
        {
            get { return VistaDefaultProductos; }
            set
            {
                if (value != VistaDefaultProductos)
                {
                    VistaDefaultProductos = value;
                }
            }
        }

        public string IMPRESIONDEFAULT
        {
            get { return ImpresionDefault; }
            set
            {
                if (value != ImpresionDefault)
                {
                    ImpresionDefault = value;
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
