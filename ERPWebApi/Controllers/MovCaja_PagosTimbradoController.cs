using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class MovCaja_PagosTimbradoController: Controller
	{
		
		
		[HttpGet("{Id}")]
		public JsonResult Get(long id)
		{
			try
			{
				List<Entidades.MovCaja_PagosTimbrado> Result = Datos.Consultar<Entidades.MovCaja_PagosTimbrado>(new Entidades.MovCaja_PagosTimbrado()
				{
                    ID = id
				},
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
