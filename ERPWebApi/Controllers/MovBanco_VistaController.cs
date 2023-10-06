using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class MovBanco_VistaController: Controller
	{
		
		[HttpPost]
		public JsonResult Post([FromBody]Entidades.MovBanco_Vista MovBanco_Vista)
		{
			try
			{
                List<Entidades.MovBanco_Vista> Result = Datos.Consultar<Entidades.MovBanco_Vista>(MovBanco_Vista,
                new List<object>().ToArray());
                return Json(Result);
            }
			catch (Exception ex)
			{
                return Json(ex.Message);
            }
		}		
		
	}
}
