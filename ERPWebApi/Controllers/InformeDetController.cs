using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class InformeDetController: Controller
	{
		[HttpGet("{id}/{idinforme}")]
        public JsonResult Get(Int32 id, Int32 idInforme)
		{
			try
			{
				List<Entidades.InformeDet> Result = Datos.Consultar<Entidades.InformeDet>(new Entidades.InformeDet()
				{
						 ID = id,
                         IDINFORME = idInforme
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
		public JsonResult Get(Int32 id)
		{
			try
			{
				List<Entidades.InformeDet> Result = Datos.Consultar<Entidades.InformeDet>(new Entidades.InformeDet()
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
		public string Post([FromBody]Entidades.InformeDet InformeDet)
		{
			try
			{				
				return Datos.Nuevo<Entidades.InformeDet>(InformeDet, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.InformeDet InformeDet)
		{
			try
			{				
				return Datos.Actualizar<Entidades.InformeDet>(InformeDet, null, Enumeradores.TypeAction.None);
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
				return Datos.Eliminar<Entidades.InformeDet>(new Entidades.InformeDet()
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
