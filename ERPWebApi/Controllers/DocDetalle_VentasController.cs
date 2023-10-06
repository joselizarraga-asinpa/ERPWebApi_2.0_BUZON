using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
      
      //Clase creada por generador de código
      [Route("api/[controller]")]
      public class DOCDETALLE_VENTASController: Controller
      {
          //[HttpGet]
          //public JsonResult Get()
          //{
          //    try
          //    {
          //        List<Entidades.DocDetalle_Ventas> Result = Datos.Consultar<Entidades.DocDetalle_Ventas>(new Entidades.DocDetalle_Ventas()
          //        {
          //             ID = 0
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
          
          [HttpGet("{iddoc}/{iddocdet}/{idproducto}/{idclas}")]
          public JsonResult Get(long iddoc,long iddocdet, Int16 idproducto, Int16 idclas)
          {
              try
              {
                  List<Entidades.DocDetalle_Ventas> Result = Datos.Consultar<Entidades.DocDetalle_Ventas>(new Entidades.DocDetalle_Ventas()
                  {
                        IDDOC = iddoc
                       ,IDDOCDET = iddocdet
                       ,IDPRODUCTO = idproducto
                       ,IDCLAS = idclas                       
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
          public string Post([FromBody]Entidades.DocDetalle_Ventas DocDetalle_Ventas)
          {
              try
              {
                  return Datos.Nuevo<Entidades.DocDetalle_Ventas>(DocDetalle_Ventas, null, Enumeradores.TypeAction.None);
              }
              catch (Exception ex)
              {
                  return ex.Message;
              }
          }
          
          [HttpPut]
          public string Put([FromBody]Entidades.DocDetalle_Ventas DocDetalle_Ventas)
          {
              try
              {
                  return Datos.Actualizar<Entidades.DocDetalle_Ventas>(DocDetalle_Ventas, null, Enumeradores.TypeAction.None);
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
                  return Datos.Eliminar<Entidades.DocDetalle_Ventas>(new Entidades.DocDetalle_Ventas()
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
