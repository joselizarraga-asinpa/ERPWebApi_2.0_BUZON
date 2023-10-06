using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class GraficaController: Controller
	{
		//[HttpGet]
		//public JsonResult Get()
		//{
		//	try
		//	{
		//		List<Entidades.Grafica> Result = Datos.Consultar<Entidades.Grafica>(new Entidades.Grafica()
		//		{
		//				 ID = 0
		//				,IDPINCLIENTE = Datos.idPinCliente
		//		},
		//		new List<object>().ToArray()
		//		);
		//		return Json(Result);
		//	}
		//	catch (Exception ex)
		//	{
		//		return Json(ex.Message);
		//	}
		//}
		
		[HttpGet("{idProceso}")]
		public JsonResult Get(Int16 idProceso)
		{
			try
			{
				List<Entidades.Grafica> Result = Datos.Consultar<Entidades.Grafica>(new Entidades.Grafica()
				{
						 ID = 0
                        ,IDPROCESO = idProceso
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
		public string Post([FromBody]Entidades.Grafica Grafica)
		{
			try
			{
				Grafica.IDPINCLIENTE = Datos.idPinCliente;
				return Datos.Nuevo<Entidades.Grafica>(Grafica, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.Grafica Grafica)
		{
			try
			{
				Grafica.IDPINCLIENTE = Datos.idPinCliente;
				return Datos.Actualizar<Entidades.Grafica>(Grafica, null, Enumeradores.TypeAction.None);
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
				return Datos.Eliminar<Entidades.Grafica>(new Entidades.Grafica()
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
