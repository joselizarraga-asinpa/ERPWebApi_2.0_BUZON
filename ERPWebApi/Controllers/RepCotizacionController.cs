using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
      
      //Clase creada por generador de código
      [Route("api/[controller]")]
      public class RepCotizacionController: Controller
      {
          //[HttpGet]
          //public JsonResult Get()
          //{
          //    try
          //    {
          //        List<Entidades.RepCotizacion> Result = Datos.Consultar<Entidades.RepCotizacion>(new Entidades.RepCotizacion()
          //        {
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
          
          [HttpGet("{iddocumento}")]
          public JsonResult Get(long IdDocumento)
          {
              try
              {
                  List<Entidades.RepCotizacion> Result = Datos.Consultar<Entidades.RepCotizacion>(new Entidades.RepCotizacion()
                  {
                      IDDOCUMENTO = IdDocumento
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
          
          //[HttpPost]
          //public string Post([FromBody]Entidades.RepCotizacion RepCotizacion)
          //{
          //    try
          //    {
          //        return Datos.Nuevo<Entidades.RepCotizacion>(RepCotizacion, null, Enumeradores.TypeAction.None);
          //    }
          //    catch (Exception ex)
          //    {
          //        return ex.Message;
          //    }
          //}
          
          //[HttpPut("{}")]
          //public string Put(, [FromBody]Entidades.RepCotizacion RepCotizacion)
          //{
          //    try
          //    {
          //        return Datos.Actualizar<Entidades.RepCotizacion>(RepCotizacion, null, Enumeradores.TypeAction.None);
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
          //        return Datos.Eliminar<Entidades.RepCotizacion>(new Entidades.RepCotizacion()
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
