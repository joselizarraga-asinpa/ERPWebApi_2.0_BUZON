using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class TipoDocSucursalController: Controller
	{
		[HttpGet]
		public JsonResult Get()
		{
			try
			{
				List<Entidades.TipoDocSucursal> Result = Datos.Consultar<Entidades.TipoDocSucursal>(new Entidades.TipoDocSucursal()
				{
						 IDTIPODOCUMENTO = 0
						,IDSUCURSAL = 0
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
		
		[HttpGet("{idtipodocumento}/{idsucursal}")]
		public JsonResult Get(Int16 idtipodocumento, Int16 idsucursal)
		{
			try
			{
				List<Entidades.TipoDocSucursal> Result = Datos.Consultar<Entidades.TipoDocSucursal>(new Entidades.TipoDocSucursal()
				{
						 IDTIPODOCUMENTO = idtipodocumento
						,IDSUCURSAL = idsucursal
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
		public string Post([FromBody]Entidades.TipoDocSucursal TipoDocSucursal)
		{
			try
			{
				return Datos.Nuevo<Entidades.TipoDocSucursal>(TipoDocSucursal, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.TipoDocSucursal TipoDocSucursal)
		{
			try
			{
				return Datos.Actualizar<Entidades.TipoDocSucursal>(TipoDocSucursal, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpDelete("{idtipodocumento}/{idsucursal}")]
		public string Delete(Int16 idtipodocumento, Int16 idsucursal)
		{
			try
			{
				return Datos.Eliminar<Entidades.TipoDocSucursal>(new Entidades.TipoDocSucursal()
				{
						 IDTIPODOCUMENTO = idtipodocumento
						,IDSUCURSAL = idsucursal
				});
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
	}
}
