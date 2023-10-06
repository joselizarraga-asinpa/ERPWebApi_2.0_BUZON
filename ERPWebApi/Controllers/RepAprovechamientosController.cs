using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class RepAprovechamientosController: Controller
	{

        [HttpGet("{iddocumento}")]
        public JsonResult Get(long iddocumento)
        {
            try
            {
                List<Entidades.RepAprovechamientos> Result = Datos.Consultar<Entidades.RepAprovechamientos>(new Entidades.RepAprovechamientos()
                {
                    IDDOCUMENTO = iddocumento
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
