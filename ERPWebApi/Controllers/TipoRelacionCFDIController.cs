using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class TipoRelacionCFDIController: Controller
	{
				
		[HttpGet("{id}/{Ingreso}")]
		public JsonResult Get(Int16 id, String Ingreso)
		{
			try
			{
				List<Entidades.TipoRelacionCFDI> Result = Datos.Consultar<Entidades.TipoRelacionCFDI>(new Entidades.TipoRelacionCFDI()
				{
						 ID = id,
                         INGRESO = Ingreso
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
		public string Post([FromBody]Entidades.TipoRelacionCFDI TipoRelacionCFDI)
		{
			try
			{
				return Datos.Nuevo<Entidades.TipoRelacionCFDI>(TipoRelacionCFDI, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut("{id}")]
		public string Put(Int16 id, [FromBody]Entidades.TipoRelacionCFDI TipoRelacionCFDI)
		{
			try
			{
				return Datos.Actualizar<Entidades.TipoRelacionCFDI>(TipoRelacionCFDI, null, Enumeradores.TypeAction.None);
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
				return Datos.Eliminar<Entidades.TipoRelacionCFDI>(new Entidades.TipoRelacionCFDI()
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
