using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class MovBancoController: Controller
	{
				
		[HttpGet("{id}")]
		public JsonResult Get(Int32 id)
		{
			try
			{
				List<Entidades.MovBanco> Result = Datos.Consultar<Entidades.MovBanco>(new Entidades.MovBanco()
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

        [HttpGet("{id}/{idcuentabanco}")]
        public JsonResult Get(Int32 id, Int16 idcuentabanco)
        {
            try
            {
                List<Entidades.MovBanco> Result = Datos.Consultar<Entidades.MovBanco>(new Entidades.MovBanco()
                {
                    ID = id,
                    IDCUENTABANCO = idcuentabanco
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
		public string Post([FromBody]Entidades.MovBanco MovBanco)
		{
			try
			{
				return Datos.Nuevo<Entidades.MovBanco>(MovBanco, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.MovBanco MovBanco)
		{
			try
			{
				return Datos.Actualizar<Entidades.MovBanco>(MovBanco, null, Enumeradores.TypeAction.None);
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
				return Datos.Eliminar<Entidades.MovBanco>(new Entidades.MovBanco()
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
