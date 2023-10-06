using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
      
      //Clase creada por generador de código
      [Route("api/[controller]")]
      public class PlantillaTipoDocController: Controller
      {
          [HttpGet]
          public JsonResult Get()
          {
              try
              {
                  List<Entidades.PlantillaTipoDoc> Result = Datos.Consultar<Entidades.PlantillaTipoDoc>(new Entidades.PlantillaTipoDoc()
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
                  List<Entidades.PlantillaTipoDoc> Result = Datos.Consultar<Entidades.PlantillaTipoDoc>(new Entidades.PlantillaTipoDoc()
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
          public string Post([FromBody]Entidades.PlantillaTipoDoc PlantillaTipoDoc)
          {
              try
              {
                  return Datos.Nuevo<Entidades.PlantillaTipoDoc>(PlantillaTipoDoc, null, Enumeradores.TypeAction.None);
              }
              catch (Exception ex)
              {
                  return ex.Message;
              }
          }
          
          [HttpPut]
          public string Put([FromBody]Entidades.PlantillaTipoDoc PlantillaTipoDoc)
          {
              try
              {
                  return Datos.Actualizar<Entidades.PlantillaTipoDoc>(PlantillaTipoDoc, null, Enumeradores.TypeAction.None);
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
                  return Datos.Eliminar<Entidades.PlantillaTipoDoc>(new Entidades.PlantillaTipoDoc()
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
