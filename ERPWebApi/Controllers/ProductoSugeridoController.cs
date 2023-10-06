using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class ProductoSugeridoController: Controller
	{
		
		[HttpGet("{idproducto}/{idproductosugerido}")]
		public JsonResult Get(Int32 idproducto, Int32 idproductosugerido)
		{
			try
			{
				List<Entidades.ProductoSugerido> Result = Datos.Consultar<Entidades.ProductoSugerido>(new Entidades.ProductoSugerido()
				{
						 IDPRODUCTO = idproducto
						,IDPRODUCTOSUGERIDO = idproductosugerido
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
		public string Post([FromBody]Entidades.ProductoSugerido ProductoSugerido)
		{
			try
			{
				return Datos.Nuevo<Entidades.ProductoSugerido>(ProductoSugerido, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.ProductoSugerido ProductoSugerido)
		{
			try
			{
				return Datos.Actualizar<Entidades.ProductoSugerido>(ProductoSugerido, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpDelete("{idproducto}/{idproductosugerido}")]
		public string Delete(Int32 idproducto, Int32 idproductosugerido)
		{
			try
			{
				return Datos.Eliminar<Entidades.ProductoSugerido>(new Entidades.ProductoSugerido()
				{
						 IDPRODUCTO = idproducto
						,IDPRODUCTOSUGERIDO = idproductosugerido
				});
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
	}
}
