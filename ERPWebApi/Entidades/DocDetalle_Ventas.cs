using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{
      
      //Clase creada por generador de código
      
      public class DocDetalle_Ventas: IEntidadBase
      {
        private Int16 Id;
        private long Iddoc;
        private long Iddocdet;
        private long Iddocaplicado;
        private Int32 Idproducto;
        private Int32 Idclas;
        private Int32 Idproductocomp;
        private long Idexistencia;
        private long Iddocdetallepadre;
        private long Iddocdetallefuente;
        private Int16 IdImpuesto;
        private string Material;
        private string Expresionformula;
        private string Tipoproducto;
        private decimal Cantidad;
        private decimal Gasto;
        private decimal Tramo;
        private decimal Costo;
        private bool PorcentajeManual;
        private bool CostoManual;
        private string Numextra1;
        private string Numextra2;
        private string Numextra3;          


        //Constructor
        public DocDetalle_Ventas()
          {
            Id = 0;
            Iddoc = 0;
            Iddocdet = 0;
            Iddocaplicado = 0;
            Idproducto = 0;
            Idclas = 0;
            Idproductocomp = 0;
            Idexistencia = 0;
            Iddocdetallepadre = 0;
            Iddocdetallefuente = 0;
            IdImpuesto = 0;
            Material = ""; 
            Expresionformula = "";
            Tipoproducto = ""; 
            Cantidad = 0; 
            Gasto = 0; 
            Tramo = 0; 
            Costo = 0;
            PorcentajeManual = false;
            
            CostoManual = false;
            Numextra1 = ""; 
            Numextra2 = ""; 
            Numextra3 = "";
              
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

        public long IDDOC
        {
            get { return Iddoc; }
            set
            {
                if (value != Iddoc)
                {
                    
                    Iddoc = value;
                }
            }
        }
        
        public long IDDOCDET
            {
                get { return Iddocdet; }
                set
                {
                    if (value != Iddocdet)
                    {
                        
                        Iddocdet = value;
                    }
                }
            }

        public long IDDOCAPLICADO
        {
            get { return Iddocaplicado; }
            set
            {
                if (value != Iddocaplicado)
                {
                    
                    Iddocaplicado = value;
                }
            }
        }

        [DataMember(IsRequired = true)]
            public Int32 IDPRODUCTO
            {
                get { return Idproducto; }
                set
                {
                    if (value != Idproducto)
                    {
                        
                        Idproducto = value;
                    }
                }
            }
            public Int32 IDCLAS
            {
                get { return Idclas; }
                set
                {
                    if (value != Idclas)
                    {
                        
                        Idclas = value;
                    }
                }
            }
        public Int32 IDPRODUCTOCOMP
            {
              get{ return Idproductocomp; }
              set
              {
                  if(value!=Idproductocomp)
                  {
                      
                      Idproductocomp = value;
                  }
              }
          }
        public long IDEXISTENCIA
        {
            get { return Idexistencia; }
            set
            {
                if (value != Idexistencia)
                {
                    
                    Idexistencia = value;
                }
            }
        }
        public long IDDOCDETALLEPADRE
        {
            get { return Iddocdetallepadre; }
            set
            {
                if (value != Iddocdetallepadre)
                {
                    
                    Iddocdetallepadre = value;
                }
            }
        }
        public long IDDOCDETALLEFUENTE
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
        public Int16 IDIMPUESTO
        {
            get { return IdImpuesto; }
            set
            {
                if (value != IdImpuesto)
                {

                    IdImpuesto = value;
                }
            }
        }
        [DataMember(IsRequired = true)]
          public string MATERIAL
          {
              get{ return Material.ToString().Trim(); }
              set
              {
                  if(value!=Material)
                  {
                      
                      Material = value;
                  }
              }
          }          
          public string EXPRESIONFORMULA
          {
              get{ return Expresionformula.ToString().Trim(); }
              set
              {
                  if(value!=Expresionformula)
                  {
                      
                      Expresionformula = value;
                  }
              }
          }          
          public string TIPOPRODUCTO
          {
              get{ return Tipoproducto.ToString().Trim(); }
              set
              {
                  if(value!= Tipoproducto)
                  {
                      
                    Tipoproducto = value;
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
          [DataMember(IsRequired = true)]
          public decimal GASTO
          {
              get{ return Gasto; }
              set
              {
                  if(value!=Gasto)
                  {
                      
                      Gasto = value;
                  }
              }
          }          
          public decimal TRAMO
          {
              get{ return Tramo; }
              set
              {
                  if(value!=Tramo)
                  {
                      
                      Tramo = value;
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
        public string NUMEXTRA1
          {
              get{ return Numextra1.ToString().Trim(); }
              set
              {
                  if(value!=Numextra1)
                  {
                      
                      Numextra1 = value;
                  }
              }
          }          
          public string NUMEXTRA2
          {
              get{ return Numextra2.ToString().Trim(); }
              set
              {
                  if(value!=Numextra2)
                  {
                      
                      Numextra2 = value;
                  }
              }
          }          
          public string NUMEXTRA3
          {
              get{ return Numextra3.ToString().Trim(); }
              set
              {
                  if(value!=Numextra3)
                  {
                      
                      Numextra3 = value;
                  }
              }
          }
        
    }
}
