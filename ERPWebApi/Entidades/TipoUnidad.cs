using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPWebApi.Entidades
{
      
      //Clase creada por generador de código
      
      public class TipoUnidad: IEntidadBase
      {
        private Int16 Id;
        private Int16 Idpincliente;
        private string Nombretipounidad;
        private string Abreviatura;
        private bool Aprovechamiento;
        private string ClaveSat;
        private string NombreClaveSat;

        //public List<ClasDetalle> ClasDetalle { get; set; }
        //public List<UnidadConversion> UnidadConversion { get; set; }

        //Constructor
        public TipoUnidad()
        {
            Id = 0; 
            Idpincliente = 0; 
            Nombretipounidad = ""; 
            Abreviatura = "";
            Aprovechamiento = false;
            ClaveSat = "";
            NombreClaveSat = "";

              //ClasDetalle = new List<ClasDetalle>(); 
              //UnidadConversion = new List<UnidadConversion>(); 
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
          public string NOMBRETIPOUNIDAD
          {
              get{ return Nombretipounidad.ToString().Trim(); }
              set
              {
                  if(value!=Nombretipounidad)
                  {
                      
                      Nombretipounidad = value;
                  }
              }
          }
          [DataMember(IsRequired = true)]
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
        public string CLAVESAT
        {
            get { return ClaveSat.ToString().Trim(); }
            set
            {
                if (value != ClaveSat)
                {
                    ClaveSat = value;
                }
            }
        }
        [DataMember(IsRequired = true)]
        public string NOMBRECLAVESAT
        {
            get { return NombreClaveSat.ToString().Trim(); }
            set
            {
                if (value != NombreClaveSat)
                {
                    NombreClaveSat = value;
                }
            }
        }
    }
}
