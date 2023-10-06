using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class ImagenDetController: Controller
	{
        [HttpGet("{id}")]
        public JsonResult Get(Int32 id)
		{
			try
			{
				List<Entidades.ImagenDet> Result = Datos.Consultar<Entidades.ImagenDet>(new Entidades.ImagenDet()
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

        [HttpGet("{idfuncionalidad}/{idref}")]
        public JsonResult Get(Int16 idfuncionalidad, long idref)
		{
			try
			{
				List<Entidades.ImagenDet> Result = Datos.Consultar<Entidades.ImagenDet>(new Entidades.ImagenDet()
				{
						 ID = 0,
                         IDFUNCIONALIDAD = idfuncionalidad,
                         IDREF = idref
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
		public string Post([FromBody]Entidades.ImagenDet ImagenDet)
		{
			try
			{
				return Datos.Nuevo<Entidades.ImagenDet>(ImagenDet, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.ImagenDet ImagenDet)
		{
			try
			{
				return Datos.Actualizar<Entidades.ImagenDet>(ImagenDet, null, Enumeradores.TypeAction.None);
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
				return Datos.Eliminar<Entidades.ImagenDet>(new Entidades.ImagenDet()
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
