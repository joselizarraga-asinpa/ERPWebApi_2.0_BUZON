using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class AplicacionDetController: Controller
	{
		
		[HttpGet("{idaplicacion}")]
		public JsonResult Get(Int64 idaplicacion)
		{
			try
			{
				List<Entidades.AplicacionDet> Result = Datos.Consultar<Entidades.AplicacionDet>(new Entidades.AplicacionDet()
				{
						 IDAPLICACION = idaplicacion
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
		public string Post([FromBody]Entidades.AplicacionDet AplicacionDet)
		{
			try
			{
				return Datos.Nuevo<Entidades.AplicacionDet>(AplicacionDet, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.AplicacionDet AplicacionDet)
		{
			try
			{
				return Datos.Actualizar<Entidades.AplicacionDet>(AplicacionDet, null, Enumeradores.TypeAction.None);
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
				return Datos.Eliminar<Entidades.AplicacionDet>(new Entidades.AplicacionDet()
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
