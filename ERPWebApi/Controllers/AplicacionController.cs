using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class AplicacionController: Controller
	{
		[HttpGet]
		public JsonResult Get()
		{
			try
			{
				List<Entidades.Aplicacion> Result = Datos.Consultar<Entidades.Aplicacion>(new Entidades.Aplicacion()
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
		public JsonResult Get(Int64 id)
		{
			try
			{
				List<Entidades.Aplicacion> Result = Datos.Consultar<Entidades.Aplicacion>(new Entidades.Aplicacion()
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
		public string Post([FromBody]Entidades.Aplicacion Aplicacion)
		{
			try
			{
				return Datos.Nuevo<Entidades.Aplicacion>(Aplicacion, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.Aplicacion Aplicacion)
		{
			try
			{
				return Datos.Actualizar<Entidades.Aplicacion>(Aplicacion, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpDelete("{id}")]
		public string Delete(Int64 id)
		{
			try
			{
				return Datos.Eliminar<Entidades.Aplicacion>(new Entidades.Aplicacion()
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
