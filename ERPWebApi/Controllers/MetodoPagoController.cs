using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class MetodoPagoController: Controller
	{
		[HttpGet]
		public JsonResult Get()
		{
			try
			{
				List<Entidades.MetodoPago> Result = Datos.Consultar<Entidades.MetodoPago>(new Entidades.MetodoPago()
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
				List<Entidades.MetodoPago> Result = Datos.Consultar<Entidades.MetodoPago>(new Entidades.MetodoPago()
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

        [HttpGet("{id}/{ClaveSat}")]
        public JsonResult Get(Int16 id, string ClaveSat)
        {
            try
            {
                List<Entidades.MetodoPago> Result = Datos.Consultar<Entidades.MetodoPago>(new Entidades.MetodoPago()
                {
                    ID = id,
                    CLAVESAT = ClaveSat
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
		public string Post([FromBody]Entidades.MetodoPago MetodoPago)
		{
			try
			{
				return Datos.Nuevo<Entidades.MetodoPago>(MetodoPago, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.MetodoPago MetodoPago)
		{
			try
			{
				return Datos.Actualizar<Entidades.MetodoPago>(MetodoPago, null, Enumeradores.TypeAction.None);
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
				return Datos.Eliminar<Entidades.MetodoPago>(new Entidades.MetodoPago()
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
