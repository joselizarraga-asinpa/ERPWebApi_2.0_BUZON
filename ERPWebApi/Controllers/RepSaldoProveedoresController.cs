using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class RepSaldoProveedoresController: Controller
	{
		
		
		[HttpPost]
		public JsonResult Post([FromBody]Entidades.RepSaldoProveedores RepSaldoProveedores)
		{
            try
            {
                List<Entidades.RepSaldoProveedores> Result = Datos.Consultar<Entidades.RepSaldoProveedores>(RepSaldoProveedores,
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
