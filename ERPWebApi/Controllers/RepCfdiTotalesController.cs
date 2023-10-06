using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class RepCfdiTotalesController: Controller
	{
				
		[HttpGet("{IdDocFiscal}")]
		public JsonResult Get(long IdDocFiscal)
		{
			try
			{
				List<Entidades.RepCfdiTotales> Result = Datos.Consultar<Entidades.RepCfdiTotales>(new Entidades.RepCfdiTotales()
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
