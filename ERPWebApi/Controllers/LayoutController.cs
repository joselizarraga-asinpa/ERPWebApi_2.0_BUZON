using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class LayoutController: Controller
	{
        [HttpGet("{id}/{importaexporta}")]
        public JsonResult Get(Int16 id, string importaexporta)
		{
			try
			{
                List<Entidades.Layout> Result = Datos.Consultar<Entidades.Layout>(new Entidades.Layout()
                {
                    ID = id
                    ,IMPORTAEXPORTA = importaexporta
                    ,IDPINCLIENTE = Datos.idPinCliente
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
		
		[HttpGet("{id}")]
		public JsonResult Get(Int16 id)
		{
			try
			{
				List<Entidades.Layout> Result = Datos.Consultar<Entidades.Layout>(new Entidades.Layout()
				{
						 ID = id
                         ,IDPINCLIENTE = Datos.idPinCliente
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
		public string Post([FromBody]Entidades.Layout Layout)
		{
			try
			{
				return Datos.Nuevo<Entidades.Layout>(Layout, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.Layout Layout)
		{
			try
			{
				return Datos.Actualizar<Entidades.Layout>(Layout, null, Enumeradores.TypeAction.None);
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
				return Datos.Eliminar<Entidades.Layout>(new Entidades.Layout()
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
