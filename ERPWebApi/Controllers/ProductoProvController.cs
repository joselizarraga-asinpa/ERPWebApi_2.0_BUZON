using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class ProductoProvController: Controller
	{
		[HttpGet]
		public JsonResult Get()
		{
			try
			{
				List<Entidades.ProductoProv> Result = Datos.Consultar<Entidades.ProductoProv>(new Entidades.ProductoProv()
				{
						 ID = 0
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

        [HttpGet("{idproducto}/{id}")]
        public JsonResult Get(Int32 idproducto, Int32 id)
		{
			try
			{
				List<Entidades.ProductoProv> Result = Datos.Consultar<Entidades.ProductoProv>(new Entidades.ProductoProv()
				{
                    ID = id,
                    IDPRODUCTO = idproducto
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
		public string Post([FromBody]Entidades.ProductoProv ProductoProv)
		{
			try
			{
				return Datos.Nuevo<Entidades.ProductoProv>(ProductoProv, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}

        [HttpPut]
        public string Put([FromBody]Entidades.ProductoProv ProductoProv)
		{
			try
			{
				return Datos.Actualizar<Entidades.ProductoProv>(ProductoProv, null, Enumeradores.TypeAction.None);
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
				return Datos.Eliminar<Entidades.ProductoProv>(new Entidades.ProductoProv()
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
