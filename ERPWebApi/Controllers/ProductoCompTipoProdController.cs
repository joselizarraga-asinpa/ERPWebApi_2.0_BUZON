using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class ProductoCompTipoProdController: Controller
	{
		//[HttpGet]
		//public JsonResult Get()
		//{
		//	try
		//	{
		//		List<Entidades.ProductoCompTipoProd> Result = Datos.Consultar<Entidades.ProductoCompTipoProd>(new Entidades.ProductoCompTipoProd()
		//		{
		//				 IDPRODUCTO = 0
		//				,IDTIPOPRODUCTO = 0
		//		},
		//		new List<object>().ToArray()
		//		);
		//		return Json(Result);
		//	}
		//	catch (Exception ex)
		//	{
		//		return Json(ex.Message);
		//	}
		//}
		
		[HttpGet("{idproducto}/{idtipoproducto}")]
		public JsonResult Get(Int32 idproducto, Int16 idtipoproducto)
		{
			try
			{
				List<Entidades.ProductoCompTipoProd> Result = Datos.Consultar<Entidades.ProductoCompTipoProd>(new Entidades.ProductoCompTipoProd()
				{
						 IDPRODUCTO = idproducto
						,IDTIPOPRODUCTO = idtipoproducto
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
		public string Post([FromBody]Entidades.ProductoCompTipoProd ProductoCompTipoProd)
		{
			try
			{
				return Datos.Nuevo<Entidades.ProductoCompTipoProd>(ProductoCompTipoProd, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.ProductoCompTipoProd ProductoCompTipoProd)
		{
			try
			{
				return Datos.Actualizar<Entidades.ProductoCompTipoProd>(ProductoCompTipoProd, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpDelete("{idproducto}/{idtipoproducto}")]
		public string Delete(Int32 idproducto, Int16 idtipoproducto)
		{
			try
			{
				return Datos.Eliminar<Entidades.ProductoCompTipoProd>(new Entidades.ProductoCompTipoProd()
				{
						 IDPRODUCTO = idproducto
						,IDTIPOPRODUCTO = idtipoproducto
				});
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
	}
}
