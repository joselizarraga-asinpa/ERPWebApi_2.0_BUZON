using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class ProcesoMatrizController: Controller
	{
		
		[HttpGet("{IdProceso}")]
		public JsonResult Get(Int16 IdProceso)
		{
			try
			{
				List<Entidades.ProcesoMatriz> Result = Datos.Consultar<Entidades.ProcesoMatriz>(new Entidades.ProcesoMatriz()
				{
                        IDPROCESO = IdProceso,
						IDPINCLIENTE = Datos.idPinCliente
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
