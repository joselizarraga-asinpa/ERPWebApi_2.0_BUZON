using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de c�digo
	[Route("api/[controller]")]
	public class RepRecurrenciaVentasController: Controller
	{
        [HttpPost]
        public JsonResult Post([FromBody]Entidades.RepRecurrenciaVentas RepRecurrenciaVentas)
        {
            try
            {
                List<Entidades.RepRecurrenciaVentas> Result = Datos.Consultar<Entidades.RepRecurrenciaVentas>(RepRecurrenciaVentas,
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
