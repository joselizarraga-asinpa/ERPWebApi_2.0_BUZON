using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class LayoutDetController: Controller
	{
		
		
		[HttpGet("{IdLayout}")]
		public JsonResult Get(Int16 IdLayout)
		{
			try
			{
				List<Entidades.LayoutDet> Result = Datos.Consultar<Entidades.LayoutDet>(new Entidades.LayoutDet()
				{
						 IDLAYOUT = IdLayout
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
		public string Post([FromBody]Entidades.LayoutDet LayoutDet)
		{
			try
			{
				return Datos.Nuevo<Entidades.LayoutDet>(LayoutDet, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.LayoutDet LayoutDet)
		{
			try
			{
				return Datos.Actualizar<Entidades.LayoutDet>(LayoutDet, null, Enumeradores.TypeAction.None);
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
				return Datos.Eliminar<Entidades.LayoutDet>(new Entidades.LayoutDet()
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
