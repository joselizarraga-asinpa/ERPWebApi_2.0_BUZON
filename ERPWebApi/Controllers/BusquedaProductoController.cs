using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
      
      //Clase creada por generador de c�digo
      [Route("api/[controller]")]
      public class BusquedaProductoController: Controller
      {

        /// <summary>
        /// Obtiene una colecci�n de resultados de tipo entidades.BusquedaProducto para la b�squeda de productos
        /// </summary>
        /// <param name="BusquedaProducto">Objeto serializado de tipo Entidades.BusquedaProducto</param>
        /// <returns></returns>
        [HttpGet]
          public JsonResult Get([FromBody]Entidades.BusquedaProducto BusquedaProducto)
          {
              try
              {
                BusquedaProducto.BUSQUEDA = (BusquedaProducto.BUSQUEDA == @"""" ? "" : BusquedaProducto.BUSQUEDA);
                List<Entidades.BusquedaProducto> Result = Datos.Consultar<Entidades.BusquedaProducto>(BusquedaProducto,
                  new List<object>().ToArray()
                  );
                  return Json(Result);
              }
              catch (Exception ex)
              {
                  return Json(ex.Message);
              }
          }

        /// <summary>
        /// Obtiene una colecci�n de resultados de tipo entidades.BusquedaProducto para la b�squeda de Productos
        /// </summary>
        /// <param name="BusquedaProducto">Objeto serializado de tipo Entidades.BusquedaProducto</param>
        /// <returns></returns>
        [HttpPost]
          public JsonResult Post([FromBody]Entidades.BusquedaProducto BusquedaProducto)
          {
            try
            {
                BusquedaProducto.BUSQUEDA = (BusquedaProducto.BUSQUEDA == @"""" ? "" : BusquedaProducto.BUSQUEDA);
                List<Entidades.BusquedaProducto> Result = Datos.Consultar<Entidades.BusquedaProducto>(BusquedaProducto,
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
