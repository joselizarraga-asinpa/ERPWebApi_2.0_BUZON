using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class UsuarioController: Controller
	{
		[HttpGet]
		public JsonResult Get()
		{
			try
			{
				List<Entidades.Usuario> Result = Datos.Consultar<Entidades.Usuario>(new Entidades.Usuario()
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
		
		[HttpGet("{NombreUsuario}")]
		public JsonResult Get(string NombreUsuario)
		{
			try
			{
                List<Entidades.Usuario> Result = Datos.Consultar<Entidades.Usuario>(new Entidades.Usuario()
                {
                    ID = 0
                        , IDPINCLIENTE = Datos.idPinCliente
                        , NOMBREUSUARIO = NombreUsuario
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
                List<Entidades.Usuario> Result = Datos.Buscar<Entidades.Usuario>(new Entidades.Usuario()
                {
                    ID = 0,
                    IDPINCLIENTE = Datos.idPinCliente,
                    NOMBREUSUARIO = (buscar == @"""" ? "" : buscar)
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
		public string Post([FromBody]Entidades.Usuario Usuario)
		{
			try
			{
				Usuario.IDPINCLIENTE = Datos.idPinCliente;
				return Datos.Nuevo<Entidades.Usuario>(Usuario, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.Usuario Usuario)
		{
			try
			{
				Usuario.IDPINCLIENTE = Datos.idPinCliente;
				return Datos.Actualizar<Entidades.Usuario>(Usuario, null, Enumeradores.TypeAction.None);
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
				return Datos.Eliminar<Entidades.Usuario>(new Entidades.Usuario()
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
