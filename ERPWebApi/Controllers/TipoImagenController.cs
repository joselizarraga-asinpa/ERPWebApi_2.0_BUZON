using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class TipoImagenController: Controller
	{
		[HttpGet]
		public JsonResult Get()
		{
			try
			{
				List<Entidades.TipoImagen> Result = Datos.Consultar<Entidades.TipoImagen>(new Entidades.TipoImagen()
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
				List<Entidades.TipoImagen> Result = Datos.Consultar<Entidades.TipoImagen>(new Entidades.TipoImagen()
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
		public string Post([FromBody]Entidades.TipoImagen TipoImagen)
		{
			try
			{
				return Datos.Nuevo<Entidades.TipoImagen>(TipoImagen, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.TipoImagen TipoImagen)
		{
			try
			{
				return Datos.Actualizar<Entidades.TipoImagen>(TipoImagen, null, Enumeradores.TypeAction.None);
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
				return Datos.Eliminar<Entidades.TipoImagen>(new Entidades.TipoImagen()
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
