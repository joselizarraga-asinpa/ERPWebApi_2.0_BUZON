using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de c�digo
	[Route("api/[controller]")]
	public class CondicionPagoController: Controller
	{

        /// <summary>
        /// Obtiene una colecci�n de todas las condiciones de Pago para CFDIs. Resultado de tipo Entidades.CondicionPago
        /// </summary>
        /// <returns></returns>
		[HttpGet]
		public JsonResult Get()
		{
			try
			{
				List<Entidades.CondicionPago> Result = Datos.Consultar<Entidades.CondicionPago>(new Entidades.CondicionPago()
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
        /// Obtiene una condici�n de pago de Cfdi por su Id
        /// </summary>
        /// <param name="id">Id de la condici�n de pago de Cfdi</param>
        /// <returns></returns>
		[HttpGet("{id}")]
		public JsonResult Get(Int16 id)
		{
			try
			{
				List<Entidades.CondicionPago> Result = Datos.Consultar<Entidades.CondicionPago>(new Entidades.CondicionPago()
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
        /// Crea una condici�n de pago nueva
        /// </summary>
        /// <param name="CondicionPago">objeto serializado de tipo Entidades.CondicionPago</param>
        /// <returns></returns>
		[HttpPost]
		public string Post([FromBody]Entidades.CondicionPago CondicionPago)
		{
			try
			{
				return Datos.Nuevo<Entidades.CondicionPago>(CondicionPago, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}

        /// <summary>
        /// Actualiza los datos de una Condici�n de pago de Cfdi
        /// </summary>
        /// <param name="CondicionPago">objeto serializado de tipo Entidades.CondicionPago</param>
        /// <returns></returns>
        [HttpPut]
		public string Put([FromBody]Entidades.CondicionPago CondicionPago)
		{
			try
			{
				return Datos.Actualizar<Entidades.CondicionPago>(CondicionPago, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
        /// <summary>
        /// Elimina una condici�n de pago por su Id
        /// </summary>
        /// <param name="id">Id de la condici�n de pago a eliminar</param>
        /// <returns></returns>
		[HttpDelete("{id}")]
		public string Delete(Int16 id)
		{
			try
			{
				return Datos.Eliminar<Entidades.CondicionPago>(new Entidades.CondicionPago()
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
