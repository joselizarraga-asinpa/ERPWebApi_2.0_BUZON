using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class SucursalController: Controller
	{		
		[HttpGet("{id}/{idempresa}")]
		public JsonResult Get(Int16 id, Int16 idempresa)
		{
			try
			{
				List<Entidades.Sucursal> Result = Datos.Consultar<Entidades.Sucursal>(new Entidades.Sucursal()
				{
						 ID = id
                         ,IDEMPRESA = idempresa
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
		public string Post([FromBody]Entidades.Sucursal Sucursal)
		{
			try
			{
				return Datos.Nuevo<Entidades.Sucursal>(Sucursal, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.Sucursal Sucursal)
		{
			try
			{
				return Datos.Actualizar<Entidades.Sucursal>(Sucursal, null, Enumeradores.TypeAction.None);
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
				return Datos.Eliminar<Entidades.Sucursal>(new Entidades.Sucursal()
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
