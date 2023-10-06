using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class RepAuxiliarUtilidadController: Controller
	{
        [HttpPost]
        public JsonResult Post([FromBody]Entidades.RepAuxiliarUtilidad RepAuxiliarUtilidad)
        {
            try
            {
                List<Entidades.RepAuxiliarUtilidad> Result = Datos.Consultar<Entidades.RepAuxiliarUtilidad>(RepAuxiliarUtilidad,
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
