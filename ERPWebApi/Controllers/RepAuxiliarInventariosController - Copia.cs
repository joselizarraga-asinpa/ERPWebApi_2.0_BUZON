using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class RepAuxiliarInventariosController: Controller
	{
		
		[HttpPost]
		public JsonResult Post([FromBody]Entidades.RepAuxiliarInventarios RepAuxiliarInventarios)
		{
            try
            {
                List<Entidades.RepAuxiliarInventarios> Result = Datos.Consultar<Entidades.RepAuxiliarInventarios>(RepAuxiliarInventarios,
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
