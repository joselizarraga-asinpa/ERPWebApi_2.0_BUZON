using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class EmailController: Controller
	{
		
		[HttpGet("{id}")]
		public JsonResult Get(Int64 id)
		{
			try
			{
				List<Entidades.Email> Result = Datos.Consultar<Entidades.Email>(new Entidades.Email()
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

        [HttpGet("{idDatosGenerales}/{IdDomicilio}")]
        public JsonResult Get(long idDatosGenerales, long idDomicilio)
        {
            try
            {
                List<Entidades.Email> Result = Datos.Consultar<Entidades.Email>(new Entidades.Email()
                {
                    ID = 0,
                    IDDATOSGENERALES = idDatosGenerales,
                    IDDOMICILIO = idDomicilio
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
		public string Post([FromBody]Entidades.Email Email)
		{
			try
			{
				return Datos.Nuevo<Entidades.Email>(Email, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.Email Email)
		{
			try
			{
				return Datos.Actualizar<Entidades.Email>(Email, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpDelete("{id}")]
		public string Delete(Int64 id)
		{
			try
			{
				return Datos.Eliminar<Entidades.Email>(new Entidades.Email()
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
