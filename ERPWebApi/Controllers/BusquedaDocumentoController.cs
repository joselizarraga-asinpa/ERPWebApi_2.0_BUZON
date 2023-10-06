using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
      
      //Clase creada por generador de c�digo
      [Route("api/[controller]")]
      public class BusquedaDocumentoController: Controller
      {          
          /// <summary>
          /// Obtiene una colecci�n de resultados de tipo entidades.BusquedaDocumento para la b�squeda de documentos
          /// </summary>
          /// <param name="BusquedaDocumento">Objeto serializado de tipo Entidades.BusquedaDocumento</param>
          /// <returns></returns>
          [HttpPost]
          public JsonResult Post([FromBody]Entidades.BusquedaDocumento BusquedaDocumento)
          {
              try
              {
                BusquedaDocumento.BUSQUEDA = (BusquedaDocumento.BUSQUEDA == @"""" ? "" : BusquedaDocumento.BUSQUEDA);
                List<Entidades.BusquedaDocumento> Result = Datos.Consultar<Entidades.BusquedaDocumento>(BusquedaDocumento,
                new List<object>().ToArray());
              return Json(Result);
            }
              catch (Exception ex)
              {
                return Json(ex.Message);
            }
          }
          
         
      }
}
