using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class DocFiscalCompDetController: Controller
	{
        [HttpGet("{id}/{iddocfiscal}")]
        public JsonResult Get(Int64 id, long iddocfiscal)
		{
			try
			{
				List<Entidades.DocFiscalCompDet> Result = Datos.Consultar<Entidades.DocFiscalCompDet>(new Entidades.DocFiscalCompDet()
				{
						 ID = id
                         ,IDDOCFISCAL = iddocfiscal
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
		public JsonResult Get(Int64 id)
		{
			try
			{
				List<Entidades.DocFiscalCompDet> Result = Datos.Consultar<Entidades.DocFiscalCompDet>(new Entidades.DocFiscalCompDet()
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
		public string Post([FromBody]Entidades.DocFiscalCompDet DocFiscalCompDet)
		{
			try
			{
				return Datos.Nuevo<Entidades.DocFiscalCompDet>(DocFiscalCompDet, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.DocFiscalCompDet DocFiscalCompDet)
		{
			try
			{
				return Datos.Actualizar<Entidades.DocFiscalCompDet>(DocFiscalCompDet, null, Enumeradores.TypeAction.None);
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
				return Datos.Eliminar<Entidades.DocFiscalCompDet>(new Entidades.DocFiscalCompDet()
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
