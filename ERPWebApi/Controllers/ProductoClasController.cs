using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
      
      //Clase creada por generador de código
      [Route("api/[controller]")]
      public class ProductoClasController: Controller
      {
                   
          [HttpGet("{idproducto}/{idclas}")]
          public JsonResult Get(Int32 idproducto, Int32 idclas)
          {
              try
              {
                  List<Entidades.ProductoClas> Result = Datos.Consultar<Entidades.ProductoClas>(new Entidades.ProductoClas()
                  {
                       IDPRODUCTO = idproducto
                      ,IDCLAS = idclas
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
          public string Post([FromBody]Entidades.ProductoClas ProductoClas)
          {
              try
              {
                if (ProductoClas.lProductoClas.Count > 0)
                {
                    return Datos.ActualizarInsertarTrans<Entidades.ProductoClas>(
                        ProductoClas, PreparaEntidades(ProductoClas),
                        Enumeradores.TypeAction.None);
                }
                else
                    return Datos.Nuevo<Entidades.ProductoClas>(ProductoClas, null, Enumeradores.TypeAction.None);
              }
              catch (Exception ex)
              {
                  return ex.Message;
              }
          }
          
          [HttpPut]
          public string Put([FromBody]Entidades.ProductoClas ProductoClas)          
          {
              try
              {
                  if(ProductoClas.lProductoClas.Count > 0)
                  {
                    return Datos.ActualizarInsertarTrans<Entidades.ProductoClas>(
                        ProductoClas, PreparaEntidades(ProductoClas),
                        Enumeradores.TypeAction.None);
                  }
                  else
                    return Datos.Actualizar<Entidades.ProductoClas>(ProductoClas, null, Enumeradores.TypeAction.None);
              }
              catch (Exception ex)
              {
                  return ex.Message;
              }
          }

        protected List<Entidades.Entidad> PreparaEntidades(Entidades.ProductoClas ProductoClas)
        {
            List<Entidades.Entidad> lent = new List<Entidades.Entidad>();
            if (ProductoClas.lProductoClas.Count > 0)
                lent.Add(new Entidades.Entidad(ProductoClas.lProductoClas[0].GetType().Name.ToString(),
                                            ProductoClas.lProductoClas.ToArray(),
                                            ProductoClas.lProductoClas[0].MasterDetailKey,
                                            ProductoClas.lProductoClas[0].TransactionDetailType));
            return lent;
        }

        [HttpDelete("{idproducto}/{idclas}")]
          public string Delete(Int32 idproducto, Int32 idclas)
          {
              try
              {
                  return Datos.Eliminar<Entidades.ProductoClas>(new Entidades.ProductoClas()
                  {
                       IDPRODUCTO = idproducto
                      ,IDCLAS = idclas
                  });
              }
              catch (Exception ex)
              {
                  return ex.Message;
              }
          }
      }
}
