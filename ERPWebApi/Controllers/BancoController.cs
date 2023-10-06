using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class BancoController: Controller
	{
        /// <summary>
        /// Obtiene todos los Bancos
        /// </summary>
        /// <returns></returns>
		[HttpGet]
		public JsonResult Get()
		{
			try
			{
				List<Entidades.Banco> Result = Datos.Consultar<Entidades.Banco>(new Entidades.Banco()
				{
						 ID = 0
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
		
        /// <summary>
        /// Obtiene un banco por su Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
		[HttpGet("{id}")]
		public JsonResult Get(Int16 id)
		{
			try
			{
				List<Entidades.Banco> Result = Datos.Consultar<Entidades.Banco>(new Entidades.Banco()
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

        /// <summary>
        /// Crea un nuevo Banco
        /// </summary>
        /// <param name="Banco">Objeto serializado de tipo Entidades.Banco</param>
        /// <returns></returns>
        [HttpPost]
		public string Post([FromBody]Entidades.Banco Banco)
		{
			try
			{
				return Datos.Nuevo<Entidades.Banco>(Banco, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}

        /// <summary>
        /// Actualiza los datos de un Banco
        /// </summary>
        /// <param name="Banco">Objeto serializado de tipo Entidades.Banco</param>
        /// <returns></returns>
        [HttpPut]
		public string Put([FromBody]Entidades.Banco Banco)
		{
			try
			{
				return Datos.Actualizar<Entidades.Banco>(Banco, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
        /// <summary>
        /// Elimina un banco por su Id
        /// </summary>
        /// <param name="id">Id del Banco a Eliminar</param>
        /// <returns></returns>
		[HttpDelete("{id}")]
		public string Delete(Int16 id)
		{
			try
			{
				return Datos.Eliminar<Entidades.Banco>(new Entidades.Banco()
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
