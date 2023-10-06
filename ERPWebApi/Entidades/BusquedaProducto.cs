using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{
      
      //Clase creada por generador de código
      
      public class BusquedaProducto: IEntidadBase
      {
        private Int16 Id;
        private Int16 Idpincliente;
        private Int16 Idempresa;
        private string Busqueda;
        private Int16 Pagina;
        private string Clasificaciones;
        private Int32 IdProducto;
        private string Nombreproducto;
        private string Tipounidad;
        private string Tipoproducto;
        private bool Checkestatus;
        private string Estatus;
        private string Infotecnica;
        private decimal Publico;
        private string Paginas;
        private Int16 TotalPaginas;
        private bool Componentes;
        private Int16 NumReg;




        //Constructor
        public BusquedaProducto()
        {
            Id = 0;
            Idpincliente = 0;
            Idempresa = 0;
            Busqueda = "";
            Pagina = 0;
            Clasificaciones = "";
            IdProducto = 0;
            Nombreproducto = "";
            Tipounidad = "";
            Tipoproducto = "";
            Checkestatus = false;
            Estatus = "";
            Infotecnica = "";
            Publico = 0;
            Paginas = "";
            Componentes = true;
            NumReg = 20;
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
          [DataMember(IsRequired = true)]
          public string CLASIFICACIONES
          {
              get{ return Clasificaciones.ToString().Trim(); }
              set
              {
                  if(value!=Clasificaciones)
                  {
                      
                      Clasificaciones = value;
                  }
              }
          }
        public Int32 IDPRODUCTO
        {
            get { return IdProducto; }
            set
            {
                if (value != IdProducto)
                {
                    
                    IdProducto = value;
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
          public string TIPOUNIDAD
          {
              get{ return Tipounidad.ToString().Trim(); }
              set
              {
                  if(value!=Tipounidad)
                  {
                      
                      Tipounidad = value;
                  }
              }
          }          
          public string TIPOPRODUCTO
          {
              get{ return Tipoproducto.ToString().Trim(); }
              set
              {
                  if(value!=Tipoproducto)
                  {
                      
                      Tipoproducto = value;
                  }
              }
          }          
          public bool CHECKESTATUS
          {
              get{ return Checkestatus; }
              set
              {
                  if(value!=Checkestatus)
                  {
                      
                      Checkestatus = value;
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
        public decimal PUBLICO
        {
            get { return Publico; }
            set
            {
                if (value != Publico)
                {

                    Publico = value;
                }
            }
        }
        public string PAGINAS
        {
            get { return Paginas.ToString().Trim(); }
            set
            {
                if (value != Paginas)
                {
                    
                    Paginas = value;
                }
            }
        }
        public Int16 TOTALPAGINAS
        {
            get { return TotalPaginas; }
            set
            {
                if (value != TotalPaginas)
                {
                    
                    TotalPaginas = value;
                }
            }
        }
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
        public Int16 NUMREG
        {
            get { return NumReg; }
            set
            {
                if (value != NumReg)
                {

                    NumReg = value;
                }
            }
        }
    }
}
