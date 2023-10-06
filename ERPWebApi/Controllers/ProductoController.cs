using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
      
      //Clase creada por generador de código
      [Route("api/[controller]")]
      public class ProductoController: Controller
      {
          [HttpGet]
          public JsonResult Get()
          {
              try
              {
                  List<Entidades.Producto> Result = Datos.Consultar<Entidades.Producto>(new Entidades.Producto()
                  {
                       ID = 0
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
          
          [HttpGet("{id}")]
          public JsonResult Get(Int32 id)
          {
              try
              {
                  List<Entidades.Producto> Result = Datos.Consultar<Entidades.Producto>(new Entidades.Producto()
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
          public string Post([FromBody]Entidades.Producto Producto)
          {
              try
              {
                  Producto.IDPINCLIENTE = Datos.idPinCliente;
                  return Datos.Nuevo<Entidades.Producto>(Producto, null, Enumeradores.TypeAction.None);
              }
              catch (Exception ex)
              {
                  return ex.Message;
              }
          }
          
          [HttpPut]
          public string Put([FromBody]Entidades.Producto Producto)
          {
              try
              {
                  Producto.IDPINCLIENTE = Datos.idPinCliente;
                  return Datos.Actualizar<Entidades.Producto>(Producto, null, Enumeradores.TypeAction.None);
              }
              catch (Exception ex)
              {
                  return ex.Message;
              }
          }

        [HttpPut("{copiar}")]
        public string Put(Int16 Copiar, [FromBody]Entidades.Producto Producto)
        {
            try
            {
                Producto.IDPINCLIENTE = Datos.idPinCliente;
                return Datos.Copiar<Entidades.Producto>(Producto, null, Enumeradores.TypeAction.None);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        [HttpDelete("{id}")]
          public string Delete(Int32 id)
          {
              try
              {
                  return Datos.Eliminar<Entidades.Producto>(new Entidades.Producto()
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
