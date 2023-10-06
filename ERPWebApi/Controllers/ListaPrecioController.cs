using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class ListaPrecioController: Controller
	{
		
		[HttpGet("{id}")]
		public JsonResult Get(Int16 id)
		{
			try
			{
				List<Entidades.ListaPrecio> Result = Datos.Consultar<Entidades.ListaPrecio>(new Entidades.ListaPrecio()
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

        [HttpGet("{id}/{idempresa}/{cliente}")]
        public JsonResult Get(Int16 id, Int16 idempresa, bool cliente)
        {
            try
            {
                List<Entidades.ListaPrecio> Result = Datos.Consultar<Entidades.ListaPrecio>(new Entidades.ListaPrecio()
                {
                    ID = id,
                    IDEMPRESA = idempresa,
                    CLIENTE = cliente
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

        [HttpGet("{buscar}/{idempresa}")]
        public JsonResult Get(string buscar, Int16 idempresa)
        {
            try
            {
                List<Entidades.ListaPrecio> Result = Datos.Buscar<Entidades.ListaPrecio>(new Entidades.ListaPrecio()
                {
                    ID = 0,
                    NOMBRELISTAPRECIO = (buscar == @"""" ? "" : buscar),
                    IDEMPRESA = idempresa
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
		public string Post([FromBody]Entidades.ListaPrecio ListaPrecio)
		{
			try
			{
				return Datos.Nuevo<Entidades.ListaPrecio>(ListaPrecio, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.ListaPrecio ListaPrecio)
		{
			try
			{
				return Datos.Actualizar<Entidades.ListaPrecio>(ListaPrecio, null, Enumeradores.TypeAction.None);
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
				return Datos.Eliminar<Entidades.ListaPrecio>(new Entidades.ListaPrecio()
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
