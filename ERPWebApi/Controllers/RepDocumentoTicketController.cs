using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class RepDocumentoTicketController: Controller
	{
        [HttpGet("{iddocumento}")]
        public JsonResult Get(long IdDocumento)
        {
            try
            {
                List<Entidades.RepDocumentoTicket> Result = Datos.Consultar<Entidades.RepDocumentoTicket>(new Entidades.RepDocumentoTicket()
                { 
                    IDDOCUMENTO = IdDocumento
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
