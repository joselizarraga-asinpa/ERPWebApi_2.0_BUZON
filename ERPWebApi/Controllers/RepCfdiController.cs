using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class RepCfdiController: Controller
	{
				
		[HttpGet("{IdDocFiscal}")]
		public JsonResult Get(long IdDocFiscal)
		{
			try
			{
				List<Entidades.RepCfdi> Result = Datos.Consultar<Entidades.RepCfdi>(new Entidades.RepCfdi()
				{
                    IDDOCFISCAL = IdDocFiscal
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
