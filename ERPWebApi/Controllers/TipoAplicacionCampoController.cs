using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class TipoAplicacionCampoController: Controller
	{
        [HttpGet("{idtipoaplicacion}")]
        public JsonResult Get(Int16 idtipoaplicacion)
		{
			try
			{
				List<Entidades.TipoAplicacionCampo> Result = Datos.Consultar<Entidades.TipoAplicacionCampo>(new Entidades.TipoAplicacionCampo()
				{
						 ID = 0						
                         ,IDTIPOAPLICACION = idtipoaplicacion
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
		public string Post([FromBody]Entidades.TipoAplicacionCampo TipoAplicacionCampo)
		{
			try
			{				
				return Datos.Nuevo<Entidades.TipoAplicacionCampo>(TipoAplicacionCampo, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.TipoAplicacionCampo TipoAplicacionCampo)
		{
			try
			{				
				return Datos.Actualizar<Entidades.TipoAplicacionCampo>(TipoAplicacionCampo, null, Enumeradores.TypeAction.None);
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
				return Datos.Eliminar<Entidades.TipoAplicacionCampo>(new Entidades.TipoAplicacionCampo()
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
