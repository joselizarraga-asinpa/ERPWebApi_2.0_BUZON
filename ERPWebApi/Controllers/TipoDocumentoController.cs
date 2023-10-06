using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
      
      //Clase creada por generador de código
      [Route("api/[controller]")]
      public class TipoDocumentoController: Controller
      {
          [HttpGet]
          public JsonResult Get()
          {
              try
              {
                  List<Entidades.TipoDocumento> Result = Datos.Consultar<Entidades.TipoDocumento>(new Entidades.TipoDocumento()
                  {
                       ID = 0
                      ,IDPINCLIENTE = Datos.idPinCliente
                  },
                  new List<object>().ToArray()
                  );
                  return Json(Result);
              }
              catch (Exception ex)
              {
                  return Json(ex.Message);
              }
          }
          
          [HttpGet("{id}")]
          public JsonResult Get(Int16 id)
          {
              try
              {
                  List<Entidades.TipoDocumento> Result = Datos.Consultar<Entidades.TipoDocumento>(new Entidades.TipoDocumento()
                  {
                       ID = id
                      ,IDPINCLIENTE = Datos.idPinCliente
                  },
                  new List<object>().ToArray()
                  );
                  return Json(Result);
              }
              catch (Exception ex)
              {
                  return Json(ex.Message);
              }
          }

        [HttpGet("{id}/{buscar}")]
        public JsonResult Get(Int16 id, string buscar)
        {
            try
            {
                List<Entidades.TipoDocumento> Result = Datos.Buscar<Entidades.TipoDocumento>(new Entidades.TipoDocumento()
                {
                    ID = 0,
                    IDPINCLIENTE = Datos.idPinCliente,
                    NOMBRETIPODOC = (buscar == @"""" ? "" : buscar)
                },
                new List<object>().ToArray()
                );
                return Json(Result);
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }

        [HttpPost]
          public string Post([FromBody]Entidades.TipoDocumento TipoDocumento)
          {
              try
              {
                  TipoDocumento.IDPINCLIENTE = Datos.idPinCliente;
                  return Datos.Nuevo<Entidades.TipoDocumento>(TipoDocumento, null, Enumeradores.TypeAction.None);
              }
              catch (Exception ex)
              {
                  return ex.Message;
              }
          }
          
          [HttpPut]
          public string Put([FromBody]Entidades.TipoDocumento TipoDocumento)
          {
              try
              {
                  TipoDocumento.IDPINCLIENTE = Datos.idPinCliente;
                  return Datos.Actualizar<Entidades.TipoDocumento>(TipoDocumento, null, Enumeradores.TypeAction.None);
              }
              catch (Exception ex)
              {
                  return ex.Message;
              }
          }
          
          [HttpDelete("{id}")]
          public string Delete(Int16 id)
          {
              try
              {
                  return Datos.Eliminar<Entidades.TipoDocumento>(new Entidades.TipoDocumento()
                  {
                       ID = id
                      ,IDPINCLIENTE = Datos.idPinCliente
                  });
              }
              catch (Exception ex)
              {
                  return ex.Message;
              }
          }
      }
}
