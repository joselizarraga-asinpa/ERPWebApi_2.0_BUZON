using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class UsuarioPreferenciaController: Controller
	{
				
		[HttpGet("{idusuario}/{idpreferencia}")]
		public JsonResult Get(Int16 idusuario, Int16 idpreferencia)
		{
			try
			{
				List<Entidades.UsuarioPreferencia> Result = Datos.Consultar<Entidades.UsuarioPreferencia>(new Entidades.UsuarioPreferencia()
				{
						 IDUSUARIO = idusuario
						,IDPREFERENCIA = idpreferencia
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
		public string Post([FromBody]Entidades.UsuarioPreferencia UsuarioPreferencia)
		{
			try
			{
				return Datos.Nuevo<Entidades.UsuarioPreferencia>(UsuarioPreferencia, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.UsuarioPreferencia UsuarioPreferencia)
		{
			try
			{
				return Datos.Actualizar<Entidades.UsuarioPreferencia>(UsuarioPreferencia, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
        
        [HttpDelete("{idusuario}/{idpreferencia}")]
		public string Delete(Int16 idusuario, Int16 idpreferencia)
		{
			try
			{
				return Datos.Eliminar<Entidades.UsuarioPreferencia>(new Entidades.UsuarioPreferencia()
				{
						 IDUSUARIO = idusuario
						,IDPREFERENCIA = idpreferencia
				});
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
	}
}
