using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class CfdiDescargaMasivaController: Controller
	{
		[HttpGet("{estadosolicitud}/{pendientes}")]
		public JsonResult Get(Int16 estadosolicitud, bool pendientes)
		{
			try
			{
				List<Entidades.CfdiDescargaMasiva> Result = Datos.Consultar<Entidades.CfdiDescargaMasiva>(new Entidades.CfdiDescargaMasiva()
				{
						 ID = 0,
                         ESTADOSOLICITUD = estadosolicitud,
                         PENDIENTES = pendientes
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
				List<Entidades.CfdiDescargaMasiva> Result = Datos.Consultar<Entidades.CfdiDescargaMasiva>(new Entidades.CfdiDescargaMasiva()
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
		public string Post([FromBody]Entidades.CfdiDescargaMasiva CfdiDescargaMasiva)
		{
			try
			{
				return Datos.Nuevo<Entidades.CfdiDescargaMasiva>(CfdiDescargaMasiva, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.CfdiDescargaMasiva CfdiDescargaMasiva)
		{
			try
			{
				return Datos.Actualizar<Entidades.CfdiDescargaMasiva>(CfdiDescargaMasiva, null, Enumeradores.TypeAction.None);
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
				return Datos.Eliminar<Entidades.CfdiDescargaMasiva>(new Entidades.CfdiDescargaMasiva()
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
