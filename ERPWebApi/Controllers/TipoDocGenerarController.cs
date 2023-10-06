using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
      
      //Clase creada por generador de código
      [Route("api/[controller]")]
      public class TipoDocGenerarController: Controller
      {
          //[HttpGet]
          //public JsonResult Get()
          //{
          //    try
          //    {
          //        List<Entidades.TipoDocGenerar> Result = Datos.Consultar<Entidades.TipoDocGenerar>(new Entidades.TipoDocGenerar()
          //        {
          //             IDTIPODOC = 0
          //            ,IDTIPODOCGENERAR = 0
          //        },
          //        new List<object>().ToArray()
          //        );
          //        return Json(Result);
          //    }
          //    catch (Exception ex)
          //    {
          //        return Json(ex.Message);
          //    }
          //}
          
          [HttpGet("{idtipodoc}/{idtipodocgenerar}")]
          public JsonResult Get(Int16 idtipodoc, Int16 idtipodocgenerar)
          {
              try
              {
                  List<Entidades.TipoDocGenerar> Result = Datos.Consultar<Entidades.TipoDocGenerar>(new Entidades.TipoDocGenerar()
                  {
                       IDTIPODOC = idtipodoc
                      ,IDTIPODOCGENERAR = idtipodocgenerar
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
          public string Post([FromBody]Entidades.TipoDocGenerar TipoDocGenerar)
          {
              try
              {
                  return Datos.Nuevo<Entidades.TipoDocGenerar>(TipoDocGenerar, null, Enumeradores.TypeAction.None);
              }
              catch (Exception ex)
              {
                  return ex.Message;
              }
          }
          
          [HttpPut]
          public string Put([FromBody]Entidades.TipoDocGenerar TipoDocGenerar)
          {
              try
              {
                  return Datos.Actualizar<Entidades.TipoDocGenerar>(TipoDocGenerar, null, Enumeradores.TypeAction.None);
              }
              catch (Exception ex)
              {
                  return ex.Message;
              }
          }
          
          [HttpDelete("{idtipodoc}/{idtipodocgenerar}")]
          public string Delete(Int16 idtipodoc, Int16 idtipodocgenerar)
          {
              try
              {
                  return Datos.Eliminar<Entidades.TipoDocGenerar>(new Entidades.TipoDocGenerar()
                  {
                       IDTIPODOC = idtipodoc
                      ,IDTIPODOCGENERAR = idtipodocgenerar
                  });
              }
              catch (Exception ex)
              {
                  return ex.Message;
              }
          }
      }
}
