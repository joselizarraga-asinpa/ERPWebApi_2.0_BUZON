using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class AlmacenController: Controller
	{
        /// <summary>
        /// Obtiene todos los almacenes de una sucursal
        /// </summary>
        /// <param name="id">0=para todos los almacenes</param>
        /// <param name="idsucursal">id de la sucursal</param>
        /// <param name="EntSal">E=Solo Almacenes de Entradas S= Solo Almacenes de Salidas T=Todos los Almacenes</param>
        /// <returns></returns>
        [HttpGet("{id}/{idsucursal}/{entsal}")]
        public JsonResult Get(Int16 id, Int16 idsucursal, string EntSal)
        {
			try
			{
                List<Entidades.Almacen> Result = Datos.Consultar<Entidades.Almacen>(new Entidades.Almacen()
                {
                    ID = id
                         , IDSUCURSAL = idsucursal
                         , ENTRADAS = (EntSal == "E" || EntSal == "T") ? true : false
                         , SALIDAS = (EntSal == "S" || EntSal == "T") ? true : false
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
        /// Obtiene un almacén especifico por su Id o todos
        /// </summary>
        /// <param name="id">0= para todos los almacenes</param>
        /// <returns></returns>
		[HttpGet("{id}")]        
		public JsonResult Get(Int16 id)
		{
			try
			{
				List<Entidades.Almacen> Result = Datos.Consultar<Entidades.Almacen>(new Entidades.Almacen()
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
        /// Obtiene los almacenes que contengan las letras especificadas dentro de una sucursal especifica
        /// </summary>
        /// <param name="buscar">El nombre de almacen a buscar</param>
        /// <param name="idsucursal">Id de la sucursal a buscar</param>
        /// <returns></returns>
        [HttpGet("{buscar}/{idsucursal}")]
        public JsonResult Get(string buscar, Int16 idsucursal)
        {
            try
            {
                List<Entidades.Almacen> Result = Datos.Buscar<Entidades.Almacen>(new Entidades.Almacen()
                {
                    ID = 0,
                    IDSUCURSAL = idsucursal,
                    NOMBREALMACEN = (buscar == @"""" ? "" : buscar)
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
        /// Crea un nuevo almacén
        /// </summary>
        /// <param name="Almacen">objeto serializado de tipo Entidad.Almacen</param>
        /// <returns></returns>
        [HttpPost]
		public string Post([FromBody]Entidades.Almacen Almacen)
		{
			try
			{
				return Datos.Nuevo<Entidades.Almacen>(Almacen, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
        /// <summary>
        /// Actualiza los datos de un almacén existente
        /// </summary>
        /// <param name="Almacen">objeto serializado de tipo Entidades.Almacen</param>
        /// <returns></returns>
		[HttpPut]        
        public string Put([FromBody]Entidades.Almacen Almacen)
		{
			try
			{
				return Datos.Actualizar<Entidades.Almacen>(Almacen, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
        /// <summary>
        /// Elimina un Almacén específico
        /// </summary>
        /// <param name="id">Id del Almacén a eliminar</param>
        /// <returns></returns>
		[HttpDelete("{id}")]
		public string Delete(Int16 id)
		{
			try
			{
				return Datos.Eliminar<Entidades.Almacen>(new Entidades.Almacen()
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
