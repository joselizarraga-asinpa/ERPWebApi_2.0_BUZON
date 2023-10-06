using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
      
      //Clase creada por generador de código
      [Route("api/[controller]")]
      public class ImpuestoController: Controller
      {
          [HttpGet]
          public JsonResult Get()
          {
              try
              {
                  List<Entidades.Impuesto> Result = Datos.Consultar<Entidades.Impuesto>(new Entidades.Impuesto()
                  {
                       ID = 0
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
                  List<Entidades.Impuesto> Result = Datos.Consultar<Entidades.Impuesto>(new Entidades.Impuesto()
                  {
                       ID = id
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
          public string Post([FromBody]Entidades.Impuesto Impuesto)
          {
              try
              {
                  return Datos.Nuevo<Entidades.Impuesto>(Impuesto, null, Enumeradores.TypeAction.None);
              }
              catch (Exception ex)
              {
                  return ex.Message;
              }
          }
          
          [HttpPut]
          public string Put([FromBody]Entidades.Impuesto Impuesto)
          {
              try
              {
                  return Datos.Actualizar<Entidades.Impuesto>(Impuesto, null, Enumeradores.TypeAction.None);
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
                  return Datos.Eliminar<Entidades.Impuesto>(new Entidades.Impuesto()
                  {
                       ID = id
                  });
              }
              catch (Exception ex)
              {
                  return ex.Message;
              }
          }
      }
}
