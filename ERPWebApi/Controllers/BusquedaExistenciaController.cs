using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class BusquedaExistenciaController: Controller
	{
               

        [HttpPost]
		public JsonResult Post([FromBody]Entidades.Existencia Existencia)
		{
			try
			{
                List<Entidades.Existencia> Result = Datos.Buscar<Entidades.Existencia>(Existencia,
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
