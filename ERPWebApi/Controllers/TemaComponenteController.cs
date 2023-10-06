using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class TemaComponenteController: Controller
	{
		[HttpGet]
		public JsonResult Get()
		{
			try
			{
				List<Entidades.TemaComponente> Result = Datos.Consultar<Entidades.TemaComponente>(new Entidades.TemaComponente()
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
				List<Entidades.TemaComponente> Result = Datos.Consultar<Entidades.TemaComponente>(new Entidades.TemaComponente()
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
		public string Post([FromBody]Entidades.TemaComponente TemaComponente)
		{
			try
			{
				return Datos.Nuevo<Entidades.TemaComponente>(TemaComponente, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.TemaComponente TemaComponente)
		{
			try
			{
				return Datos.Actualizar<Entidades.TemaComponente>(TemaComponente, null, Enumeradores.TypeAction.None);
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
				return Datos.Eliminar<Entidades.TemaComponente>(new Entidades.TemaComponente()
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
