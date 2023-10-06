using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class TipoAplicacionController: Controller
	{
		
		[HttpGet("{id}")]
		public JsonResult Get(Int16 id)
		{
			try
			{
				List<Entidades.TipoAplicacion> Result = Datos.Consultar<Entidades.TipoAplicacion>(new Entidades.TipoAplicacion()
				{
						 ID = id
						,IDPINCLIENTE = Datos.idPinCliente
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

        [HttpGet("{buscar}/{idpincliente}")]
        public JsonResult Get(string buscar)
        {
            try
            {
                List<Entidades.TipoAplicacion> Result = Datos.Buscar<Entidades.TipoAplicacion>(new Entidades.TipoAplicacion()
                {
                    ID = 0
                    ,NOMBRETIPOAPLICACION = (buscar == @"""" ? "" : buscar)
                    ,IDPINCLIENTE = Datos.idPinCliente
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
		public string Post([FromBody]Entidades.TipoAplicacion TipoAplicacion)
		{
			try
			{
				TipoAplicacion.IDPINCLIENTE = Datos.idPinCliente;
				return Datos.Nuevo<Entidades.TipoAplicacion>(TipoAplicacion, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.TipoAplicacion TipoAplicacion)
		{
			try
			{
				TipoAplicacion.IDPINCLIENTE = Datos.idPinCliente;
				return Datos.Actualizar<Entidades.TipoAplicacion>(TipoAplicacion, null, Enumeradores.TypeAction.None);
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
				return Datos.Eliminar<Entidades.TipoAplicacion>(new Entidades.TipoAplicacion()
				{
						 ID = id
						,IDPINCLIENTE = Datos.idPinCliente
				});
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
	}
}
