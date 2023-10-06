using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
      
      //Clase creada por generador de código
      [Route("api/[controller]")]
      public class RepContratoController: Controller
      {
        
          
          [HttpGet("{iddocumento}/{idsucursal}")]
          public JsonResult Get(long iddocumento, Int16 idsucursal)
          {
              try
              {
                  List<Entidades.RepContrato> Result = Datos.Consultar<Entidades.RepContrato>(new Entidades.RepContrato()
                  {
                      IDDOCUMENTO = iddocumento,
                      IDSUCURSAL = idsucursal
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
          
         
      }
}
