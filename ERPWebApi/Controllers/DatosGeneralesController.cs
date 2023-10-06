using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class DatosGeneralesController: Controller
	{
		[HttpGet]
		public JsonResult Get()
		{
			try
			{
				List<Entidades.DatosGenerales> Result = Datos.Consultar<Entidades.DatosGenerales>(new Entidades.DatosGenerales()
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
				List<Entidades.DatosGenerales> Result = Datos.Consultar<Entidades.DatosGenerales>(new Entidades.DatosGenerales()
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
		public string Post([FromBody]Entidades.DatosGenerales DatosGenerales)
		{
			try
			{
				return Datos.Nuevo<Entidades.DatosGenerales>(DatosGenerales, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.DatosGenerales DatosGenerales)
		{
			try
			{
				return Datos.Actualizar<Entidades.DatosGenerales>(DatosGenerales, null, Enumeradores.TypeAction.None);
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
				return Datos.Eliminar<Entidades.DatosGenerales>(new Entidades.DatosGenerales()
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
