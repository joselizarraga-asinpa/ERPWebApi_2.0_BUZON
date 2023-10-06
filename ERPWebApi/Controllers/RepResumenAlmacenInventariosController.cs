using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class RepResumenAlmacenInventariosController : Controller
	{
		
		[HttpPost]
		public JsonResult Post([FromBody]Entidades.RepResumenAlmacenInventarios RepResumenAlmacenInventarios)
		{
            try
            {
                List<Entidades.RepResumenAlmacenInventarios> Result = Datos.Consultar<Entidades.RepResumenAlmacenInventarios>(RepResumenAlmacenInventarios,
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
