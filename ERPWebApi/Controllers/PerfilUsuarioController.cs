using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class PerfilUsuarioController: Controller
	{
		[HttpGet]
		public JsonResult Get()
		{
			try
			{
				List<Entidades.PerfilUsuario> Result = Datos.Consultar<Entidades.PerfilUsuario>(new Entidades.PerfilUsuario()
				{
						 ID = 0
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
		
		[HttpGet("{id}")]
		public JsonResult Get(Int16 id)
		{
			try
			{
				List<Entidades.PerfilUsuario> Result = Datos.Consultar<Entidades.PerfilUsuario>(new Entidades.PerfilUsuario()
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

        [HttpGet("{buscar}/{id}")]
        public JsonResult Get(string buscar, Int16 id)
        {
            try
            {
                List<Entidades.PerfilUsuario> Result = Datos.Buscar<Entidades.PerfilUsuario>(new Entidades.PerfilUsuario()
                {
                    ID = 0,
                    IDPINCLIENTE = Datos.idPinCliente,                    
                    NOMBREPERFILUSUARIO = (buscar == @"""" ? "" : buscar)
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
		public string Post([FromBody]Entidades.PerfilUsuario PerfilUsuario)
		{
			try
			{
				PerfilUsuario.IDPINCLIENTE = Datos.idPinCliente;
				return Datos.Nuevo<Entidades.PerfilUsuario>(PerfilUsuario, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.PerfilUsuario PerfilUsuario)
		{
			try
			{
				PerfilUsuario.IDPINCLIENTE = Datos.idPinCliente;
				return Datos.Actualizar<Entidades.PerfilUsuario>(PerfilUsuario, null, Enumeradores.TypeAction.None);
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
				return Datos.Eliminar<Entidades.PerfilUsuario>(new Entidades.PerfilUsuario()
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
