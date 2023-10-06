using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class TemaController: Controller
	{
		[HttpGet]
		public JsonResult Get()
		{
			try
			{
				List<Entidades.Tema> Result = Datos.Consultar<Entidades.Tema>(new Entidades.Tema()
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
				List<Entidades.Tema> Result = Datos.Consultar<Entidades.Tema>(new Entidades.Tema()
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
		public string Post([FromBody]Entidades.Tema Tema)
		{
			try
			{
				Tema.IDPINCLIENTE = Datos.idPinCliente;
				return Datos.Nuevo<Entidades.Tema>(Tema, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.Tema Tema)
		{
			try
			{
				Tema.IDPINCLIENTE = Datos.idPinCliente;
				return Datos.Actualizar<Entidades.Tema>(Tema, null, Enumeradores.TypeAction.None);
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
				return Datos.Eliminar<Entidades.Tema>(new Entidades.Tema()
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
