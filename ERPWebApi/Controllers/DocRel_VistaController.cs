using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
      
      //Clase creada por generador de código
      [Route("api/[controller]")]
      public class DocRel_VistaController: Controller
      {

          
          [HttpGet("{id}")]
          public JsonResult Get(Int64 id)
          {
              try
              {
                  List<Entidades.DocRel_Vista> Result = Datos.Consultar<Entidades.DocRel_Vista>(new Entidades.DocRel_Vista()
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
          public string Post([FromBody]Entidades.DocRel_Vista DocRel_Vista)
          {
              try
              {
                  return Datos.Nuevo<Entidades.DocRel_Vista>(DocRel_Vista, null, Enumeradores.TypeAction.None);
              }
              catch (Exception ex)
              {
                  return ex.Message;
              }
          }
          
          //[HttpPut("{}")]
          //public string Put(, [FromBody]Entidades.DocRel_Vista DocRel_Vista)
          //{
          //    try
          //    {
          //        return Datos.Actualizar<Entidades.DocRel_Vista>(DocRel_Vista, null, Enumeradores.TypeAction.None);
          //    }
          //    catch (Exception ex)
          //    {
          //        return ex.Message;
          //    }
          //}
          
          //[HttpDelete("{}")]
          //public string Delete()
          //{
          //    try
          //    {
          //        return Datos.Eliminar<Entidades.DocRel_Vista>(new Entidades.DocRel_Vista()
          //        {
          //        });
          //    }
          //    catch (Exception ex)
          //    {
          //        return ex.Message;
          //    }
          //}
      }
}
