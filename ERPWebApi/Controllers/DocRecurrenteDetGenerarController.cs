using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class DocRecurrenteDetGenerarController: Controller
	{
        [HttpPost]
        public JsonResult Post([FromBody]Entidades.DocRecurrenteDetGenerar DocRecurrenteDetGenerar)
        {
            try
            {
                List<Entidades.DocRecurrenteDetGenerar> Result = Datos.Consultar<Entidades.DocRecurrenteDetGenerar>(DocRecurrenteDetGenerar,
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
