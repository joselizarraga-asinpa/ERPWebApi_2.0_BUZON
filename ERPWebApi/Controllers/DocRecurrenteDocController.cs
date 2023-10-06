using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class DocRecurrenteDocController: Controller
	{
		[HttpGet]
		public JsonResult Get()
		{
			try
			{
				List<Entidades.DocRecurrenteDoc> Result = Datos.Consultar<Entidades.DocRecurrenteDoc>(new Entidades.DocRecurrenteDoc()
				{
						 IDDOCRECURRENTE = 0
						,IDDOCUMENTO = 0
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
		
		[HttpGet("{iddocrecurrente}/{iddocumento}")]
		public JsonResult Get(Int32 iddocrecurrente, Int64 iddocumento)
		{
			try
			{
				List<Entidades.DocRecurrenteDoc> Result = Datos.Consultar<Entidades.DocRecurrenteDoc>(new Entidades.DocRecurrenteDoc()
				{
						 IDDOCRECURRENTE = iddocrecurrente
						,IDDOCUMENTO = iddocumento
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
		public string Post([FromBody]Entidades.DocRecurrenteDoc DocRecurrenteDoc)
		{
			try
			{
				return Datos.Nuevo<Entidades.DocRecurrenteDoc>(DocRecurrenteDoc, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.DocRecurrenteDoc DocRecurrenteDoc)
		{
			try
			{
				return Datos.Actualizar<Entidades.DocRecurrenteDoc>(DocRecurrenteDoc, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpDelete("{iddocrecurrente}/{iddocumento}")]
		public string Delete(Int32 iddocrecurrente, Int64 iddocumento)
		{
			try
			{
				return Datos.Eliminar<Entidades.DocRecurrenteDoc>(new Entidades.DocRecurrenteDoc()
				{
						 IDDOCRECURRENTE = iddocrecurrente
						,IDDOCUMENTO = iddocumento
				});
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
	}
}
