using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
      
      //Clase creada por generador de código
      [Route("api/[controller]")]
      public class DocumentoController: Controller
      {

        List<Entidades.Entidad> lent = new List<Entidades.Entidad>();
        List<Entidades.DocDetalle> lDocDet = new List<Entidades.DocDetalle>();

        [HttpGet]
          public JsonResult Get()
          {
              try
              {
                  List<Entidades.Documento> Result = Datos.Consultar<Entidades.Documento>(new Entidades.Documento()
                  {
                       ID = 0
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

        [HttpGet("{id}/{folio}")]
        public JsonResult Get(Int64 id, string folio)
        {
            try
            {
                List<Entidades.Documento> Result = Datos.Consultar<Entidades.Documento>(new Entidades.Documento()
                {
                    ID = id,
                    FOLIO = folio
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
          public JsonResult Get(Int64 id)
          {
              try
              {
                  List<Entidades.Documento> Result = Datos.Consultar<Entidades.Documento>(new Entidades.Documento()
                  {
                       ID = id
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
          public string Post([FromBody]Entidades.Documento Documento)
          {
              try
              {                
                if (Documento.lDocDetalle.Count > 0 || Documento.lExistencia.Count > 0)
                {
                    return Datos.NuevoTrans<Entidades.Documento>(
                        Documento, PreparaEntidades(Documento),
                        Enumeradores.TypeAction.Detail);
                }
                else
                {
                    return Datos.Nuevo<Entidades.Documento>(Documento, null, Enumeradores.TypeAction.None);
                }
            }
              catch (Exception ex)
              {
                  return ex.Message;
              }
          }

        [HttpPut]
        public string Put([FromBody]Entidades.Documento Documento)
        {
            try
            {                
                if (Documento.lDocDetalle.Count > 0 || Documento.lExistencia.Count > 0)
                {
                    Documento.MOSTRARID = true;
                    return Datos.ActualizarTrans<Entidades.Documento>(
                        Documento, PreparaEntidades(Documento),
                        Enumeradores.TypeAction.Detail);
                }
                else
                {
                    return Datos.Actualizar<Entidades.Documento>(Documento, null, Enumeradores.TypeAction.None);
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        [HttpPut("{copiar}")]
        public string Put(Int16 Copiar, [FromBody]Entidades.Documento Documento)
        {
            try
            {                
                return Datos.Copiar<Entidades.Documento>(Documento, null, Enumeradores.TypeAction.None);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        protected List<Entidades.Entidad> PreparaEntidades(Entidades.Documento Doc)
        {
            lent = new List<Entidades.Entidad>();
            lDocDet = new List<Entidades.DocDetalle>();
            if (Doc.lDocDetalle.Count > 0)
            {
                PreparaEntidadesDocDet(Doc.lDocDetalle);
            }
            if(Doc.lExistencia.Count > 0)
            {
                PreparaEntidadesExistencia(Doc.lExistencia);
            }
            return lent;
        }

        protected List<Entidades.Entidad> PreparaEntidadesExistencia(List<Entidades.Existencia> lExistencia)
        {
            foreach (Entidades.Existencia Exis in lExistencia)
            {
                List<Entidades.Existencia> lexis = new List<Entidades.Existencia>();
                lexis.Add(Exis);
                Entidades.Entidad entExis = new Entidades.Entidad(lExistencia[0].GetType().Name.ToString(),
                                        lexis.ToArray(),
                                        Exis.MasterDetailKey,
                                        Exis.TransactionDetailType);
                if (Exis.lDocDetalle.Count > 0)
                {
                    entExis.lEntidad.Add(new Entidades.Entidad(Exis.lDocDetalle[0].GetType().Name.ToString(),
                                            Exis.lDocDetalle.ToArray(),
                                            "@IdDocumento",
                                            Exis.lDocDetalle[0].TransactionDetailType));
                }
                lent.Add(entExis);
            }
            return lent;
        }

        protected List<Entidades.Entidad> PreparaEntidadesDocDet(List<Entidades.DocDetalle> lDocDetalle)
        {
            foreach (Entidades.DocDetalle DocDetalle in lDocDetalle)
            {
                lDocDet = new List<Entidades.DocDetalle>();
                lDocDet.Add(DocDetalle);
                Entidades.Entidad entDocDet = new Entidades.Entidad(lDocDetalle[0].GetType().Name.ToString(),
                                        lDocDet.ToArray(),
                                        "",
                                        DocDetalle.TransactionDetailType);
                if (DocDetalle.lClasDet.Count > 0)
                    entDocDet.lEntidad.Add(new Entidades.Entidad(DocDetalle.lClasDet[0].GetType().Name.ToString(),
                                                DocDetalle.lClasDet.ToArray(),
                                                DocDetalle.lClasDet[0].MasterDetailKey,
                                                DocDetalle.lClasDet[0].TransactionDetailType));
                if (DocDetalle.lDocDetalle.Count > 0)
                    entDocDet.lEntidad.Add(new Entidades.Entidad(DocDetalle.lDocDetalle[0].GetType().Name.ToString(),
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
                        Entidades.Entidad entExis = new Entidades.Entidad(DocDetalle.lExistencia[0].GetType().Name.ToString(),
                                                lexis.ToArray(),
                                                exi.MasterDetailKey,
                                                exi.TransactionDetailType);
                        if (exi.lDocDetalle.Count > 0)
                        {
                            entExis.lEntidad.Add(new Entidades.Entidad(exi.lDocDetalle[0].GetType().Name.ToString(),
                                                    exi.lDocDetalle.ToArray(),
                                                    exi.lDocDetalle[0].MasterDetailKey,
                                                    exi.lDocDetalle[0].TransactionDetailType));
                        }
                        entDocDet.lEntidad.Add(entExis);
                    }
                }
                lent.Add(entDocDet);
            }            
            return lent;
        }

        [HttpDelete("{id}")]
          public string Delete(Int64 id)
          {
              try
              {
                  return Datos.Eliminar<Entidades.Documento>(new Entidades.Documento()
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
