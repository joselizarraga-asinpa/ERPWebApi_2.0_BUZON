using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class CliProvCondicionController: Controller
	{
        [HttpGet("{id}/{idcliprov}")]
        public JsonResult Get(int id, int idcliprov)
		{
			try
			{
				List<Entidades.CliProvCondicion> Result = Datos.Consultar<Entidades.CliProvCondicion>(new Entidades.CliProvCondicion()
				{
						 ID = id,
                         IDCLIPROV = idcliprov
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
		public JsonResult Get(Int32 id)
		{
			try
			{
				List<Entidades.CliProvCondicion> Result = Datos.Consultar<Entidades.CliProvCondicion>(new Entidades.CliProvCondicion()
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
		public string Post([FromBody]Entidades.CliProvCondicion CliProvCondicion)
		{
			try
			{
				return Datos.Nuevo<Entidades.CliProvCondicion>(CliProvCondicion, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.CliProvCondicion CliProvCondicion)
		{
			try
			{
				return Datos.Actualizar<Entidades.CliProvCondicion>(CliProvCondicion, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpDelete("{id}")]
		public string Delete(Int32 id)
		{
			try
			{
				return Datos.Eliminar<Entidades.CliProvCondicion>(new Entidades.CliProvCondicion()
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
