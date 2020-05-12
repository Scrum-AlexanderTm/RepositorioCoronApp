using Covid19v3.Models;
using Covid19v3.SD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Covid19v3.Controllers
{
    public class CifrasController : Controller
    {
        private Cifras_SD oCifras_SD = new Cifras_SD();
        private CifrasResponse oREspuesta = new CifrasResponse();

        
        public JsonResult RegistraPrueba(Cifras pBECifras_BE)
        {
            try
            {
                Cifras oCifras_BE = new Cifras();
                oCifras_BE.MensajeError = "";
                oCifras_BE.CodigoError = 0;

                if (!pBECifras_BE.IdTriaje.Equals(""))
                {

                    pBECifras_BE.IdTriaje = (oCifras_SD.RegistraPrueba(pBECifras_BE));

                    return Json(pBECifras_BE, JsonRequestBehavior.AllowGet);

                }
                else
                {

                    return Json(null);
                }


            }
            catch (Exception ex)
            {
                Cifras oCifras_BE = new Cifras();
                oCifras_BE.CodigoError = ex.GetHashCode();
                oCifras_BE.MensajeError = ex.Message;
                return Json(oCifras_BE, JsonRequestBehavior.AllowGet);
            }

        }
        public JsonResult RegistraConfirmado(Cifras pBECifras_BE)
        {
            try
            {
                Cifras oCifras_BE = new Cifras();
                oCifras_BE.MensajeError = "";
                oCifras_BE.CodigoError = 0;

                if (!pBECifras_BE.IdTriaje.Equals(""))
                {

                    pBECifras_BE.IdTriaje = (oCifras_SD.RegistraConfirmado(pBECifras_BE));

                    return Json(pBECifras_BE, JsonRequestBehavior.AllowGet);

                }
                else
                {

                    return Json(null);
                }


            }
            catch (Exception ex)
            {
                Cifras oCifras_BE = new Cifras();
                oCifras_BE.CodigoError = ex.GetHashCode();
                oCifras_BE.MensajeError = ex.Message;
                return Json(oCifras_BE, JsonRequestBehavior.AllowGet);
            }

        }
        public JsonResult RegistraHospitalizado(Cifras pBECifras_BE)
        {
            try
            {
                Cifras oCifras_BE = new Cifras();
                oCifras_BE.MensajeError = "";
                oCifras_BE.CodigoError = 0;

                if (!pBECifras_BE.IdTriaje.Equals(""))
                {

                    pBECifras_BE.IdTriaje = (oCifras_SD.RegistraHospitalizado(pBECifras_BE));

                    return Json(pBECifras_BE, JsonRequestBehavior.AllowGet);

                }
                else
                {

                    return Json(null);
                }


            }
            catch (Exception ex)
            {
                Cifras oCifras_BE = new Cifras();
                oCifras_BE.CodigoError = ex.GetHashCode();
                oCifras_BE.MensajeError = ex.Message;
                return Json(oCifras_BE, JsonRequestBehavior.AllowGet);
            }

        }
        public JsonResult RegistraRecuperadoFallecido(Cifras pBECifras_BE)
        {
            try
            {
                Cifras oCifras_BE = new Cifras();
                oCifras_BE.MensajeError = "";
                oCifras_BE.CodigoError = 0;

                if (!pBECifras_BE.IdTriaje.Equals(""))
                {

                    pBECifras_BE.IdTriaje = (oCifras_SD.RegistraRecuperadoFallecido(pBECifras_BE));

                    return Json(pBECifras_BE, JsonRequestBehavior.AllowGet);

                }
                else
                {

                    return Json(null);
                }


            }
            catch (Exception ex)
            {
                Cifras oCifras_BE = new Cifras();
                oCifras_BE.CodigoError = ex.GetHashCode();
                oCifras_BE.MensajeError = ex.Message;
                return Json(oCifras_BE, JsonRequestBehavior.AllowGet);
            }

        }
        public JsonResult Lista(Cifras pCifras_BE)
        {
            try
            {
                oREspuesta.ObjListaCifras = oCifras_SD.Listar(pCifras_BE);
                return Json(oREspuesta, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                Cifras oCifras_BE = new Cifras();
                oCifras_BE.CodigoError = ex.GetHashCode();
                oCifras_BE.MensajeError = ex.Message;
                oREspuesta.ObjCifras = oCifras_BE;
                return Json(oREspuesta, JsonRequestBehavior.AllowGet);
            }

        }
        public JsonResult ListaReporte()
        {
            try
            {
                oREspuesta.ObjListaCifras = oCifras_SD.ListarReporte();
                return Json(oREspuesta, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                Cifras oCifras_BE = new Cifras();
                oCifras_BE.CodigoError = ex.GetHashCode();
                oCifras_BE.MensajeError = ex.Message;
                oREspuesta.ObjCifras = oCifras_BE;
                return Json(oREspuesta, JsonRequestBehavior.AllowGet);
            }

        }
        public JsonResult ListaReporteDepartamento(System.String pDepartamento)
        {
            try
            {
                oREspuesta.ObjListaCifras = oCifras_SD.ListarReporteDepartamento(pDepartamento);
                return Json(oREspuesta, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                Cifras oCifras_BE = new Cifras();
                oCifras_BE.CodigoError = ex.GetHashCode();
                oCifras_BE.MensajeError = ex.Message;
                oREspuesta.ObjCifras = oCifras_BE;
                return Json(oREspuesta, JsonRequestBehavior.AllowGet);
            }

        }
        public ActionResult Index()
        {
            return View();
        }
    }
}