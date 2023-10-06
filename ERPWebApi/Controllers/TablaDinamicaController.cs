using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class TablaDinamicaController: Controller
	{
		[HttpGet]
		public JsonResult Get()
		{
			try
			{
				List<Entidades.TablaDinamica> Result = Datos.Consultar<Entidades.TablaDinamica>(new Entidades.TablaDinamica()
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
				List<Entidades.TablaDinamica> Result = Datos.Consultar<Entidades.TablaDinamica>(new Entidades.TablaDinamica()
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

        [HttpGet("{id}/{idinforme}")]
        public JsonResult Get(Int16 id, Int16 idinforme)
        {
            try
            {
                List<Entidades.TablaDinamica> Result = Datos.Consultar<Entidades.TablaDinamica>(new Entidades.TablaDinamica()
                {
                    ID = id,
                    IDINFORME = idinforme
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
		public string Post([FromBody]Entidades.TablaDinamica TablaDinamica)
		{
			try
			{
				return Datos.Nuevo<Entidades.TablaDinamica>(TablaDinamica, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.TablaDinamica TablaDinamica)
		{
			try
			{
				return Datos.Actualizar<Entidades.TablaDinamica>(TablaDinamica, null, Enumeradores.TypeAction.None);
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
				return Datos.Eliminar<Entidades.TablaDinamica>(new Entidades.TablaDinamica()
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
