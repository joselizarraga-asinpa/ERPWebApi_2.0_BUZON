using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{
      
      //Clase creada por generador de código
      
      public class UnidadConversion: IEntidadBase
      {
          private Int16 Id;          
          private Int16 Idtipounidadorigen;
          private Int16 Idtipounidaddestino;          
          private Single Factor;
          
          public Int16 IDPINCLIENTE { get; set; }
          public string NOMBRETIPOUNIDADORIGEN { get; set; }
          public string NOMBRETIPOUNIDADDESTINO { get; set; }


        //Constructor
        public UnidadConversion()
          {
              Id = 0;              
              Idtipounidadorigen = 0; 
              Idtipounidaddestino = 0; 
              Factor = 0;

            IDPINCLIENTE = 0;
            NOMBRETIPOUNIDADORIGEN = "";
            NOMBRETIPOUNIDADDESTINO = "";
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
          public Int16 IDTIPOUNIDADORIGEN
          {
              get{ return Idtipounidadorigen; }
              set
              {
                  if(value!=Idtipounidadorigen)
                  {
                      
                      Idtipounidadorigen = value;
                  }
              }
          }
          [DataMember(IsRequired = true)]
          public Int16 IDTIPOUNIDADDESTINO
          {
              get{ return Idtipounidaddestino; }
              set
              {
                  if(value!=Idtipounidaddestino)
                  {
                      
                      Idtipounidaddestino = value;
                  }
              }
          }
          [DataMember(IsRequired = true)]
          public Single FACTOR
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
      }
}
