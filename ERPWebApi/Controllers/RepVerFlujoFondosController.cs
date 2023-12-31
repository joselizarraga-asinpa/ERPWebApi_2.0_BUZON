using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de c�digo
	[Route("api/[controller]")]
	public class RepVerFlujoFondosController: Controller
	{
		
		[HttpPost]
        public JsonResult Post([FromBody]Entidades.RepVerFlujoFondos RepVerFlujoFondos)
        {
            try
            {
                List<Entidades.RepVerFlujoFondos> Result = Datos.Consultar<Entidades.RepVerFlujoFondos>(RepVerFlujoFondos,
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
