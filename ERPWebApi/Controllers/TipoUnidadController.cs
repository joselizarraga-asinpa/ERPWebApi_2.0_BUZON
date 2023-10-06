using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
    [Route("api/[controller]")]
    public class TipoUnidadController : Controller
    {
        // GET: api/values
        [HttpGet]
        //public IEnumerable<string> Get()
        public JsonResult Get()
        {
            try
            {
                List<Entidades.TipoUnidad> Result = Datos.Consultar<Entidades.TipoUnidad>(new Entidades.TipoUnidad()
                {
                    ID = 0,
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

        // GET api/values/5
        [HttpGet("{id}")]
        public JsonResult Get(Int16 id)
        {
            try
            {
                List<Entidades.TipoUnidad> Result = Datos.Consultar<Entidades.TipoUnidad>(new Entidades.TipoUnidad()
                {
                    ID = id,
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

        // POST api/values
        [HttpPost]
        public string Post([FromBody]Entidades.TipoUnidad TipoUnidad)
        {
            try
            {
                TipoUnidad.IDPINCLIENTE = Datos.idPinCliente;
                return Datos.Nuevo<Entidades.TipoUnidad>(TipoUnidad, null, Enumeradores.TypeAction.None);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // PUT api/values/5
        [HttpPut]
        public string Put([FromBody]Entidades.TipoUnidad TipoUnidad)
        {
            try
            {
                TipoUnidad.IDPINCLIENTE = Datos.idPinCliente;
                return Datos.Actualizar<Entidades.TipoUnidad>(TipoUnidad, null, Enumeradores.TypeAction.None);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public string Delete(Int16 id)
        {
            try
            {
                return Datos.Eliminar<Entidades.TipoUnidad>(new Entidades.TipoUnidad()
                {
                    ID = id,
                    IDPINCLIENTE = Datos.idPinCliente
                });
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
