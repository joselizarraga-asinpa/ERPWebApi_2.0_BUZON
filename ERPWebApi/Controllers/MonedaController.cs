using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
      
      //Clase creada por generador de código
      [Route("api/[controller]")]
      public class MonedaController: Controller
      {
          [HttpGet]
          public JsonResult Get()
          {
              try
              {
                  List<Entidades.Moneda> Result = Datos.Consultar<Entidades.Moneda>(new Entidades.Moneda()
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
                  List<Entidades.Moneda> Result = Datos.Consultar<Entidades.Moneda>(new Entidades.Moneda()
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
          public string Post([FromBody]Entidades.Moneda Moneda)
          {
              try
              {
                  return Datos.Nuevo<Entidades.Moneda>(Moneda, null, Enumeradores.TypeAction.None);
              }
              catch (Exception ex)
              {
                  return ex.Message;
              }
          }
          
          [HttpPut]
          public string Put([FromBody]Entidades.Moneda Moneda)
          {
              try
              {
                  return Datos.Actualizar<Entidades.Moneda>(Moneda, null, Enumeradores.TypeAction.None);
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
                  return Datos.Eliminar<Entidades.Moneda>(new Entidades.Moneda()
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
