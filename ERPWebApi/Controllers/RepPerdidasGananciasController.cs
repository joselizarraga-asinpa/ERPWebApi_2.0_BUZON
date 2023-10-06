using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class RepPerdidasGananciasController: Controller
	{
		
		
		[HttpPost]
		public JsonResult Post([FromBody]Entidades.RepPerdidasGanancias RepPerdidasGanancias)
		{
            try
            {
                List<Entidades.RepPerdidasGanancias> Result = Datos.Consultar<Entidades.RepPerdidasGanancias>(RepPerdidasGanancias,
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
