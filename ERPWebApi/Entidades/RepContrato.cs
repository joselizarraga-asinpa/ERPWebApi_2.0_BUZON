using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{
      
      //Clase creada por generador de código
      
      public class RepContrato: IEntidadBase
      {
            private long IdDocumento;
            private Int16 IdSucursal;
            private string Obra;
            private string Obradireccion;
            private string Proyecto;
            private DateTime Fecha;
            private string Cliente;
            private string Clirfc;
            private string Cliregpat;
            private string Clidireccion;
            private string Proveedor;
            private string Provrfc;
            private string Provregpat;
            private string Provdireccion;
            private string Totalletra;
            private DateTime Fechafirma;
            private string Testigo1;
            private string Testigo2;
            private string Plazo;
            private string Clausulas;
          
          
          //Constructor
          public RepContrato()
          {
              IdDocumento = 0;
              IdSucursal = 0;
              Obra = "";
              Obradireccion = "";
              Proyecto = ""; 
              Fecha = System.DateTime.Today;
              Cliente = ""; 
              Clirfc = ""; 
              Cliregpat = ""; 
              Clidireccion = ""; 
              Proveedor = ""; 
              Provrfc = ""; 
              Provregpat = ""; 
              Provdireccion = ""; 
              Totalletra = ""; 
              Fechafirma = System.DateTime.Today;
              Testigo1 = ""; 
              Testigo2 = "";
              Plazo = "";
              Clausulas = "";

          }

            public long IDDOCUMENTO
            {
                get { return IdDocumento; }
                set
                {
                    if(value!=IdDocumento)
                    {
                    
                        IdDocumento = value;
                    }
                }
            }

        public Int16 IDSUCURSAL
        {
            get { return IdSucursal; }
            set
            {
                if (value != IdSucursal)
                {

                    IdSucursal = value;
                }
            }
        }

        public string OBRA
          {
              get{ return Obra.ToString().Trim(); }
              set
              {
                  if(value!=Obra)
                  {
                      
                      Obra = value;
                  }
              }
          }
        public string OBRADIRECCION
        {
            get { return Obradireccion.ToString().Trim(); }
            set
            {
                if (value != Obradireccion)
                {
                    
                    Obradireccion = value;
                }
            }
        }
        public string PROYECTO
          {
              get{ return Proyecto.ToString().Trim(); }
              set
              {
                  if(value!=Proyecto)
                  {
                      
                      Proyecto = value;
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
          public string CLIRFC
          {
              get{ return Clirfc.ToString().Trim(); }
              set
              {
                  if(value!=Clirfc)
                  {
                      
                      Clirfc = value;
                  }
              }
          }
          [DataMember(IsRequired = true)]
          public string CLIREGPAT
          {
              get{ return Cliregpat.ToString().Trim(); }
              set
              {
                  if(value!=Cliregpat)
                  {
                      
                      Cliregpat = value;
                  }
              }
          }
          public string CLIDIRECCION
          {
              get{ return Clidireccion.ToString().Trim(); }
              set
              {
                  if(value!=Clidireccion)
                  {
                      
                      Clidireccion = value;
                  }
              }
          }
          public string PROVEEDOR
          {
              get{ return Proveedor.ToString().Trim(); }
              set
              {
                  if(value!=Proveedor)
                  {
                      
                      Proveedor = value;
                  }
              }
          }
          public string PROVRFC
          {
              get{ return Provrfc.ToString().Trim(); }
              set
              {
                  if(value!=Provrfc)
                  {
                      
                      Provrfc = value;
                  }
              }
          }
          public string PROVREGPAT
          {
              get{ return Provregpat.ToString().Trim(); }
              set
              {
                  if(value!=Provregpat)
                  {
                      
                      Provregpat = value;
                  }
              }
          }
          public string PROVDIRECCION
          {
              get{ return Provdireccion.ToString().Trim(); }
              set
              {
                  if(value!=Provdireccion)
                  {
                      
                      Provdireccion = value;
                  }
              }
          }
          public string TOTALLETRA
          {
              get{ return Totalletra.ToString().Trim(); }
              set
              {
                  if(value!=Totalletra)
                  {
                      
                      Totalletra = value;
                  }
              }
          }
          [DataMember(IsRequired = true)]
          public DateTime FECHAFIRMA
          {
              get{ return Fechafirma; }
              set
              {
                  if (value != null)
                  {
                      if(value!=Fechafirma)
                      {
                          
                          Fechafirma = value;
                      }
                  }
              }
          }
          public string TESTIGO1
          {
              get{ return Testigo1.ToString().Trim(); }
              set
              {
                  if(value!=Testigo1)
                  {
                      
                      Testigo1 = value;
                  }
              }
          }
          public string TESTIGO2
          {
              get{ return Testigo2.ToString().Trim(); }
              set
              {
                  if(value!=Testigo2)
                  {
                      
                      Testigo2 = value;
                  }
              }
          }
        public string PLAZO
        {
            get { return Plazo.ToString().Trim(); }
            set
            {
                if (value != Plazo)
                {
                    Plazo = value;
                }
            }
        }
        public string CLAUSULAS
            {
                get { return Clausulas.ToString().Trim(); }
                set
                {
                    if (value != Clausulas)
                    {
                        Clausulas = value;
                    }
                }
            }
    }
}
