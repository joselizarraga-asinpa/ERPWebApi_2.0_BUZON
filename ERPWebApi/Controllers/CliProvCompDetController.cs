using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class CliProvCompDetController: Controller
	{
		
		[HttpGet("{idcliprov}")]
		public JsonResult Get(Int32 idcliprov)
		{
			try
			{
				List<Entidades.CliProvCompDet> Result = Datos.Consultar<Entidades.CliProvCompDet>(new Entidades.CliProvCompDet()
				{
						 IDCLIPROV = idcliprov
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
		public string Post([FromBody]Entidades.CliProvCompDet CliProvCompDet)
		{
			try
			{
				return Datos.Nuevo<Entidades.CliProvCompDet>(CliProvCompDet, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.CliProvCompDet CliProvCompDet)
		{
			try
			{
				return Datos.Actualizar<Entidades.CliProvCompDet>(CliProvCompDet, null, Enumeradores.TypeAction.None);
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
				return Datos.Eliminar<Entidades.CliProvCompDet>(new Entidades.CliProvCompDet()
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
