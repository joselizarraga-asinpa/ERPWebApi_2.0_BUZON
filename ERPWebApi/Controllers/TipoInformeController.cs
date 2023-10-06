using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class TipoInformeController: Controller
	{
		[HttpGet]
		public JsonResult Get()
		{
			try
			{
				List<Entidades.TipoInforme> Result = Datos.Consultar<Entidades.TipoInforme>(new Entidades.TipoInforme()
				{
						 ID = 0						
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
		
		[HttpGet("{id}")]
		public JsonResult Get(Int16 id)
		{
			try
			{
				List<Entidades.TipoInforme> Result = Datos.Consultar<Entidades.TipoInforme>(new Entidades.TipoInforme()
				{
						 ID = id						
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
		
		[HttpPost]
		public string Post([FromBody]Entidades.TipoInforme TipoInforme)
		{
			try
			{				
				return Datos.Nuevo<Entidades.TipoInforme>(TipoInforme, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.TipoInforme TipoInforme)
		{
			try
			{				
				return Datos.Actualizar<Entidades.TipoInforme>(TipoInforme, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpDelete("{id}")]
		public string Delete(Int16 id)
		{
			try
			{
				return Datos.Eliminar<Entidades.TipoInforme>(new Entidades.TipoInforme()
				{
						 ID = id						
				});
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
	}
}
