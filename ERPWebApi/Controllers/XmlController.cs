using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class XmlController: Controller
	{
				
		[HttpGet("{iddocfiscal}")]
		public JsonResult Get(Int64 iddocfiscal)
		{
			try
			{
				List<Entidades.Xml> Result = Datos.Consultar<Entidades.Xml>(new Entidades.Xml()
				{
						 IDDOCFISCAL = iddocfiscal
                },
				new List<object>().ToArray(),
                Conexiones.SqlServer.conexionTimbrado
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
