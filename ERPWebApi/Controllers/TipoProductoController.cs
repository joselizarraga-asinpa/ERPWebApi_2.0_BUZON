using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ERPWebApi.Controllers
{
    [Route("api/[controller]")]
    public class TipoProductoController : Controller
    {
        // GET: api/values
        [HttpGet]
        //public IEnumerable<string> Get()
        public JsonResult Get()
        {
            try
            {
                List<Entidades.TipoProducto> Result = Datos.Consultar<Entidades.TipoProducto>(new Entidades.TipoProducto()
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
                List<Entidades.TipoProducto> Result = Datos.Consultar<Entidades.TipoProducto>(new Entidades.TipoProducto()
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
        public JsonResult Post([FromBody]Entidades.TipoProducto tipoproducto)
        {            
            try
            {
                tipoproducto.IDPINCLIENTE = Datos.idPinCliente;
                return Json(Datos.Nuevo<Entidades.TipoProducto>(tipoproducto, null, Enumeradores.TypeAction.None));
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }            
        }

        // PUT api/values/5
        [HttpPut]
        public JsonResult Put(Int16 id, [FromBody]Entidades.TipoProducto tipoproducto)
        {
            try
            {
                tipoproducto.IDPINCLIENTE = Datos.idPinCliente;
                return Json(Datos.Actualizar<Entidades.TipoProducto>(tipoproducto, null, Enumeradores.TypeAction.None));
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public JsonResult Delete(Int16 id)
        {
            try
            {
                return Json(Datos.Eliminar<Entidades.TipoProducto>(new Entidades.TipoProducto()
                {
                    ID = id,
                    IDPINCLIENTE = Datos.idPinCliente
                }));
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }
    }
}
