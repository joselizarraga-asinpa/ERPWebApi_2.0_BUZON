using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class ListaPrecioDetController: Controller
	{

        [HttpGet("{id}")]
        public JsonResult Get(Int32 id)
        {
            try
            {
                List<Entidades.ListaPrecioDet> Result = Datos.Consultar<Entidades.ListaPrecioDet>(new Entidades.ListaPrecioDet()
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

        [HttpGet("{idListaPrecio}/{id}")]
		public JsonResult Get(Int16 idListaPrecio, Int32 id)
		{
			try
			{
				List<Entidades.ListaPrecioDet> Result = Datos.Consultar<Entidades.ListaPrecioDet>(new Entidades.ListaPrecioDet()
				{
						 ID = id,
                         IDLISTAPRECIO = idListaPrecio
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
		public string Post([FromBody]Entidades.ListaPrecioDet ListaPrecioDet)
		{
			try
			{
				return Datos.Nuevo<Entidades.ListaPrecioDet>(ListaPrecioDet, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.ListaPrecioDet ListaPrecioDet)
		{
			try
			{
				return Datos.Actualizar<Entidades.ListaPrecioDet>(ListaPrecioDet, null, Enumeradores.TypeAction.None);
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
				return Datos.Eliminar<Entidades.ListaPrecioDet>(new Entidades.ListaPrecioDet()
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
