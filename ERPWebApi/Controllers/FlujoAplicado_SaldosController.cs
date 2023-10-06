using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class FlujoAplicado_SaldosController: Controller
	{
		
		[HttpGet("{idcuentabanco}")]
		public JsonResult Get(Int16 idcuentabanco)
		{
			try
			{
				List<Entidades.FlujoAplicado_Saldos> Result = Datos.Consultar<Entidades.FlujoAplicado_Saldos>(new Entidades.FlujoAplicado_Saldos()
				{
                    IDCUENTABANCO = idcuentabanco
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
