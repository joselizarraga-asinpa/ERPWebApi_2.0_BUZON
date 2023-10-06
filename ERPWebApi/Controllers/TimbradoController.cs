using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERPWebApi.DAL;

namespace ERPWebApi.Controllers
{
	
	//Clase creada por generador de código
	[Route("api/[controller]")]
	public class TimbradoController: Controller
	{
		
		[HttpGet("{iddocfiscal}")]
		public JsonResult Get(long IdDocFiscal)
		{
            List<Entidades.Timbrado> lTim = new List<Entidades.Timbrado>();
            Entidades.Timbrado eTim = new Entidades.Timbrado();
            CFDI.Timbrado cfdiTim = new CFDI.Timbrado();
            try
            {
                eTim = cfdiTim.GetCFDI(IdDocFiscal);
                if (eTim.HasError)
                {
                    return Json(eTim.Error);
                }
                else
                {
                    lTim.Add(eTim);
                    return Json(lTim);
                }
            }
            catch (Exception ex)
            {
                return Json(ex.Message);                
            }            
        }
        
        [HttpPost]
        public JsonResult Post([FromBody]Entidades.Timbrado eTimbrado)
        {
            List<Entidades.Timbrado> lTim = new List<Entidades.Timbrado>();
            Entidades.Timbrado eTim = new Entidades.Timbrado();
            CFDI.Timbrado cfdiTim = new CFDI.Timbrado();
            eTim.HasError = true;
            try
            {
                switch (eTimbrado.enTimbradoAccion)
                {
                    case Enumeradores.LogAction.Timbrar:                    //Leer el Cfdi
                        eTim = cfdiTim.GetCFDI(eTimbrado.IDDOCFISCAL);
                        break;
                    case Enumeradores.LogAction.Status:                      //Obtener el Status del Cfdi
                        eTim = cfdiTim.GetStatusCFDI(eTimbrado.IDDOCFISCAL);
                        break;
                    case Enumeradores.LogAction.Cancelar:                    //Cancelar el Cfdi
                        eTim = cfdiTim.CancelCFDI(eTimbrado.IDDOCFISCAL);
                        break;
                    case Enumeradores.LogAction.SolicitudesPendientes:      //Solicitudes pendientes de Aceptar/Rechazar
                        eTim = cfdiTim.GetSolicitudesPendientes(eTimbrado.IDSUCURSAL);
                        break;
                    case Enumeradores.LogAction.AceptarRechazar:            //Aceptar/Rechazar CFDI
                        eTim = cfdiTim.AceptarRechazarCFDI(eTimbrado.IDSUCURSAL, eTimbrado.FOLIOFISCAL, eTimbrado.ACEPTARRECHAZAR);
                        break;
                    case Enumeradores.LogAction.SaldoTimbres:               //Saldo de Timbres
                        eTim = cfdiTim.SaldoTimbres(eTimbrado.IDSUCURSAL);
                        break;
                    case Enumeradores.LogAction.ValidaRFC:                  //Validación de RFC
                        eTim = cfdiTim.ValidaRFC(eTimbrado.IDSUCURSAL, eTimbrado.RFC);
                        break;
                    case Enumeradores.LogAction.ValidaXML:                  //Validación de XML
                        eTim = cfdiTim.ValidaXML(eTimbrado.IDSUCURSAL, eTimbrado.ARCHIVOXML);
                        break;
                }
                lTim.Add(eTim);
                return Json(lTim);
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }


    }
}
