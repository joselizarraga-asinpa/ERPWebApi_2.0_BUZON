using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{

    //Clase creada por generador de código
    [Route("api/[controller]")]
    public class RepResProductosDocController : Controller
	{		
		[HttpPost]
        public JsonResult Post([FromBody]Entidades.RepResProductosDoc RepResProductosDoc)
        {
            try
            {
                List<Entidades.RepResProductosDoc> Result = Datos.Consultar<Entidades.RepResProductosDoc>(RepResProductosDoc,
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
