using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class EmpresaController: Controller
	{
        [HttpGet("{buscar}/{id}")]
        public JsonResult Get(string buscar, Int32 id)
        {
            try
            {
                List<Entidades.Empresa> Result = Datos.Buscar<Entidades.Empresa>(new Entidades.Empresa()
                {
                    ID = 0,
                    IDPINCLIENTE = Datos.idPinCliente,
                    NOMBREEMPRESA = (buscar == @"""" ? "" : buscar)
                },
                new List<object>().ToArray()
                );
                foreach (Entidades.Empresa emp in Result)
                {
                    List<Entidades.DatosGenerales> dg = Datos.Consultar<Entidades.DatosGenerales>(new Entidades.DatosGenerales() { ID = emp.IDDATOSGENERALES }, new List<object>().ToArray());
                    if (dg.Count > 0)
                        Result[0].eDatosGenerales = dg[0];
                    List<Entidades.Domicilio> dom = Datos.Consultar<Entidades.Domicilio>(new Entidades.Domicilio() { ID = emp.IDDOMICILIO }, new List<object>().ToArray());
                    if (dom.Count > 0)
                        Result[0].eDomicilio = dom[0];
                }
                return Json(Result);
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }

        [HttpGet("{id}")]
		public JsonResult Get(Int16 id)
		{
			try
			{
				List<Entidades.Empresa> Result = Datos.Consultar<Entidades.Empresa>(new Entidades.Empresa()
				{
						 ID = id
						,IDPINCLIENTE = Datos.idPinCliente
				},
				new List<object>().ToArray()
				);
                foreach (Entidades.Empresa emp in Result)
                {
                    List<Entidades.DatosGenerales> dg = Datos.Consultar<Entidades.DatosGenerales>(new Entidades.DatosGenerales() { ID = emp.IDDATOSGENERALES }, new List<object>().ToArray());
                    if (dg.Count > 0)
                        Result[0].eDatosGenerales = dg[0];
                    List<Entidades.Domicilio> dom = Datos.Consultar<Entidades.Domicilio>(new Entidades.Domicilio() { ID = emp.IDDOMICILIO }, new List<object>().ToArray());
                    if (dom.Count > 0)
                        Result[0].eDomicilio = dom[0];
                }
                return Json(Result);
			}
			catch (Exception ex)
			{
				return Json(ex.Message);
			}
		}
		
		[HttpPost]
		public string Post([FromBody]Entidades.Empresa Empresa)
		{
			try
			{
				Empresa.IDPINCLIENTE = Datos.idPinCliente;
                if (Empresa.eDomicilio != null)
                {
                    Empresa.IDDOMICILIO = Funciones.StringToLong(Datos.Nuevo<Entidades.Domicilio>(Empresa.eDomicilio, null, Enumeradores.TypeAction.None));
                }
                if (Empresa.eDatosGenerales != null)
                {
                    Empresa.IDDATOSGENERALES = Funciones.StringToLong(Datos.Nuevo<Entidades.DatosGenerales>(Empresa.eDatosGenerales, null, Enumeradores.TypeAction.None));
                }
				return Datos.Nuevo<Entidades.Empresa>(Empresa, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpPut]
		public string Put([FromBody]Entidades.Empresa Empresa)
		{
			try
			{
				Empresa.IDPINCLIENTE = Datos.idPinCliente;
                if (Empresa.eDomicilio != null)
                {                    
                    Empresa.IDDOMICILIO = Funciones.StringToLong(Datos.Actualizar<Entidades.Domicilio>(Empresa.eDomicilio, null, Enumeradores.TypeAction.None));
                }
                if (Empresa.eDatosGenerales != null)
                {
                    Empresa.IDDATOSGENERALES = Funciones.StringToLong(Datos.Actualizar<Entidades.DatosGenerales>(Empresa.eDatosGenerales, null, Enumeradores.TypeAction.None));
                }
                return Datos.Actualizar<Entidades.Empresa>(Empresa, null, Enumeradores.TypeAction.None);
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		
		[HttpDelete("{id}")]
		public string Delete(Int16 id)
		{
			try
			{
				return Datos.Eliminar<Entidades.Empresa>(new Entidades.Empresa()
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
