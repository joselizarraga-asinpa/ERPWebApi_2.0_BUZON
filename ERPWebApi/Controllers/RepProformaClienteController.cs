using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class RepProformaClienteController: Controller
	{
		
		[HttpPost]
		public JsonResult Post([FromBody]Entidades.RepProformaCliente RepProformaCliente)
		{
			try
			{
                List<Entidades.RepProformaCliente> Result = Datos.Consultar<Entidades.RepProformaCliente>(RepProformaCliente,
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
