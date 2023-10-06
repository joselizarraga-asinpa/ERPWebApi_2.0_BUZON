using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class MovCaja_SaldosController: Controller
	{
		
		[HttpGet("{id}/{idCliProv}/{NoDocumento}")]
		public JsonResult Get(Int64 id, Int32 idCliProv, string NoDocumento)
		{
			try
			{
				List<Entidades.MovCaja_Saldos> Result = Datos.Consultar<Entidades.MovCaja_Saldos>(new Entidades.MovCaja_Saldos()
				{
						  ID = id
                         ,IDCLIPROV = idCliProv
                         ,NODOCUMENTO= NoDocumento
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


		
		//[HttpPost]
		//public string Post([FromBody]Entidades.MovCaja_Saldos MovCaja_Saldos)
		//{
		//	try
		//	{
		//		return Datos.Nuevo<Entidades.MovCaja_Saldos>(MovCaja_Saldos, null, Enumeradores.TypeAction.None);
		//	}
		//	catch (Exception ex)
		//	{
		//		return ex.Message;
		//	}
		//}
		
		//[HttpPut]
		//public string Put([FromBody]Entidades.MovCaja_Saldos MovCaja_Saldos)
		//{
		//	try
		//	{
		//		return Datos.Actualizar<Entidades.MovCaja_Saldos>(MovCaja_Saldos, null, Enumeradores.TypeAction.None);
		//	}
		//	catch (Exception ex)
		//	{
		//		return ex.Message;
		//	}
		//}
		
		//[HttpDelete("{id}")]
		//public string Delete(Int64 id)
		//{
		//	try
		//	{
		//		return Datos.Eliminar<Entidades.MovCaja_Saldos>(new Entidades.MovCaja_Saldos()
		//		{
		//				 ID = id
		//		});
		//	}
		//	catch (Exception ex)
		//	{
		//		return ex.Message;
		//	}
		//}
	}
}
