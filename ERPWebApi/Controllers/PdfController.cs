using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de c�digo
	[Route("api/[controller]")]
	public class PdfController: Controller
	{		
		
		[HttpGet("{iddocfiscal}")]
		public JsonResult Get(Int64 iddocfiscal)
		{
			try
			{
				List<Entidades.Pdf> Result = Datos.Consultar<Entidades.Pdf>(new Entidades.Pdf()
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
