using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{

    //Clase creada por generador de código
    [Route("api/[controller]")]
    public class ClasificacionController : Controller
    {
        //[HttpGet("{id}")]
        //public JsonResult Get(Int32 id)
        //{
        //    try
        //    {
        //        List<Entidades.Clasificacion> Result = Datos.Consultar<Entidades.Clasificacion>(new Entidades.Clasificacion()
        //        {
        //            ID = id
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

        /// <summary>
        /// Obtiene una colección de clasificaciones de una funcionalidad y de una empresa de tipo Entidades.Clasificaciones
        /// </summary>
        /// <param name="idempresa">Id de la empresa</param>
        /// <param name="idfuncionalidad">Id de la funcionalidad</param>
        /// <param name="id">Id de la clasificacion; 0 = Todas</param>
        /// <returns></returns>
        [HttpGet("{idempresa}/{idfuncionalidad}/{id}")]
          public JsonResult Get(Int16 idempresa, Int16 idfuncionalidad, Int32 id)
          {
              try
              {
                  List<Entidades.Clasificacion> Result = Datos.Consultar<Entidades.Clasificacion>(new Entidades.Clasificacion()
                  {
                       ID = id,
                       IDEMPRESA = idempresa,
                       IDFUNCIONALIDAD = idfuncionalidad
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
          
        /// <summary>
        /// Crea una nueva clasificación
        /// </summary>
        /// <param name="Clasificacion">objeto serializado de tipo Entidades.Clasificacion</param>
        /// <returns></returns>
          [HttpPost]
          public string Post([FromBody]Entidades.Clasificacion Clasificacion)
          {
              try
              {
                  return Datos.Nuevo<Entidades.Clasificacion>(Clasificacion, null, Enumeradores.TypeAction.None);
              }
              catch (Exception ex)
              {
                  return ex.Message;
              }
          }

        /// <summary>
        /// Actualiza los datos de una clasificación
        /// </summary>        
        /// <param name="Clasificacion">objeto serializado de tipo Entidades.Clasificacion</param>
        /// <returns></returns>
        [HttpPut]
          public string Put([FromBody]Entidades.Clasificacion Clasificacion)
          {
              try
              {
                  return Datos.Actualizar<Entidades.Clasificacion>(Clasificacion, null, Enumeradores.TypeAction.None);
              }
              catch (Exception ex)
              {
                  return ex.Message;
              }
          }
          
        /// <summary>
        /// Elimina una Clasificacion por su Id
        /// </summary>
        /// <param name="id">Id de la clasificacón a Eliminar</param>
        /// <returns></returns>
          [HttpDelete("{id}")]
          public string Delete(Int32 id)
          {
              try
              {
                  return Datos.Eliminar<Entidades.Clasificacion>(new Entidades.Clasificacion()
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
