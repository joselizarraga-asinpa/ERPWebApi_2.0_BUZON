using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class RepSaldoInventariosController: Controller
	{
		
		[HttpPost]
		public JsonResult Post([FromBody]Entidades.RepSaldoInventarios RepSaldoInventarios)
		{
            try
            {
                List<Entidades.RepSaldoInventarios> Result = Datos.Consultar<Entidades.RepSaldoInventarios>(RepSaldoInventarios,
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
