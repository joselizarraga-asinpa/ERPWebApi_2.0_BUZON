using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
      
      //Clase creada por generador de código
      [Route("api/[controller]")]
      public class ProductoComponenteController: Controller
      {
         
          
          [HttpGet("{idproducto}/{idproductocomp}")]
          public JsonResult Get(Int32 idproducto, Int32 idproductocomp)
          {
              try
              {
                  List<Entidades.ProductoComponente> Result = Datos.Consultar<Entidades.ProductoComponente>(new Entidades.ProductoComponente()
                  {
                       IDPRODUCTO = idproducto
                      ,IDPRODUCTOCOMP = idproductocomp
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
          public string Post([FromBody]Entidades.ProductoComponente ProductoComponente)
          {
              try
              {
                  return Datos.Nuevo<Entidades.ProductoComponente>(ProductoComponente, null, Enumeradores.TypeAction.None);
              }
              catch (Exception ex)
              {
                  return ex.Message;
              }
          }
          
          [HttpPut]
          public string Put([FromBody]Entidades.ProductoComponente ProductoComponente)
          {
              try
              {
                  return Datos.Actualizar<Entidades.ProductoComponente>(ProductoComponente, null, Enumeradores.TypeAction.None);
              }
              catch (Exception ex)
              {
                  return ex.Message;
              }
          }
          
          [HttpDelete("{idproducto}/{idproductocomp}")]
          public string Delete(Int32 idproducto, Int32 idproductocomp)
          {
              try
              {
                  return Datos.Eliminar<Entidades.ProductoComponente>(new Entidades.ProductoComponente()
                  {
                       IDPRODUCTO = idproducto
                      ,IDPRODUCTOCOMP = idproductocomp
                  });
              }
              catch (Exception ex)
              {
                  return ex.Message;
              }
          }
      }
}
