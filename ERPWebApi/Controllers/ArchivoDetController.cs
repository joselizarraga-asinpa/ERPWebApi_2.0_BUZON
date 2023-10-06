using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class ArchivoDetController: Controller
	{

        [HttpGet("{id}")]
        public JsonResult Get(Int32 id)
        {
            try
            {
                List<Entidades.ArchivoDet> Result = Datos.Consultar<Entidades.ArchivoDet>(new Entidades.ArchivoDet()
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

        [HttpGet("{idfuncionalidad}/{idref}")]
		public JsonResult Get(Int16 idfuncionalidad, long idref)
		{
			try
			{
				List<Entidades.ArchivoDet> Result = Datos.Consultar<Entidades.ArchivoDet>(new Entidades.ArchivoDet()
				{
                          ID = 0
						 ,IDFUNCIONALIDAD = idfuncionalidad
                         ,IDREF = idref
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
		public string Post([FromBody]Entidades.ArchivoDet ArchivoDet)
		{
			try
			{
				return Datos.Nuevo<Entidades.ArchivoDet>(ArchivoDet, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.ArchivoDet ArchivoDet)
		{
			try
			{
				return Datos.Actualizar<Entidades.ArchivoDet>(ArchivoDet, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpDelete("{id}")]
		public string Delete(Int32 id)
		{
			try
			{
				return Datos.Eliminar<Entidades.ArchivoDet>(new Entidades.ArchivoDet()
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
