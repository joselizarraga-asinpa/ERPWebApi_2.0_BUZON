using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class FlujoController: Controller
	{
		
		
		[HttpGet("{id}")]
		public JsonResult Get(Int32 id)
		{
			try
			{
				List<Entidades.Flujo> Result = Datos.Consultar<Entidades.Flujo>(new Entidades.Flujo()
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

        [HttpGet("{buscar}/{idsucursal}")]
        public JsonResult Get(string buscar, Int16 idsucursal)
        {
            try
            {
                List<Entidades.Flujo> Result = Datos.Buscar<Entidades.Flujo>(new Entidades.Flujo()
                {
                    ID = 0,
                    IDSUCURSAL = idsucursal,
                    OBS = (buscar == @"""" ? "" : buscar)
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

        [HttpGet("{buscar}/{idsucursal}/{idmovbanco}")]
        public JsonResult Get(string buscar, Int16 idsucursal, int idmovbanco)
        {
            try
            {
                List<Entidades.Flujo> Result = Datos.Buscar<Entidades.Flujo>(new Entidades.Flujo()
                {
                    ID = 0,
                    IDSUCURSAL = idsucursal,
                    OBS = (buscar == @"""" ? "" : buscar),
                    IDMOVBANCO = idmovbanco
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
		public string Post([FromBody]Entidades.Flujo Flujo)
		{
			try
			{
				return Datos.Nuevo<Entidades.Flujo>(Flujo, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.Flujo Flujo)
		{
			try
			{
				return Datos.Actualizar<Entidades.Flujo>(Flujo, null, Enumeradores.TypeAction.None);
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
				return Datos.Eliminar<Entidades.Flujo>(new Entidades.Flujo()
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
