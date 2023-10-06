using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class PersonalController: Controller
	{
        [HttpGet("{buscar}/{id}")]
        public JsonResult Get(string buscar, Int32 id)
        {
            try
            {
                List<Entidades.Personal> Result = Datos.Buscar<Entidades.Personal>(new Entidades.Personal()
                {
                    ID = 0,
                    IDPINCLIENTE = Datos.idPinCliente,                    
                    NOMBRE = (buscar == @"""" ? "" : buscar)
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

        [HttpGet("{id}")]
		public JsonResult Get(Int16 id)
		{
			try
			{
				List<Entidades.Personal> Result = Datos.Consultar<Entidades.Personal>(new Entidades.Personal()
				{
						 ID = id
						,IDPINCLIENTE = Datos.idPinCliente
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
		public string Post([FromBody]Entidades.Personal Personal)
		{
			try
			{
				Personal.IDPINCLIENTE = Datos.idPinCliente;
				return Datos.Nuevo<Entidades.Personal>(Personal, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.Personal Personal)
		{
			try
			{
				Personal.IDPINCLIENTE = Datos.idPinCliente;
				return Datos.Actualizar<Entidades.Personal>(Personal, null, Enumeradores.TypeAction.None);
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
				return Datos.Eliminar<Entidades.Personal>(new Entidades.Personal()
				{
						 ID = id
						,IDPINCLIENTE = Datos.idPinCliente
				});
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
	}
}
