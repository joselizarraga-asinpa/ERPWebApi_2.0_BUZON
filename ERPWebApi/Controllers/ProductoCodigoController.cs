using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
      
      //Clase creada por generador de código
      [Route("api/[controller]")]
      public class ProductoCodigoController: Controller
      {
        [HttpGet("{buscar}")]
        public JsonResult Get(string buscar)
        {
            try
            {
                List<Entidades.ProductoCodigo> Result = Datos.Consultar<Entidades.ProductoCodigo>(new Entidades.ProductoCodigo()
                {
                    ID = 0,
                    CODIGO = (buscar == @"""" ? "" : buscar)
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

        [HttpGet("{idproducto}/{id}")]
          public JsonResult Get(Int32 idproducto, Int64 id)
          {
              try
              {
                  List<Entidades.ProductoCodigo> Result = Datos.Consultar<Entidades.ProductoCodigo>(new Entidades.ProductoCodigo()
                  {
                       ID = id,
                       IDPRODUCTO = idproducto,
                       CODIGO = ""
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
          public string Post([FromBody]Entidades.ProductoCodigo ProductoCodigo)
          {
              try
              {
                  return Datos.Nuevo<Entidades.ProductoCodigo>(ProductoCodigo, null, Enumeradores.TypeAction.None);
              }
              catch (Exception ex)
              {
                  return ex.Message;
              }
          }
          
          [HttpPut]
          public string Put([FromBody]Entidades.ProductoCodigo ProductoCodigo)
          {
              try
              {
                  return Datos.Actualizar<Entidades.ProductoCodigo>(ProductoCodigo, null, Enumeradores.TypeAction.None);
              }
              catch (Exception ex)
              {
                  return ex.Message;
              }
          }
          
          [HttpDelete("{id}")]
          public string Delete(Int64 id)
          {
              try
              {
                  return Datos.Eliminar<Entidades.ProductoCodigo>(new Entidades.ProductoCodigo()
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
