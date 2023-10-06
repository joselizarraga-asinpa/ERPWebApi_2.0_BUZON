using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{
      
      //Clase creada por generador de código
      
      public class TipoProducto: IEntidadBase
      {
        private Int16 Id;
        private Int16 Idpincliente;
        private string Nombretipoproducto;
        private bool Inventario;
        private string NumExtra1;
        private string NumExtra2;
        private string NumExtra3;
        private string Serie1;
        private string Serie2;
        private string Serie3;
        private string Serie4;
        private string Serie5;


        //Constructor
        public TipoProducto()
        {
            Id = 0; 
            Idpincliente = 0; 
            Nombretipoproducto = ""; 
            Inventario = false;
            NumExtra1 = "";
            NumExtra2 = "";
            NumExtra3 = "";
            Serie1 = "";
            Serie2 = "";
            Serie3 = "";
            Serie4 = "";
            Serie5 = "";
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
          public string NOMBRETIPOPRODUCTO
          {
              get{ return Nombretipoproducto.ToString().Trim(); }
              set
              {
                  if(value!=Nombretipoproducto)
                  {
                      
                      Nombretipoproducto = value;
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
        [DataMember]
        public string NUMEXTRA1
        {
            get { return NumExtra1.ToString().Trim(); }
            set
            {
                if (value != NumExtra1)
                {
                    
                    NumExtra1 = value;
                }
            }
        }
        [DataMember]
        public string NUMEXTRA2
        {
            get { return NumExtra2.ToString().Trim(); }
            set
            {
                if (value != NumExtra2)
                {
                    
                    NumExtra2 = value;
                }
            }
        }
        [DataMember]
        public string NUMEXTRA3
        {
            get { return NumExtra3.ToString().Trim(); }
            set
            {
                if (value != NumExtra3)
                {
                    
                    NumExtra3 = value;
                }
            }
        }

        public string SERIE1
        {
            get { return Serie1.ToString().Trim(); }
            set
            {
                if (value != Serie1)
                {

                    Serie1 = value;
                }
            }
        }

        public string SERIE2
        {
            get { return Serie2.ToString().Trim(); }
            set
            {
                if (value != Serie2)
                {

                    Serie2 = value;
                }
            }
        }

        public string SERIE3
        {
            get { return Serie3.ToString().Trim(); }
            set
            {
                if (value != Serie3)
                {

                    Serie3 = value;
                }
            }
        }

        public string SERIE4
        {
            get { return Serie4.ToString().Trim(); }
            set
            {
                if (value != Serie4)
                {

                    Serie4 = value;
                }
            }
        }

        public string SERIE5
        {
            get { return Serie5.ToString().Trim(); }
            set
            {
                if (value != Serie5)
                {

                    Serie5 = value;
                }
            }
        }
    }
}
