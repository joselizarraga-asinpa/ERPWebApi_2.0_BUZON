using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
      
      //Clase creada por generador de código
      [Route("api/[controller]")]
      public class UnidadConversionController: Controller
      {
          [HttpGet("{id}")]
          public JsonResult Get(Int16 id)
          {
              try
              {
                  List<Entidades.UnidadConversion> Result = Datos.Consultar<Entidades.UnidadConversion>(new Entidades.UnidadConversion()
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
          
          [HttpGet("{id}/{idpincliente}")]
          public JsonResult Get(Int16 id, Int16 idpincliente)
          {
              try
              {
                  List<Entidades.UnidadConversion> Result = Datos.Consultar<Entidades.UnidadConversion>(new Entidades.UnidadConversion()
                  {
                       ID = id,
                       IDPINCLIENTE = idpincliente
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
          public string Post([FromBody]Entidades.UnidadConversion UnidadConversion)
          {
              try
              {
                  return Datos.Nuevo<Entidades.UnidadConversion>(UnidadConversion, null, Enumeradores.TypeAction.None);
              }
              catch (Exception ex)
              {
                  return ex.Message;
              }
          }
          
          [HttpPut]
          public string Put([FromBody]Entidades.UnidadConversion UnidadConversion)
          {
              try
              {
                  return Datos.Actualizar<Entidades.UnidadConversion>(UnidadConversion, null, Enumeradores.TypeAction.None);
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
                  return Datos.Eliminar<Entidades.UnidadConversion>(new Entidades.UnidadConversion()
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
