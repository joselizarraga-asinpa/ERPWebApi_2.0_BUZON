using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class EstadoPaisController: Controller
	{
		[HttpGet("{id}/{idpais}")]
		public JsonResult Get(Int32 id, Int16 idpais)
		{
			try
			{
				List<Entidades.EstadoPais> Result = Datos.Consultar<Entidades.EstadoPais>(new Entidades.EstadoPais()
				{
						ID = id
                        ,IDPAIS = idpais
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
				List<Entidades.EstadoPais> Result = Datos.Consultar<Entidades.EstadoPais>(new Entidades.EstadoPais()
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
		public string Post([FromBody]Entidades.EstadoPais EstadoPais)
		{
			try
			{
				return Datos.Nuevo<Entidades.EstadoPais>(EstadoPais, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.EstadoPais EstadoPais)
		{
			try
			{
				return Datos.Actualizar<Entidades.EstadoPais>(EstadoPais, null, Enumeradores.TypeAction.None);
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
				return Datos.Eliminar<Entidades.EstadoPais>(new Entidades.EstadoPais()
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
