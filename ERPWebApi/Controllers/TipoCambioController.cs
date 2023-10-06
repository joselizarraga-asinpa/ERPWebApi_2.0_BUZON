using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class TipoCambioController: Controller
	{
				
		[HttpPost]
		public JsonResult Post([FromBody]Entidades.TipoCambio TipoCambio)
		{
			try
			{				
                List<Entidades.TipoCambio> Result = Datos.Consultar<Entidades.TipoCambio>(TipoCambio, new List<object>().ToArray());
                if (Result.Count == 0 || TipoCambio.IMPORTE > 0)
                {
                    Datos.Nuevo<Entidades.TipoCambio>(TipoCambio, null, Enumeradores.TypeAction.None);
                    Result = Datos.Consultar<Entidades.TipoCambio>(TipoCambio, new List<object>().ToArray());
                }
                return Json(Result);
            }
			catch (Exception ex)
			{
                return Json(ex.Message);
            }
		}

        [HttpPut]
        public string Put([FromBody]Entidades.TipoCambio TipoCambio)
		{
			try
			{
				return Datos.Actualizar<Entidades.TipoCambio>(TipoCambio, null, Enumeradores.TypeAction.None);
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
				return Datos.Eliminar<Entidades.TipoCambio>(new Entidades.TipoCambio()
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
