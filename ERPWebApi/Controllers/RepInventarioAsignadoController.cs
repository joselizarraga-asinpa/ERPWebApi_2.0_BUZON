using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class RepInventarioAsignadoController: Controller
	{
				
		[HttpPost]
		public JsonResult Post([FromBody]Entidades.RepInventarioAsignado RepInventarioAsignado)
		{
            try
            {
                List<Entidades.RepInventarioAsignado> Result = Datos.Consultar<Entidades.RepInventarioAsignado>(RepInventarioAsignado,
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
