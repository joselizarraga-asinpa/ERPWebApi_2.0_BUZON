using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class DocRecurrenteDetController: Controller
	{
				
		[HttpGet("{id}")]
		public JsonResult Get(Int32 id)
		{
			try
			{
				List<Entidades.DocRecurrenteDet> Result = Datos.Consultar<Entidades.DocRecurrenteDet>(new Entidades.DocRecurrenteDet()
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

        [HttpGet("{idDocRecurrente}/{id}")]
        public JsonResult Get(int idDocRecurrente, Int32 id)
        {
            try
            {
                List<Entidades.DocRecurrenteDet> Result = Datos.Consultar<Entidades.DocRecurrenteDet>(new Entidades.DocRecurrenteDet()
                {
                    IDDOCRECURRENTE = idDocRecurrente,
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

        [HttpPost]
		public string Post([FromBody]Entidades.DocRecurrenteDet DocRecurrenteDet)
		{
			try
			{
				return Datos.Nuevo<Entidades.DocRecurrenteDet>(DocRecurrenteDet, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.DocRecurrenteDet DocRecurrenteDet)
		{
			try
			{
				return Datos.Actualizar<Entidades.DocRecurrenteDet>(DocRecurrenteDet, null, Enumeradores.TypeAction.None);
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
				return Datos.Eliminar<Entidades.DocRecurrenteDet>(new Entidades.DocRecurrenteDet()
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
