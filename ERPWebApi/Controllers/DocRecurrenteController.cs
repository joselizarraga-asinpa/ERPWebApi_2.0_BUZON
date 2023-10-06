using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class DocRecurrenteController: Controller
	{
		[HttpGet]
		public JsonResult Get()
		{
			try
			{
				List<Entidades.DocRecurrente> Result = Datos.Consultar<Entidades.DocRecurrente>(new Entidades.DocRecurrente()
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
		public JsonResult Get(Int32 id)
		{
			try
			{
				List<Entidades.DocRecurrente> Result = Datos.Consultar<Entidades.DocRecurrente>(new Entidades.DocRecurrente()
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

        [HttpGet("{id}/{idsucursal}/{idcliprov}")]
        public JsonResult Get(Int32 id, Int16 idsucursal, Int32 idcliprov)
        {
            try
            {
                List<Entidades.DocRecurrente> Result = Datos.Consultar<Entidades.DocRecurrente>(new Entidades.DocRecurrente()
                {
                    ID = id,
                    IDSUCURSAL = idsucursal,
                    IDCLIPROV = idcliprov
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

        [HttpGet("{buscar}/{idsucursal}")]
        public JsonResult Get(string buscar, Int16 idsucursal)
        {
            try
            {
                List<Entidades.DocRecurrente> Result = Datos.Buscar<Entidades.DocRecurrente>(new Entidades.DocRecurrente()
                {
                    ID = 0,
                    IDSUCURSAL = idsucursal,
                    NOMBREDOCRECURRENTE = (buscar == @"""" ? "" : buscar)
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
		public string Post([FromBody]Entidades.DocRecurrente DocRecurrente)
		{
			try
			{
				return Datos.Nuevo<Entidades.DocRecurrente>(DocRecurrente, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.DocRecurrente DocRecurrente)
		{
			try
			{
				return Datos.Actualizar<Entidades.DocRecurrente>(DocRecurrente, null, Enumeradores.TypeAction.None);
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
				return Datos.Eliminar<Entidades.DocRecurrente>(new Entidades.DocRecurrente()
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
