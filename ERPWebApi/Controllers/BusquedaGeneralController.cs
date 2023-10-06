using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de c�digo
	[Route("api/[controller]")]
	public class BusquedaGeneralController: Controller
	{
        /// <summary>
        /// Obtiene una colecci�n de resultados de tipo entidades.BusquedaGeneral para la b�squeda de datos generales
        /// </summary>
        /// <param name="BusquedaGeneral">Objeto serializado de tipo Entidades.BusquedaGeneral</param>
        /// <returns></returns>
        [HttpPost]
		public JsonResult Post([FromBody]Entidades.BusquedaGeneral BusquedaGeneral)
		{
			try
			{                
                List<Entidades.BusquedaGeneral> Result = Datos.Consultar<Entidades.BusquedaGeneral>(BusquedaGeneral,
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
