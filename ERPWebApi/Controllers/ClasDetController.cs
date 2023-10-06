using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class ClasDetController: Controller
	{		
		/// <summary>
        /// Obtiene una colección de Clasificaciones de una funcionalidad de tipo Entidades.ClasDet
        /// </summary>
        /// <param name="idclas">Id de la clasificación; 0 = Todas</param>
        /// <param name="idref">Id de la referencia de la funcionalidad</param>
        /// <param name="idfuncionalidad">Id de la Funcionalidad a consultar</param>
        /// <returns></returns>
		[HttpGet("{idclas}/{idref}/{idfuncionalidad}")]
		public JsonResult Get(Int32 idclas, Int64 idref, Int16 idfuncionalidad)
		{
			try
			{
				List<Entidades.ClasDet> Result = Datos.Consultar<Entidades.ClasDet>(new Entidades.ClasDet()
				{
						 IDREF = idref,
                         IDFUNCIONALIDAD = idfuncionalidad,
                         IDCLAS = idclas
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
        /// Obtiene una colección de Clasificaciones de una funcionalidad de una empresa de tipo Entidades.ClasDet
        /// </summary>
        /// <param name="idclas">Id de la clasificación; 0 = Todas</param>
        /// <param name="idref">Id de la referencia de la funcionalidad</param>
        /// <param name="idfuncionalidad">Id de la Funcionalidad a consultar</param>
        /// <param name="idempresa">Id de la empresa</param>
        /// <returns></returns>
        [HttpGet("{idclas}/{idref}/{idfuncionalidad}/{idempresa}")]
        public JsonResult Get(Int32 idclas, Int64 idref, Int16 idfuncionalidad, Int16 idempresa)
        {
            try
            {
                List<Entidades.ClasDet> Result = Datos.Consultar<Entidades.ClasDet>(new Entidades.ClasDet()
                {
                    IDREF = idref,
                    IDFUNCIONALIDAD = idfuncionalidad,
                    IDCLAS = idclas,
                    IDEMPRESA = idempresa
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
        /// Crea una nueva referencia de clasificación
        /// </summary>
        /// <param name="ClasDet">Objeto serializado de tipo Entidades.ClasDet</param>
        /// <returns></returns>
        [HttpPost]
		public string Post([FromBody]Entidades.ClasDet ClasDet)
		{
			try
			{
				return Datos.Nuevo<Entidades.ClasDet>(ClasDet, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}

        /// <summary>
        /// Actualiza los datos de un referencia de clasificación
        /// </summary>
        /// <param name="ClasDet">Objeto serializado de tipo Entidades.ClasDet</param>
        /// <returns></returns>
        [HttpPut]
        public string Put([FromBody]Entidades.ClasDet ClasDet)
		{
			try
			{
				return Datos.Actualizar<Entidades.ClasDet>(ClasDet, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
        /// <summary>
        /// Elimina una referencia de clasificación por su Id
        /// </summary>
        /// <param name="id">Id a Eliminar</param>
        /// <returns></returns>
		[HttpDelete("{id}")]
		public string Delete(Int64 id)
		{
			try
			{
				return Datos.Eliminar<Entidades.ClasDet>(new Entidades.ClasDet()
				{
						 ID = id
				});
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}

        /// <summary>
        /// Elimina todas las referencias de clasificación de una funcionalidad
        /// </summary>
        /// <param name="idclas">Id de la clasificación a eliminar; 0 = Todas</param>
        /// <param name="idref">Id de la referncia de la funcionalidad</param>
        /// <param name="idfuncionalidad">Id de la Funcionalidad</param>
        /// <returns></returns>
        [HttpDelete("{idclas}/{idref}/{idfuncionalidad}")]
        public string Delete(Int32 idclas, Int64 idref, Int16 idfuncionalidad)
        {
            try
            {
                return Datos.Eliminar<Entidades.ClasDet>(new Entidades.ClasDet()
                {
                    IDREF = idref,
                    IDFUNCIONALIDAD = idfuncionalidad,
                    IDCLAS = idclas
                });
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
