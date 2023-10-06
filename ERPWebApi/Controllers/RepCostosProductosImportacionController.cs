using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class RepCostosProductosImportacionController: Controller
	{
        [HttpPost]
        public JsonResult Post([FromBody]Entidades.RepCostosProductosImportacion RepCostosProductosImportacion)
        {
            try
            {
                List<Entidades.RepCostosProductosImportacion> Result = Datos.Consultar<Entidades.RepCostosProductosImportacion>(RepCostosProductosImportacion,
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
