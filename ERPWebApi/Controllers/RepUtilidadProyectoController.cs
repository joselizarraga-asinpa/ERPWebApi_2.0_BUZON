using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class RepUtilidadProyectoController: Controller
	{        
        [HttpPost]
        public JsonResult Post([FromBody]Entidades.RepUtilidadProyecto RepUtilidadProyecto)
        {
            try
            {
                List<Entidades.RepUtilidadProyecto> Result = Datos.Consultar<Entidades.RepUtilidadProyecto>(RepUtilidadProyecto,
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
