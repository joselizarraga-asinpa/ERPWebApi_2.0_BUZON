using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class GrupoAplicacionController: Controller
	{
		[HttpGet]
		public JsonResult Get()
		{
			try
			{
				List<Entidades.GrupoAplicacion> Result = Datos.Consultar<Entidades.GrupoAplicacion>(new Entidades.GrupoAplicacion()
				{
						 ID = 0
						,IDPINCLIENTE = Datos.idPinCliente
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
				List<Entidades.GrupoAplicacion> Result = Datos.Consultar<Entidades.GrupoAplicacion>(new Entidades.GrupoAplicacion()
				{
						 ID = id
						,IDPINCLIENTE = Datos.idPinCliente
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
		public string Post([FromBody]Entidades.GrupoAplicacion GrupoAplicacion)
		{
			try
			{
				GrupoAplicacion.IDPINCLIENTE = Datos.idPinCliente;
				return Datos.Nuevo<Entidades.GrupoAplicacion>(GrupoAplicacion, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.GrupoAplicacion GrupoAplicacion)
		{
			try
			{
				GrupoAplicacion.IDPINCLIENTE = Datos.idPinCliente;
				return Datos.Actualizar<Entidades.GrupoAplicacion>(GrupoAplicacion, null, Enumeradores.TypeAction.None);
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
				return Datos.Eliminar<Entidades.GrupoAplicacion>(new Entidades.GrupoAplicacion()
				{
						 ID = id
						,IDPINCLIENTE = Datos.idPinCliente
				});
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
	}
}
