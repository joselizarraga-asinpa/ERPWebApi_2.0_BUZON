using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class RepAcumuladoVentasController: Controller
	{
        
        [HttpPost]
        public JsonResult Post([FromBody]Entidades.RepAcumuladoVentas RepAcumuladoVentas)
        {
            try
            {
                List<Entidades.RepAcumuladoVentas> Result = Datos.Consultar<Entidades.RepAcumuladoVentas>(RepAcumuladoVentas,
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
