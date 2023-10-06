using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class ProcesoDetRelacionController: Controller
	{
		[HttpGet]
		public JsonResult Get()
		{
			try
			{
				List<Entidades.ProcesoDetRelacion> Result = Datos.Consultar<Entidades.ProcesoDetRelacion>(new Entidades.ProcesoDetRelacion()
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
				List<Entidades.ProcesoDetRelacion> Result = Datos.Consultar<Entidades.ProcesoDetRelacion>(new Entidades.ProcesoDetRelacion()
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
		public string Post([FromBody]Entidades.ProcesoDetRelacion ProcesoDetRelacion)
		{
			try
			{				
				return Datos.Nuevo<Entidades.ProcesoDetRelacion>(ProcesoDetRelacion, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.ProcesoDetRelacion ProcesoDetRelacion)
		{
			try
			{				
				return Datos.Actualizar<Entidades.ProcesoDetRelacion>(ProcesoDetRelacion, null, Enumeradores.TypeAction.None);
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
				return Datos.Eliminar<Entidades.ProcesoDetRelacion>(new Entidades.ProcesoDetRelacion()
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
