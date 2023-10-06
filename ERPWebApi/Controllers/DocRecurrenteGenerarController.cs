using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class DocRecurrenteGenerarController: Controller
	{
		
		[HttpPost]
		public JsonResult Post([FromBody]Entidades.DocRecurrenteGenerar DocRecurrenteGenerar)
		{
            try
            {
                List<Entidades.DocRecurrenteGenerar> Result = Datos.Consultar<Entidades.DocRecurrenteGenerar>(DocRecurrenteGenerar,
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
