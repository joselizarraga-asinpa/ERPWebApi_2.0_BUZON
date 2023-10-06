using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class TipoAplicacionGenerarController: Controller
	{		
		[HttpGet("{id}")]
		public JsonResult Get(Int16 idtipoaplicacion)
		{
			try
			{
				List<Entidades.TipoAplicacionGenerar> Result = Datos.Consultar<Entidades.TipoAplicacionGenerar>(new Entidades.TipoAplicacionGenerar()
				{
						 IDTIPOAPLICACION = idtipoaplicacion
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
		public string Post([FromBody]Entidades.TipoAplicacionGenerar TipoAplicacionGenerar)
		{
			try
			{				
				return Datos.Nuevo<Entidades.TipoAplicacionGenerar>(TipoAplicacionGenerar, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.TipoAplicacionGenerar TipoAplicacionGenerar)
		{
			try
			{			
				return Datos.Actualizar<Entidades.TipoAplicacionGenerar>(TipoAplicacionGenerar, null, Enumeradores.TypeAction.None);
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
				return Datos.Eliminar<Entidades.TipoAplicacionGenerar>(new Entidades.TipoAplicacionGenerar()
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
