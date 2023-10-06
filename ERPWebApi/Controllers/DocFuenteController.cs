using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class DocFuenteController: Controller
	{		
		[HttpPost]
		public JsonResult Post([FromBody]Entidades.DocFuente DocFuente)
		{
			try
			{
                List<Entidades.DocFuente> Result = Datos.Consultar<Entidades.DocFuente>(DocFuente, new List<object>().ToArray());
                return Json(Result);
            }
			catch (Exception ex)
			{
				return Json(ex.Message);
			}
		}				
	}
}
