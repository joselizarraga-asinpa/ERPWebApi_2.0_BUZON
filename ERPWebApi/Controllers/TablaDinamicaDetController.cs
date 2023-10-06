using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class TablaDinamicaDetController: Controller
	{
		[HttpGet]
		public JsonResult Get()
		{
			try
			{
				List<Entidades.TablaDinamicaDet> Result = Datos.Consultar<Entidades.TablaDinamicaDet>(new Entidades.TablaDinamicaDet()
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
				List<Entidades.TablaDinamicaDet> Result = Datos.Consultar<Entidades.TablaDinamicaDet>(new Entidades.TablaDinamicaDet()
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

        [HttpGet("{id}/{idtabladinamica}")]
        public JsonResult Get(Int16 id, Int16 idtabladinamica)
        {
            try
            {
                List<Entidades.TablaDinamicaDet> Result = Datos.Consultar<Entidades.TablaDinamicaDet>(new Entidades.TablaDinamicaDet()
                {
                    ID = id,
                    IDTABLADINAMICA = idtabladinamica
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
		public string Post([FromBody]Entidades.TablaDinamicaDet TablaDinamicaDet)
		{
			try
			{
				return Datos.Nuevo<Entidades.TablaDinamicaDet>(TablaDinamicaDet, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.TablaDinamicaDet TablaDinamicaDet)
		{
			try
			{
				return Datos.Actualizar<Entidades.TablaDinamicaDet>(TablaDinamicaDet, null, Enumeradores.TypeAction.None);
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
				return Datos.Eliminar<Entidades.TablaDinamicaDet>(new Entidades.TablaDinamicaDet()
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
