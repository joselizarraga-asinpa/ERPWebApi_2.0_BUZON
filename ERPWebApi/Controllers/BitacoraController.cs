using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class BitacoraController: Controller
	{
	
        /// <summary>
        /// Obtiene las actividades de la bitácora del sistema de una referencia específica de una Funcionalidad o Aplicación definida por el usuario
        /// </summary>
        /// <param name="idFuncionalidad">Es el Id de la funcionalidad</param>
        /// <param name="idAplicacion">Es el Id de la Aplicación definida por el usuario</param>
        /// <param name="idReferencia">Es el Id de la Funcionalidad o Aplicación</param>
        /// <returns></returns>
		[HttpGet("{idfuncionalidad}/{idAplicacion}/{idReferencia}")]
		public JsonResult Get(Int16 idFuncionalidad, Int16 idAplicacion, long idReferencia)
		{
			try
			{
				List<Entidades.Bitacora> Result = Datos.Consultar<Entidades.Bitacora>(new Entidades.Bitacora()
				{
						 IDFUNCIONALIDAD = idFuncionalidad,
                         IDAPLICACION = idAplicacion,
                         IDREFERENCIA = idReferencia
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
        /// Crea una actividad en la bitácora del sistema
        /// </summary>
        /// <param name="Bitacora">Objeto serializado de tipo Entidades.Bitacora</param>
        /// <returns></returns>
		[HttpPost]
		public string Post([FromBody]Entidades.Bitacora Bitacora)
		{
			try
			{
				return Datos.Nuevo<Entidades.Bitacora>(Bitacora, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}

        /// <summary>
        /// Actualiza una actividad en la bitácora del sistema
        /// </summary>
        /// <param name="Bitacora">Objeto serializado de tipo Entidades.Bitacora</param>
        /// <returns></returns>
        [HttpPut]
		public string Put([FromBody]Entidades.Bitacora Bitacora)
		{
			try
			{
				return Datos.Actualizar<Entidades.Bitacora>(Bitacora, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
        /// <summary>
        /// Elimina una actividad de la bitácora del sistema
        /// </summary>
        /// <param name="id">Es el Id de la actividad a Eliminar</param>
        /// <returns></returns>
		[HttpDelete("{id}")]
		public string Delete(Int64 id)
		{
			try
			{
				return Datos.Eliminar<Entidades.Bitacora>(new Entidades.Bitacora()
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
