using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class RegimenFiscalController: Controller
	{
		[HttpGet]
		public JsonResult Get()
		{
			try
			{
				List<Entidades.RegimenFiscal> Result = Datos.Consultar<Entidades.RegimenFiscal>(new Entidades.RegimenFiscal()
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
				List<Entidades.RegimenFiscal> Result = Datos.Consultar<Entidades.RegimenFiscal>(new Entidades.RegimenFiscal()
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

        [HttpGet("{id}/{fisica}/{moral}")]
        public JsonResult Get(Int16 id, bool fisica, bool moral)
        {
            try
            {
                List<Entidades.RegimenFiscal> Result = Datos.Consultar<Entidades.RegimenFiscal>(new Entidades.RegimenFiscal()
                {
                    ID = id,
                    FISICA = fisica,
                    MORAL = moral
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
		public string Post([FromBody]Entidades.RegimenFiscal RegimenFiscal)
		{
			try
			{
				return Datos.Nuevo<Entidades.RegimenFiscal>(RegimenFiscal, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.RegimenFiscal RegimenFiscal)
		{
			try
			{
				return Datos.Actualizar<Entidades.RegimenFiscal>(RegimenFiscal, null, Enumeradores.TypeAction.None);
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
				return Datos.Eliminar<Entidades.RegimenFiscal>(new Entidades.RegimenFiscal()
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
