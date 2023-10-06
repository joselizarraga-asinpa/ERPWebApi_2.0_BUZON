using System;

namespace ERPWebApi.Entidades
{
      
      //Clase creada por generador de código
      
      public class Error: IEntidadBase
      {
          private string pcError;
          private string pcDescripcion;
          
          //Constructor
          public Error()
          {
              pcError = "" ; 
              pcDescripcion = "" ;
              HasError = true;
          }
          
          public string gcERROR
          {
              get{ return pcError.ToString().Trim(); }
              set
              {
                  if(value!=pcError)
                  {
                      
                      pcError = value;
                  }
              }
          }
          public string gcDESCRIPCION
          {
              get{ return pcDescripcion.ToString().Trim(); }
              set
              {
                  if(value!=pcDescripcion)
                  {
                      
                      pcDescripcion = value;
                  }
              }
          }
      }
            
}
