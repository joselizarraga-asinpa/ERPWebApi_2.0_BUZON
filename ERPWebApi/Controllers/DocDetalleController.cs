using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
      
      //Clase creada por generador de código
      [Route("api/[controller]")]
      public class DocDetalleController: Controller
      {
          //[HttpGet]
          //public JsonResult Get()
          //{
          //    try
          //    {
          //        List<Entidades.DocDetalle> Result = Datos.Consultar<Entidades.DocDetalle>(new Entidades.DocDetalle()
          //        {
          //             ID = 0
          //        },
          //        new List<object>().ToArray()
          //        );
          //        return Json(Result);
          //    }
          //    catch (Exception ex)
          //    {
          //        return Json(ex.Message);
          //    }
          //}
          
          [HttpGet("{iddocumento}/{id}/{componentes}")]
          public JsonResult Get(long iddocumento, Int64 id, bool componentes)
          {
              try
              {
                  List<Entidades.DocDetalle> Result = Datos.Consultar<Entidades.DocDetalle>(new Entidades.DocDetalle()
                  {
                       ID = id
                       ,IDDOCUMENTO = iddocumento
                       ,COMPONENTES = componentes
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
          public string Post([FromBody]Entidades.DocDetalle DocDetalle)
          {
              try
              {
                //return Datos.Nuevo<Entidades.DocDetalle>(DocDetalle, null, Enumeradores.TypeAction.None);
                string id = "";
                if (DocDetalle.lDocDetalle == null)
                    DocDetalle.lDocDetalle = new List<Entidades.DocDetalle>();
                if (DocDetalle.lExistencia == null)
                    DocDetalle.lExistencia = new List<Entidades.Existencia>();
                if (DocDetalle.lClasDet.Count == 0 && DocDetalle.lDocDetalle.Count == 0 && DocDetalle.lExistencia.Count == 0)
                {
                    id = Datos.Nuevo<Entidades.DocDetalle>(DocDetalle, null, Enumeradores.TypeAction.None);
                }
                else
                {                    
                    id = Datos.NuevoTrans<Entidades.DocDetalle>(
                        DocDetalle, PreparaEntidades(DocDetalle),
                        Enumeradores.TypeAction.Detail);                    
                }                
                return id;
            }
              catch (Exception ex)
              {
                  return ex.Message;
              }
          }
        
        [HttpPut]
          public string Put([FromBody]Entidades.DocDetalle DocDetalle)
          {
              try
              {
                //return Datos.Actualizar<Entidades.DocDetalle>(DocDetalle, null, Enumeradores.TypeAction.None);
                if (DocDetalle.lDocDetalle == null)
                    DocDetalle.lDocDetalle = new List<Entidades.DocDetalle>();
                if (DocDetalle.lExistencia == null)
                    DocDetalle.lExistencia = new List<Entidades.Existencia>();
                if (DocDetalle.lClasDet.Count == 0 && DocDetalle.lDocDetalle.Count == 0 && DocDetalle.lExistencia.Count == 0)
                    return Datos.Actualizar<Entidades.DocDetalle>(DocDetalle, null, Enumeradores.TypeAction.None);
                else
                {
                    return Datos.ActualizarTrans<Entidades.DocDetalle>(
                        DocDetalle, PreparaEntidades(DocDetalle),
                        Enumeradores.TypeAction.Detail);                    
                }
            }
              catch (Exception ex)
              {
                  return ex.Message;
              }
          }

          protected List<Entidades.Entidad> PreparaEntidades(Entidades.DocDetalle DocDetalle)
          {
            List<Entidades.Entidad> lent = new List<Entidades.Entidad>();
            if (DocDetalle.lClasDet.Count > 0)
                lent.Add(new Entidades.Entidad(DocDetalle.lClasDet[0].GetType().Name.ToString(),
                                            DocDetalle.lClasDet.ToArray(),
                                            DocDetalle.lClasDet[0].MasterDetailKey,
                                            DocDetalle.lClasDet[0].TransactionDetailType));
            if (DocDetalle.lDocDetalle.Count > 0)
                lent.Add(new Entidades.Entidad(DocDetalle.lDocDetalle[0].GetType().Name.ToString(),
                                            DocDetalle.lDocDetalle.ToArray(),
                                            DocDetalle.lDocDetalle[0].MasterDetailKey,
                                            DocDetalle.lDocDetalle[0].TransactionDetailType));
            if (DocDetalle.lExistencia.Count > 0)
            {
                List<Entidades.Existencia> lexis = new List<Entidades.Existencia>();
                foreach (Entidades.Existencia exi in DocDetalle.lExistencia)
                {
                    lexis = new List<Entidades.Existencia>();
                    lexis.Add(exi);
                    Entidades.Entidad ent = new Entidades.Entidad(DocDetalle.lExistencia[0].GetType().Name.ToString(),
                                            lexis.ToArray(),
                                            exi.MasterDetailKey,
                                            exi.TransactionDetailType);
                    if (exi.lDocDetalle.Count > 0)
                    {
                        ent.lEntidad.Add(new Entidades.Entidad(exi.lDocDetalle[0].GetType().Name.ToString(),
                                                exi.lDocDetalle.ToArray(),
                                                exi.lDocDetalle[0].MasterDetailKey,
                                                exi.lDocDetalle[0].TransactionDetailType));
                    }
                    lent.Add(ent);
                }
            }
            return lent;
        }
          
          [HttpDelete("{id}")]
          public string Delete(Int64 id)
          {
              try
              {
                  return Datos.Eliminar<Entidades.DocDetalle>(new Entidades.DocDetalle()
                  {
                       ID = id
                  });
              }
              catch (Exception ex)
              {
                  return ex.Message;
              }
          }
      }
}
