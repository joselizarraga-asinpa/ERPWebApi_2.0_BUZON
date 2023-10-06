using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class ListaPrecioCliProvController: Controller
	{
		
		[HttpGet("{idlistaprecio}/{idcliprov}")]
		public JsonResult Get(Int16 idlistaprecio, Int32 idcliprov)
		{
			try
			{
				List<Entidades.ListaPrecioCliProv> Result = Datos.Consultar<Entidades.ListaPrecioCliProv>(new Entidades.ListaPrecioCliProv()
				{
						 IDLISTAPRECIO = idlistaprecio
						,IDCLIPROV = idcliprov
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
		public string Post([FromBody]Entidades.ListaPrecioCliProv ListaPrecioCliProv)
		{
			try
			{
				return Datos.Nuevo<Entidades.ListaPrecioCliProv>(ListaPrecioCliProv, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.ListaPrecioCliProv ListaPrecioCliProv)
		{
			try
			{
				return Datos.Actualizar<Entidades.ListaPrecioCliProv>(ListaPrecioCliProv, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpDelete("{idlistaprecio}/{idcliprov}")]
		public string Delete(Int16 idlistaprecio, Int32 idcliprov)
		{
			try
			{
				return Datos.Eliminar<Entidades.ListaPrecioCliProv>(new Entidades.ListaPrecioCliProv()
				{
						 IDLISTAPRECIO = idlistaprecio
						,IDCLIPROV = idcliprov
				});
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
	}
}
