using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class FlujoAplicadoController: Controller
	{

        [HttpGet("{idflujo}")]
		public JsonResult Get(Int32 idflujo)
		{
			try
			{
				List<Entidades.FlujoAplicado> Result = Datos.Consultar<Entidades.FlujoAplicado>(new Entidades.FlujoAplicado()
				{
						 IDFLUJO = idflujo
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

        [HttpGet("{idfuncionalidad}/{idref}")]
        public JsonResult Get(Int16 idfuncionalidad, Int32 idref)
        {
            try
            {
                List<Entidades.FlujoAplicado> Result = Datos.Consultar<Entidades.FlujoAplicado>(new Entidades.FlujoAplicado()
                {
                    IDFUNCIONALIDAD = idfuncionalidad,
                    IDREF = idref
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
		public string Post([FromBody]Entidades.FlujoAplicado FlujoAplicado)
		{
			try
			{
				return Datos.Nuevo<Entidades.FlujoAplicado>(FlujoAplicado, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.FlujoAplicado FlujoAplicado)
		{
			try
			{
				return Datos.Actualizar<Entidades.FlujoAplicado>(FlujoAplicado, null, Enumeradores.TypeAction.None);
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
				return Datos.Eliminar<Entidades.FlujoAplicado>(new Entidades.FlujoAplicado()
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
