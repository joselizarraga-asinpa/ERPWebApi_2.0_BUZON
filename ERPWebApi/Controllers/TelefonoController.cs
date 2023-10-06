using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class TelefonoController: Controller
	{
		
		[HttpGet("{id}")]
		public JsonResult Get(Int64 id)
		{
			try
			{
				List<Entidades.Telefono> Result = Datos.Consultar<Entidades.Telefono>(new Entidades.Telefono()
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
                List<Entidades.Telefono> Result = Datos.Consultar<Entidades.Telefono>(new Entidades.Telefono()
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
		public string Post([FromBody]Entidades.Telefono Telefono)
		{
			try
			{
				return Datos.Nuevo<Entidades.Telefono>(Telefono, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.Telefono Telefono)
		{
			try
			{
				return Datos.Actualizar<Entidades.Telefono>(Telefono, null, Enumeradores.TypeAction.None);
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
				return Datos.Eliminar<Entidades.Telefono>(new Entidades.Telefono()
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
