using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
      
      //Clase creada por generador de código
      [Route("api/[controller]")]
      public class StatusController: Controller
      {
          [HttpGet]
          public JsonResult Get()
          {
              try
              {
                  List<Entidades.Status> Result = Datos.Consultar<Entidades.Status>(new Entidades.Status()
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
          
          [HttpGet("{idfuncionalidad}")]
          public JsonResult Get(Int16 idfuncionalidad)
          {
              try
              {
                  List<Entidades.Status> Result = Datos.Consultar<Entidades.Status>(new Entidades.Status()
                  {
                       ID = 0
                      ,IDPINCLIENTE = Datos.idPinCliente
                      ,IDFUNCIONALIDAD = idfuncionalidad
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
          public string Post([FromBody]Entidades.Status Status)
          {
              try
              {
                  Status.IDPINCLIENTE = Datos.idPinCliente;
                  return Datos.Nuevo<Entidades.Status>(Status, null, Enumeradores.TypeAction.None);
              }
              catch (Exception ex)
              {
                  return ex.Message;
              }
          }
          
          [HttpPut]
          public string Put([FromBody]Entidades.Status Status)
          {
              try
              {
                  Status.IDPINCLIENTE = Datos.idPinCliente;
                  return Datos.Actualizar<Entidades.Status>(Status, null, Enumeradores.TypeAction.None);
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
                  return Datos.Eliminar<Entidades.Status>(new Entidades.Status()
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
