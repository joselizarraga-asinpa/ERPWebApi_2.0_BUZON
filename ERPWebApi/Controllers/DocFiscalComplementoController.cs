using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class DocFiscalComplementoController: Controller
	{
		[HttpGet]
		public JsonResult Get()
		{
			try
			{
				List<Entidades.DocFiscalComplemento> Result = Datos.Consultar<Entidades.DocFiscalComplemento>(new Entidades.DocFiscalComplemento()
				{
						ID = 0
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
		
		[HttpGet("{id}/{iddocfiscalcomppadre}/{iddocfiscal}/{componentes}")]
		public JsonResult Get(Int32 Id, Int32 IdDocFiscalCompPadre, long IdDocFiscal, bool Componentes)
		{
			try
			{
				List<Entidades.DocFiscalComplemento> Result = Datos.Consultar<Entidades.DocFiscalComplemento>(new Entidades.DocFiscalComplemento()
				{
						 ID = Id
                         ,IDDOCFISCALCOMPPADRE = IdDocFiscalCompPadre
                         ,IDDOCFISCAL = IdDocFiscal
                         ,COMPONENTES = Componentes
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
		public string Post([FromBody]Entidades.DocFiscalComplemento DocFiscalComplemento)
		{
			try
			{
				return Datos.Nuevo<Entidades.DocFiscalComplemento>(DocFiscalComplemento, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.DocFiscalComplemento DocFiscalComplemento)
		{
			try
			{
				return Datos.Actualizar<Entidades.DocFiscalComplemento>(DocFiscalComplemento, null, Enumeradores.TypeAction.None);
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
				return Datos.Eliminar<Entidades.DocFiscalComplemento>(new Entidades.DocFiscalComplemento()
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
