using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class DocFiscalRelController: Controller
	{
				
		[HttpGet("{iddocfiscal}")]
		public JsonResult Get(Int64 iddocfiscal)
		{
			try
			{
				List<Entidades.DocFiscalRel> Result = Datos.Consultar<Entidades.DocFiscalRel>(new Entidades.DocFiscalRel()
				{
						 IDDOCFISCAL = iddocfiscal
						,IDDOCFISCALREL = 0
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
		public string Post([FromBody]Entidades.DocFiscalRel DocFiscalRel)
		{
			try
			{
				return Datos.Nuevo<Entidades.DocFiscalRel>(DocFiscalRel, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.DocFiscalRel DocFiscalRel)
		{
			try
			{
				return Datos.Actualizar<Entidades.DocFiscalRel>(DocFiscalRel, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpDelete("{iddocfiscal}/{iddocfiscalrel}")]
		public string Delete(Int64 iddocfiscal, Int64 iddocfiscalrel)
		{
			try
			{
				return Datos.Eliminar<Entidades.DocFiscalRel>(new Entidades.DocFiscalRel()
				{
						 IDDOCFISCAL = iddocfiscal
						,IDDOCFISCALREL = iddocfiscalrel
				});
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
	}
}
