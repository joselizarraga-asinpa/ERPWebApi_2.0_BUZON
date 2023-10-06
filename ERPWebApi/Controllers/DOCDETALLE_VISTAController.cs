using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
      
      //Clase creada por generador de código
      [Route("api/[controller]")]
      public class DocDetalle_VistaController: Controller
      {
        //[HttpGet("{iddocumento}/{componente}")]
        //public JsonResult Get(Int64 iddocumento, Int16 componente)
        //{
        //    try
        //    {
        //        List<Entidades.DocDetalle_Vista> Result = Datos.Consultar<Entidades.DocDetalle_Vista>(new Entidades.DocDetalle_Vista()
        //        {
        //            ID = 0,
        //            IDDOCUMENTO = iddocumento,
        //            COMPONENTE = componente > 0
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

        [HttpPost]
        public JsonResult Post([FromBody]Entidades.DocDetalle_Vista DocDetalle_Vista)
        {
            try
            {
                List<Entidades.DocDetalle_Vista> Result = Datos.Consultar<Entidades.DocDetalle_Vista>(DocDetalle_Vista,
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
