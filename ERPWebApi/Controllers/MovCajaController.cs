using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class MovCajaController: Controller
	{
		[HttpGet]
		public JsonResult Get()
		{
			try
			{
				List<Entidades.MovCaja> Result = Datos.Consultar<Entidades.MovCaja>(new Entidades.MovCaja()
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
		
		[HttpGet("{id}")]
		public JsonResult Get(Int64 id)
		{
			try
			{
				List<Entidades.MovCaja> Result = Datos.Consultar<Entidades.MovCaja>(new Entidades.MovCaja()
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
		public string Post([FromBody]Entidades.MovCaja MovCaja)
		{
			try
			{
                //return Datos.Nuevo<Entidades.MovCaja>(MovCaja, null, Enumeradores.TypeAction.None);                
                if (MovCaja.lMovCajaDetalle.Count == 0)
                {
                    return Datos.Nuevo<Entidades.MovCaja>(MovCaja, null, Enumeradores.TypeAction.None);
                }
                else
                {
                    return Datos.NuevoTrans<Entidades.MovCaja>(
                        MovCaja, PreparaEntidades(MovCaja),
                        Enumeradores.TypeAction.Detail);
                }                
            }
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.MovCaja MovCaja)
		{
			try
			{
                //return Datos.Actualizar<Entidades.MovCaja>(MovCaja, null, Enumeradores.TypeAction.None);                
                if (MovCaja.lMovCajaDetalle.Count == 0)
                {
                    return Datos.Actualizar<Entidades.MovCaja>(MovCaja, null, Enumeradores.TypeAction.None);
                }
                else
                {
                    return Datos.ActualizarTrans<Entidades.MovCaja>(
                        MovCaja, PreparaEntidades(MovCaja),
                        Enumeradores.TypeAction.Detail);
                }                
            }
			catch (Exception ex)
			{
				return ex.Message;
			}
		}

        protected List<Entidades.Entidad> PreparaEntidades(Entidades.MovCaja MovCaja)
        {
            List<Entidades.Entidad> lent = new List<Entidades.Entidad>();
            if (MovCaja.lMovCajaDetalle.Count > 0)
                lent.Add(new Entidades.Entidad(MovCaja.lMovCajaDetalle[0].GetType().Name.ToString(),
                                            MovCaja.lMovCajaDetalle.ToArray(),
                                            MovCaja.lMovCajaDetalle[0].MasterDetailKey,
                                            MovCaja.lMovCajaDetalle[0].TransactionDetailType));
            return lent;
        }


        [HttpDelete("{id}")]
		public string Delete(Int64 id)
		{
			try
			{
				return Datos.Eliminar<Entidades.MovCaja>(new Entidades.MovCaja()
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
