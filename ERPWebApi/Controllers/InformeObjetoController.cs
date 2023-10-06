using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class InformeObjetoController: Controller
	{
		
		
		[HttpGet("{idinforme}")]
		public JsonResult Get(Int32 idinforme)
		{
			try
			{
				List<Entidades.InformeObjeto> Result = Datos.Consultar<Entidades.InformeObjeto>(new Entidades.InformeObjeto()
				{
						 ID = 0
						,IDINFORME = idinforme
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
		public string Post([FromBody]Entidades.InformeObjeto InformeObjeto)
		{
			try
			{
				return Datos.Nuevo<Entidades.InformeObjeto>(InformeObjeto, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.InformeObjeto InformeObjeto)
		{
			try
			{
				return Datos.Actualizar<Entidades.InformeObjeto>(InformeObjeto, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpDelete("{id}/{idinforme}")]
		public string Delete(Int32 id, Int32 idinforme)
		{
			try
			{
				return Datos.Eliminar<Entidades.InformeObjeto>(new Entidades.InformeObjeto()
				{
						 ID = id
						,IDINFORME = idinforme
				});
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
	}
}
