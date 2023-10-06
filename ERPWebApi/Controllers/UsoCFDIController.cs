using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class UsoCFDIController: Controller
	{
		[HttpGet]
		public JsonResult Get()
		{
			try
			{
				List<Entidades.UsoCFDI> Result = Datos.Consultar<Entidades.UsoCFDI>(new Entidades.UsoCFDI()
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

        [HttpGet("{id}")]
        public JsonResult Get(Int16 id)
        {
            try
            {
                List<Entidades.UsoCFDI> Result = Datos.Consultar<Entidades.UsoCFDI>(new Entidades.UsoCFDI()
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

        [HttpGet("{id}/{aplicafisica}/{aplicamoral}")]
		public JsonResult Get(Int16 id, bool aplicafisica, bool aplicamoral)
		{
			try
			{
				List<Entidades.UsoCFDI> Result = Datos.Consultar<Entidades.UsoCFDI>(new Entidades.UsoCFDI()
				{
						 ID = id
                         ,APLICAFISICA = aplicafisica
                         ,APLICAMORAL = aplicamoral
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
		public string Post([FromBody]Entidades.UsoCFDI UsoCFDI)
		{
			try
			{
				return Datos.Nuevo<Entidades.UsoCFDI>(UsoCFDI, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.UsoCFDI UsoCFDI)
		{
			try
			{
				return Datos.Actualizar<Entidades.UsoCFDI>(UsoCFDI, null, Enumeradores.TypeAction.None);
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
				return Datos.Eliminar<Entidades.UsoCFDI>(new Entidades.UsoCFDI()
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
