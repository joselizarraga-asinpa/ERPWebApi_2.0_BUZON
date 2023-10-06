using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class ProcesoCosteoController: Controller
	{	
		
		[HttpPost]
		public string Post([FromBody]Entidades.ProcesoCosteo ProcesoCosteo)
		{
			try
			{
				return Datos.Nuevo<Entidades.ProcesoCosteo>(ProcesoCosteo, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
	}
}
