using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class CajaController: Controller
	{

        /// <summary>
        /// Obtiene una o todas las Cajas Registradoras de una sucursal
        /// </summary>
        /// <param name="id">Id de la Caja; 0=Todas las Cajas Registradoras de una sucursal</param>
        /// <param name="idsucursal">Id de la sucursal</param>
        /// <param name="id2">0 (no se usa por el momento)</param>
        /// <returns></returns>
        [HttpGet("{id}/{idsucursal}/{id2}")]
        public JsonResult Get(Int16 id, Int16 idsucursal, Int16 id2)
        {
            try
            {
                List<Entidades.Caja> Result = Datos.Consultar<Entidades.Caja>(new Entidades.Caja()
                {
                    ID = id
                   ,IDSUCURSAL = idsucursal
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
        /// Obtiene una Caja Registradora por su Id
        /// </summary>
        /// <param name="id">Id de la Caja</param>
        /// <returns></returns>
        [HttpGet("{id}")]
		public JsonResult Get(Int16 id)
		{
			try
			{
				List<Entidades.Caja> Result = Datos.Consultar<Entidades.Caja>(new Entidades.Caja()
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
        /// Obtiene una colección de resultados de tipo entidades.Caja para la búsqueda de Cajas Registradoras
        /// </summary>
        /// <param name="buscar">El nombre de la caja registradora a buscar</param>
        /// <param name="idsucursal">Id de la sucursal donde se buscará; 0 = Todas las sucursales</param>
        /// <returns></returns>
        [HttpGet("{buscar}/{idsucursal}")]
        public JsonResult Get(string buscar, Int16 idsucursal)
        {
            try
            {
                List<Entidades.Caja> Result = Datos.Buscar<Entidades.Caja>(new Entidades.Caja()
                {
                    ID = 0,
                    IDSUCURSAL = idsucursal,
                    NOMBRECAJA = (buscar == @"""" ? "" : buscar)
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
        /// Crea una nueva Caja Registradora
        /// </summary>
        /// <param name="Caja">Objeto serializado de tipo Entidades.Caja</param>
        /// <returns></returns>
        [HttpPost]
		public string Post([FromBody]Entidades.Caja Caja)
		{
			try
			{
				return Datos.Nuevo<Entidades.Caja>(Caja, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}

        /// <summary>
        /// Actualiza los datos de una Caja Registradora Existente
        /// </summary>
        /// <param name="Caja">Objeto serializado de tipo Entidades.Caja</param>
        /// <returns></returns>
        [HttpPut]
		public string Put([FromBody]Entidades.Caja Caja)
		{
			try
			{
				return Datos.Actualizar<Entidades.Caja>(Caja, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
        /// <summary>
        /// Elimina una Caja Registradora
        /// </summary>
        /// <param name="id">Id de la Caja a Eliminar</param>
        /// <returns></returns>
		[HttpDelete("{id}")]
		public string Delete(Int16 id)
		{
			try
			{
				return Datos.Eliminar<Entidades.Caja>(new Entidades.Caja()
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
