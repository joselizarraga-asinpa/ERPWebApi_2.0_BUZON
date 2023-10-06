using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class TipoAplicacionCategoriaController: Controller
	{

        [HttpGet("{idtipoaplicacion}")]
        public JsonResult Get(Int16 idtipoaplicacion)
        {
            try
            {
                List<Entidades.TipoAplicacionCategoria> Result = Datos.Consultar<Entidades.TipoAplicacionCategoria>(new Entidades.TipoAplicacionCategoria()
                {
                    IDTIPOAPLICACION = idtipoaplicacion                    
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

        [HttpGet("{idtipoaplicacion}/{idtipoaplicacioncampo}")]
		public JsonResult Get(Int16 idtipoaplicacion, Int16 idtipoaplicacioncampo)
		{
			try
			{
				List<Entidades.TipoAplicacionCategoria> Result = Datos.Consultar<Entidades.TipoAplicacionCategoria>(new Entidades.TipoAplicacionCategoria()
				{
                     IDTIPOAPLICACION = idtipoaplicacion
                    ,IDTIPOAPLICACIONCAMPO = idtipoaplicacioncampo						
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
		public string Post([FromBody]Entidades.TipoAplicacionCategoria TipoAplicacionCategoria)
		{
			try
			{				
				return Datos.Nuevo<Entidades.TipoAplicacionCategoria>(TipoAplicacionCategoria, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.TipoAplicacionCategoria TipoAplicacionCategoria)
		{
			try
			{				
				return Datos.Actualizar<Entidades.TipoAplicacionCategoria>(TipoAplicacionCategoria, null, Enumeradores.TypeAction.None);
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
				return Datos.Eliminar<Entidades.TipoAplicacionCategoria>(new Entidades.TipoAplicacionCategoria()
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
