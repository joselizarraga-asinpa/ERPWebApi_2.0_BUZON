using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class CFDIBUZON_VISTAController: Controller
	{
		[HttpGet]
		public JsonResult Get()
		{
			try
			{
				List<Entidades.CFDIBUZON_VISTA> Result = Datos.Consultar<Entidades.CFDIBUZON_VISTA>(new Entidades.CFDIBUZON_VISTA()
				{
						IDPINCLIENTE = Datos.idPinCliente                        
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

        [HttpGet("{Iddocfiscal}")]
        public JsonResult Get(long Iddocfiscal)
        {
            try
            {
                List<Entidades.CFDIBUZON_VISTA> Result = Datos.Consultar<Entidades.CFDIBUZON_VISTA>(new Entidades.CFDIBUZON_VISTA()
                {
                    IDPINCLIENTE = Datos.idPinCliente,
                    IDDOCFISCAL = Iddocfiscal
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
