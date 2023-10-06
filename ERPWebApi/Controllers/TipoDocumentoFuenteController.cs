using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class TipoDocumentoFuenteController: Controller
	{

        [HttpGet("{id}")]
        public JsonResult Get(Int16 id)
        {
            try
            {
                List<Entidades.TipoDocumentoFuente> Result = Datos.Consultar<Entidades.TipoDocumentoFuente>(new Entidades.TipoDocumentoFuente()
                {
                    IDTIPODOCUMENTO = id
                    , IDPINCLIENTE = Datos.idPinCliente
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
        
    }
}
