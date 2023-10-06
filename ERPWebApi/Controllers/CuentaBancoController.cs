using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class CuentaBancoController: Controller
	{

        /// <summary>
        /// Obtiene una colección de Cuentas Bancarias por el nombre a buscar de una sucursal. Resultado de tipo Entidades.CuentaBanco
        /// </summary>
        /// <param name="buscar">Nombre de la cuenta bancaria a buscar</param>
        /// <param name="idsucursal">Id de la sucursal a buscar</param>
        /// <returns></returns>
        [HttpGet("{buscar}/{idsucursal}")]
        public JsonResult Get(string buscar, Int16 idsucursal)
        {
            try
            {
                List<Entidades.CuentaBanco> Result = Datos.Buscar<Entidades.CuentaBanco>(new Entidades.CuentaBanco()
                {
                    ID = 0,
                    IDSUCURSAL = idsucursal,
                    ALIAS = (buscar == @"""" ? "" : buscar)
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
        /// Obtiene una o todas las cuentas bancarias. Resultado de tipo Entidades.CuentaBanco
        /// </summary>
        /// <param name="id">Id de la cuenta bancaria a buscar; 0 = Todas</param>
        /// <returns></returns>
        [HttpGet("{id}")]
		public JsonResult Get(Int16 id)
		{
			try
			{
				List<Entidades.CuentaBanco> Result = Datos.Consultar<Entidades.CuentaBanco>(new Entidades.CuentaBanco()
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
        /// Crea una cuenta bancaria nueva
        /// </summary>
        /// <param name="CuentaBanco">Objeto serializado de tipo Entidades.CuentaBanco</param>
        /// <returns></returns>
		[HttpPost]
		public string Post([FromBody]Entidades.CuentaBanco CuentaBanco)
		{
			try
			{
				return Datos.Nuevo<Entidades.CuentaBanco>(CuentaBanco, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}

        /// <summary>
        /// Actualiza los datos de una cuenta bancaria
        /// </summary>
        /// <param name="CuentaBanco">Objeto serializado de tipo Entidades.CuentaBanco</param>
        /// <returns></returns>
        [HttpPut]
		public string Put([FromBody]Entidades.CuentaBanco CuentaBanco)
		{
			try
			{
				return Datos.Actualizar<Entidades.CuentaBanco>(CuentaBanco, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
        /// <summary>
        /// Elimina una cuenta bancaria por su Id
        /// </summary>
        /// <param name="id">Id de la cuenta bancaria a eliminar</param>
        /// <returns></returns>
		[HttpDelete("{id}")]
		public string Delete(Int16 id)
		{
			try
			{
				return Datos.Eliminar<Entidades.CuentaBanco>(new Entidades.CuentaBanco()
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
