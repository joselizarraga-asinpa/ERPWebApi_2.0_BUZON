using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class IdiomaInterfazController: Controller
	{
				
		[HttpGet("{id}/{ididioma}/{idfuncionalidad}/{idaplicacion}/{referencia}")]
		public JsonResult Get(Int32 id, Int16 Ididioma, Int16 Idfuncionalidad, Int16 Idaplicacion, Int16 referencia)
		{
			try
			{
                List<Entidades.IdiomaInterfaz> Result = Datos.Consultar<Entidades.IdiomaInterfaz>(new Entidades.IdiomaInterfaz()
				{
						  ID = id
                         ,IDIDIOMA = Ididioma
                         ,IDFUNCIONALIDAD = Idfuncionalidad
                         ,IDAPLICACION = Idaplicacion
                         ,REFERENCIA = referencia
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
		public string Post([FromBody]Entidades.IdiomaInterfaz IdiomaInterfaz)
		{
			try
			{
				return Datos.Nuevo<Entidades.IdiomaInterfaz>(IdiomaInterfaz, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.IdiomaInterfaz IdiomaInterfaz)
		{
			try
			{
				return Datos.Actualizar<Entidades.IdiomaInterfaz>(IdiomaInterfaz, null, Enumeradores.TypeAction.None);
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
				return Datos.Eliminar<Entidades.IdiomaInterfaz>(new Entidades.IdiomaInterfaz()
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
