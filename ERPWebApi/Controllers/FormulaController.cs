using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
      
      //Clase creada por generador de código
      [Route("api/[controller]")]
      public class FormulaController: Controller
      {
          [HttpGet]
          public JsonResult Get()
          {
              try
              {
                  List<Entidades.Formula> Result = Datos.Consultar<Entidades.Formula>(new Entidades.Formula()
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
                  List<Entidades.Formula> Result = Datos.Consultar<Entidades.Formula>(new Entidades.Formula()
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
          public string Post([FromBody]Entidades.Formula Formula)
          {
              try
              {
                  Formula.IDPINCLIENTE = Datos.idPinCliente;
                  return Datos.Nuevo<Entidades.Formula>(Formula, null, Enumeradores.TypeAction.None);
              }
              catch (Exception ex)
              {
                  return ex.Message;
              }
          }
          
          [HttpPut]
          public string Put([FromBody]Entidades.Formula Formula)
          {
              try
              {
                  Formula.IDPINCLIENTE = Datos.idPinCliente;
                  return Datos.Actualizar<Entidades.Formula>(Formula, null, Enumeradores.TypeAction.None);
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
                  return Datos.Eliminar<Entidades.Formula>(new Entidades.Formula()
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
