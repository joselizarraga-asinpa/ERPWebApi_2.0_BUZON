using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class ExistenciaController: Controller
	{
		//[HttpGet]
		//public JsonResult Get()
		//{
		//	try
		//	{
		//		List<Entidades.Existencia> Result = Datos.Consultar<Entidades.Existencia>(new Entidades.Existencia()
		//		{
		//				ID = 0
		//		},
		//		new List<object>().ToArray()
		//		);
		//		return Json(Result);
		//	}
		//	catch (Exception ex)
		//	{
		//		return Json(ex.Message);
		//	}
		//}
		
		[HttpGet("{id}")]
		public JsonResult Get(Int64 id)
		{
			try
			{
				List<Entidades.Existencia> Result = Datos.Consultar<Entidades.Existencia>(new Entidades.Existencia()
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
		public string Post([FromBody]Entidades.Existencia Existencia)
		{
			try
			{
                //return Datos.Nuevo<Entidades.Existencia>(Existencia, null, Enumeradores.TypeAction.None);
                string id = "";
                if (Existencia.lDocDetalle.Count == 0)
                    id = Datos.Nuevo<Entidades.Existencia>(Existencia, null, Enumeradores.TypeAction.None);
                else
                {                    
                    id = Datos.NuevoTrans<Entidades.Existencia>(
                        Existencia, PreparaEntidades(Existencia),
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
		public string Put([FromBody]Entidades.Existencia Existencia)
		{
			try
			{
                //return Datos.Actualizar<Entidades.Existencia>(Existencia, null, Enumeradores.TypeAction.None);
                if (Existencia.lDocDetalle.Count == 0)
                    return Datos.Actualizar<Entidades.Existencia>(Existencia, null, Enumeradores.TypeAction.None);
                else
                {
                    return Datos.ActualizarTrans<Entidades.Existencia>(
                                Existencia, PreparaEntidades(Existencia),
                                Enumeradores.TypeAction.Detail);
                }
            }
			catch (Exception ex)
			{
				return ex.Message;
			}
		}

        protected List<Entidades.Entidad> PreparaEntidades(Entidades.Existencia Existencia)
        {
            List<Entidades.Entidad> lent = new List<Entidades.Entidad>();
            if (Existencia.lDocDetalle.Count > 0)
            {
                Entidades.Entidad ent = new Entidades.Entidad(Existencia.lDocDetalle[0].GetType().Name.ToString(),
                                            Existencia.lDocDetalle.ToArray(),
                                            Existencia.MasterDetailKey,
                                            Enumeradores.TypeAction.Detail);

                if (Existencia.lDocDetalle[0].lClasDet.Count > 0)
                {
                    ent.lEntidad.Add(new Entidades.Entidad(Existencia.lDocDetalle[0].lClasDet[0].GetType().Name.ToString(),
                                            Existencia.lDocDetalle[0].lClasDet.ToArray(),
                                            Existencia.lDocDetalle[0].lClasDet[0].MasterDetailKey,
                                            Existencia.lDocDetalle[0].lClasDet[0].TransactionDetailType, 
                                            false));
                }
                lent.Add(ent);
            }
            return lent;
        }

        [HttpDelete("{id}")]
		public string Delete(Int64 id)
		{
			try
			{
				return Datos.Eliminar<Entidades.Existencia>(new Entidades.Existencia()
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
