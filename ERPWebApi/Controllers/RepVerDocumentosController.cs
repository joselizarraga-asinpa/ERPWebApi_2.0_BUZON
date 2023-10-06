using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class RepVerDocumentosController: Controller
	{
		
		
		[HttpPost]
		public JsonResult Post([FromBody]Entidades.RepVerDocumentos RepVerDocumentos)
		{
            try
            {
                List<Entidades.RepVerDocumentos> Result = Datos.Consultar<Entidades.RepVerDocumentos>(RepVerDocumentos,
                new List<object>().ToArray());
                return Json(Result);
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }
		
		
	}
}
