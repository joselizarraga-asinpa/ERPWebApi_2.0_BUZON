using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;


namespace ERPWebApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        //public IEnumerable<string> Get()
        public JsonResult Get()
        {            
            try
            {

                //Entidades.Usuario Usuario = new Entidades.Usuario() {
                //    ACCESOSISTEMA = true,
                //    EMAIL = "",
                //    ETIQUETA = "",
                //    ID = 0,
                //    IDPERFILUSUARIO = 1,
                //    IDUSUARIO = 0,
                //    IDPINCLIENTE = 1,
                //    NOMBREUSUARIO = "Prueba 9",
                //    PASSWORD = "123456",
                //    TOKEN = "aasdfiewefwefwefwff"
                //};
                //string Id = Datos.Nuevo<Entidades.Usuario>(Usuario, null, Enumeradores.TypeAction.None);
                //Usuario.ID = Int16.Parse(Id);
                //Usuario.NOMBREUSUARIO = "Usuario 9.1";                
                //Datos.Actualizar<Entidades.Usuario>(Usuario, null, Enumeradores.TypeAction.None);
                //Usuario.ID = 20;
                //Datos.Eliminar<Entidades.Usuario>(Usuario);

                //Entidades.CliProv Cliente = new Entidades.CliProv()
                //{
                //    DIASCREDITO = 30,
                //    ESCLIPROV = true,
                //    ETIQUETA = "",
                //    FECHAALTA = DateTime.Now,
                //    ID = 0,
                //    IDDATOSGENERALES = 0,
                //    IDDOMICILIO = 0,
                //    IDSTATUS = 1,
                //    IDPINCLIENTE = 1,
                //    LIMITECREDITO = 10000,
                //    DATOSGENERALES = new Entidades.DatosGenerales()
                //    {
                //        APELLIDOMATERNO = "Lopez",
                //        APELLIDOPATERNO = "Perez",
                //        CURP = "LRE02934023940",
                //        ETIQUETA = "",
                //        ID = 0,
                //        NOMBRE = "Pancho",
                //        RFC = "PAR23423423",
                //        TIPOPERSONA = "FIS"
                //    },
                //    DOMICILIO = new Entidades.Domicilio()
                //    {
                //        CALLE = "Imperio",
                //        CODIGOPOSTAL = "45000",
                //        COLONIA = "Centro",
                //        ID = 0,
                //        IDESTADO = 1,
                //        IDPAIS = 1,
                //        LOCALIDAD = "GDL",
                //        MUNICIPIO = "GUADALAJARA",
                //        NOEXTERIOR = "8",
                //        NOINTERIOR = "",
                //        REFERENCIAS = "Enseguida de Oxxo"
                //    }
                //};

                //string Id = Datos.Nuevo<Entidades.CliProv>(Cliente,
                //    new List<object>()
                //            {
                //                Cliente.DATOSGENERALES, Cliente.DOMICILIO
                //            }.ToArray(), Enumeradores.TypeAction.Main);

                //Cliente.ID = Int32.Parse(Id);
                //Cliente.DATOSGENERALES.NOMBRE = "Cliente Pancho";
                //Cliente.DATOSGENERALES.ID = 4;
                //Cliente.DOMICILIO.CALLE = "Imperio del Sol Naciente";
                //Cliente.DOMICILIO.ID = 4;
                //Datos.Actualizar<Entidades.CliProv>(Cliente,
                //    new List<object>()
                //            {
                //                Cliente.DATOSGENERALES, Cliente.DOMICILIO
                //            }.ToArray(), Enumeradores.TypeAction.Main);

                //List<Entidades.CliProv> Result = Datos.Consultar<Entidades.CliProv>(new Entidades.CliProv()
                //{
                //    ID = 0,
                //    IDPINCLIENTE = 1
                //}, 
                //new List<object>()
                //{
                //    new Entidades.Domicilio(),
                //    new Entidades.DatosGenerales()
                //}.ToArray()
                //);

                //IEnumerable<Dictionary<string, object>> Result = Datos.DataReader("sp_usuarioprueba");                                
                //Procedimiento proc = new Procedimiento("sp_usuarioprueba");                
                //proc.AgregaParametro("@ID", 0 ,"smallint");                
                //IEnumerable<Dictionary<string, object>> Result = Datos.StoredProc(proc);

                //Entidades.TipoProducto TipoProducto = new Entidades.TipoProducto()
                //{
                //    ID = 0,
                //    IDPINCLIENTE = 1,
                //    NOMBRETIPOPRODUCTO = "Materiales",
                //    INVENTARIO = true,
                //    NUMEXTRA1 = "ALTO",
                //    NUMEXTRA2 = "ANCHO",
                //    NUMEXTRA3 = ""
                //};
                //string Id = Datos.Nuevo<Entidades.TipoProducto>(TipoProducto, null, Enumeradores.TypeAction.None);

                //Entidades.TipoProducto TipoProducto = new Entidades.TipoProducto()
                //{
                //    ID = 2,
                //    IDPINCLIENTE = 1,
                //    NOMBRETIPOPRODUCTO = "Modelos",
                //    NUMEXTRA1 = "Alto",
                //    NUMEXTRA2 = "Ancho",
                //    INVENTARIO = true
                //};

                //Datos.Actualizar<Entidades.TipoProducto>(TipoProducto, null, Enumeradores.TypeAction.None);

                List< Entidades.TipoProducto> Result = Datos.Consultar<Entidades.TipoProducto>(new Entidades.TipoProducto()
                {
                    ID = 0,
                    IDPINCLIENTE = 1
                },
               new List<object>().ToArray()
               );

                return Json(Result);

            }
            catch (Exception ex)
            {
                //OutgoingWebResponseContext response = WebOperationContext.Current.OutgoingResponse;
                //response.StatusCode = System.Net.HttpStatusCode.Forbidden;
                //response.StatusDescription = "Server: " + ex.Message;
                return Json(ex.Message);
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public JsonResult Get(string id)
        {
            try
            {
                List<Entidades.TipoProducto> Result = Datos.Consultar<Entidades.TipoProducto>(new Entidades.TipoProducto()
                {
                    ID = short.Parse(id),
                    IDPINCLIENTE = 1
                },
                   new List<object>().ToArray()
                   );

                return Json(Result);

            }
            catch (Exception ex)
            {
                //OutgoingWebResponseContext response = WebOperationContext.Current.OutgoingResponse;
                //response.StatusCode = System.Net.HttpStatusCode.Forbidden;
                //response.StatusDescription = "Server: " + ex.Message;
                return Json(ex.Message);
            }
}

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
