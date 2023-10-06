using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class SucursalConfigController: Controller
	{
				
		[HttpGet("{idsucursal}")]
		public JsonResult Get(Int16 idsucursal)
		{
			try
			{
				List<Entidades.SucursalConfig> Result = Datos.Consultar<Entidades.SucursalConfig>(new Entidades.SucursalConfig()
				{
						 IDSUCURSAL = idsucursal
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
		public string Post([FromBody]Entidades.SucursalConfig SucursalConfig)
		{
			try
			{
				return Datos.Nuevo<Entidades.SucursalConfig>(SucursalConfig, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.SucursalConfig SucursalConfig)
		{
			try
			{
				return Datos.Actualizar<Entidades.SucursalConfig>(SucursalConfig, null, Enumeradores.TypeAction.None);
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
				return Datos.Eliminar<Entidades.SucursalConfig>(new Entidades.SucursalConfig()
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
