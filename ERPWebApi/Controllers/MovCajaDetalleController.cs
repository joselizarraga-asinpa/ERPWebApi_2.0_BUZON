using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class MovCajaDetalleController: Controller
	{
		[HttpGet]
		public JsonResult Get()
		{
			try
			{
				List<Entidades.MovCajaDetalle> Result = Datos.Consultar<Entidades.MovCajaDetalle>(new Entidades.MovCajaDetalle()
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
				List<Entidades.MovCajaDetalle> Result = Datos.Consultar<Entidades.MovCajaDetalle>(new Entidades.MovCajaDetalle()
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
		public string Post([FromBody]Entidades.MovCajaDetalle MovCajaDetalle)
		{
			try
			{
				return Datos.Nuevo<Entidades.MovCajaDetalle>(MovCajaDetalle, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.MovCajaDetalle MovCajaDetalle)
		{
			try
			{
				return Datos.Actualizar<Entidades.MovCajaDetalle>(MovCajaDetalle, null, Enumeradores.TypeAction.None);
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
				return Datos.Eliminar<Entidades.MovCajaDetalle>(new Entidades.MovCajaDetalle()
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
