using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{

    //Clase creada por generador de código
    [Route("api/[controller]")]
    public class RepAuxProductosDocController : Controller
    {

        [HttpPost]
        public JsonResult Post([FromBody]Entidades.RepAuxProductosDoc RepAuxProductosDoc)
        {
            try
            {
                List<Entidades.RepAuxProductosDoc> Result = Datos.Consultar<Entidades.RepAuxProductosDoc>(RepAuxProductosDoc,
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
