using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class CliProvController: Controller
	{
        /// <summary>
        /// Obtiene un cliente o proveedor por su Id
        /// </summary>
        /// <param name="id">Id del cliente o proveedor</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public JsonResult Get(Int32 id)
        {
            try
            {
                List<Entidades.CliProv> Result = Datos.Consultar<Entidades.CliProv>(new Entidades.CliProv()
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

        /// <summary>
        /// Obtiene una colección de clientes o proveedores del tipo Entidades.CliProv
        /// </summary>
        /// <param name="id">Id del cliente o proveedor; 0 = Todos</param>
        /// <param name="cliente">true=para Clientes ; false=para proveedores</param>
        /// <returns></returns>
        [HttpGet("{id}/{cliente}")]
        public JsonResult Get(Int32 id, bool cliente)
        {
            try
            {
                List<Entidades.CliProv> Result = Datos.Consultar<Entidades.CliProv>(new Entidades.CliProv()
                {
                    ID = id,
                    IDPINCLIENTE = Datos.idPinCliente,
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

        /// <summary>
        /// Obtiene una colección de clientes o proveedores de acuerdo al nombre a buscar. Resultado de tipo Entidades.CliProv
        /// </summary>
        /// <param name="cliente">true=para Clientes ; false=para proveedores</param>
        /// <param name="buscar">el nombre del cliente o proveedor a buscar</param>
        /// <param name="id">0 (NO SE USA POR EL MOMENTO)</param>
        /// <returns></returns>
        [HttpGet("{cliente}/{buscar}/{id}")]
        public JsonResult Get(bool cliente, string buscar, Int32 id)
        {
            try
            {
                List<Entidades.CliProv> Result = Datos.Buscar<Entidades.CliProv>(new Entidades.CliProv()
                {
                    ID = 0,
                    IDPINCLIENTE = Datos.idPinCliente,
                    CLIENTE = cliente,
                    NOMBRE = (buscar == @"""" ? "" : buscar)
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
        /// Crea un cliente o proveedor nuevo
        /// </summary>
        /// <param name="CliProv">Objeto serializado de tipo Entidades.CliProv</param>
        /// <returns></returns>
        [HttpPost]
		public string Post([FromBody]Entidades.CliProv CliProv)
		{
			try
			{
				CliProv.IDPINCLIENTE = Datos.idPinCliente;
				return Datos.Nuevo<Entidades.CliProv>(CliProv, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}

        /// <summary>
        /// Actualiza los datos de un Cliente o Proveedor
        /// </summary>
        /// <param name="CliProv">Objeto serializado de tipo Entidades.CliProv</param>
        /// <returns></returns>
        [HttpPut]
		public string Put([FromBody]Entidades.CliProv CliProv)
		{
			try
			{
				CliProv.IDPINCLIENTE = Datos.idPinCliente;
				return Datos.Actualizar<Entidades.CliProv>(CliProv, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
        /// <summary>
        /// Elimina un cliente o proveedor por su Id
        /// </summary>
        /// <param name="id">Id del cliente o proveedor a eliminar</param>
        /// <returns></returns>
		[HttpDelete("{id}")]
		public string Delete(Int32 id)
		{
			try
			{
				return Datos.Eliminar<Entidades.CliProv>(new Entidades.CliProv()
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
