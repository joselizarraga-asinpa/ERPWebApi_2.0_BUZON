using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class MovBanco_CuentasController: Controller
	{
		[HttpGet]
		public JsonResult Get()
		{
			try
			{
				List<Entidades.MovBanco_Cuentas> Result = Datos.Consultar<Entidades.MovBanco_Cuentas>(new Entidades.MovBanco_Cuentas()
				{
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
