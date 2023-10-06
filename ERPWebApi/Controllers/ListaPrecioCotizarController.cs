using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class ListaPrecioCotizarController: Controller
	{

		[HttpPost]
		public JsonResult Post([FromBody]Entidades.ListaPrecioCotizar ListaPrecioCotizar)
		{
            try
            {
                List<Entidades.ListaPrecioCotizar> Result = Datos.Consultar<Entidades.ListaPrecioCotizar>(ListaPrecioCotizar,
                new List<object>().ToArray()
                );
                return Json(Result);
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }
	
	}
}
