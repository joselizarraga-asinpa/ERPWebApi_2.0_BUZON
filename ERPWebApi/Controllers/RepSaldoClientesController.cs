using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class RepSaldoClientesController: Controller
	{
				
		[HttpPost]
		public JsonResult Post([FromBody]Entidades.RepSaldoClientes RepSaldoClientes)
		{
            try
            {
                List<Entidades.RepSaldoClientes> Result = Datos.Consultar<Entidades.RepSaldoClientes>(RepSaldoClientes,
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
