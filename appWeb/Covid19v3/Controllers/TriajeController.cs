using Covid19v3.Models;
using Covid19v3.SD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Covid19v3.Controllers
{
    public class TriajeController : Controller
    {
        // GET: Triaje

        private Triaje_SD oTriaje_SD = new Triaje_SD();
        private TriajeResponse oREspuesta = new TriajeResponse();

        public JsonResult BuscarTriajePorNroDocumentoEvaluacion(System.String pDocumento)
        {

            Triaje pTriaje = new Triaje();
            try
            {
                pTriaje.NumeroDocumento = pDocumento;

                oREspuesta.ObjListaTriaje = oTriaje_SD.ListarDocumentoEvaluacion(pDocumento);
            }
            catch (Exception ex)
            {
                pTriaje.CodigoError = 5;
                pTriaje.DescripcionError = ex.Message;
                oREspuesta.ObjTriaje = pTriaje;
            }
            return Json(oREspuesta, JsonRequestBehavior.AllowGet);

        }
        public JsonResult BuscarTriajePorNroDocumentoConRiego(System.String pDocumento)
        {
            Triaje pTriaje = new Triaje();
            try
            {
                pTriaje.NumeroDocumento = pDocumento;
                oREspuesta.ObjListaTriaje = oTriaje_SD.ListarDocumentoConRiego(pDocumento);
            }
            catch (Exception ex)
            {
                pTriaje.CodigoError = 5;
                pTriaje.DescripcionError = ex.Message;
                oREspuesta.ObjTriaje = pTriaje;
            }
            return Json(oREspuesta, JsonRequestBehavior.AllowGet);
            
        }
        public JsonResult BuscarTriajePorNroDocumento(System.String pDocumento)
        {
            Triaje pTriaje = new Triaje();
            try
            {
                pTriaje.NumeroDocumento = pDocumento;
                oREspuesta.ObjListaTriaje = oTriaje_SD.ListarDocumento(pDocumento);
            }
            catch (Exception ex)
            {
                pTriaje.CodigoError = 5;
                pTriaje.DescripcionError = ex.Message;
                oREspuesta.ObjTriaje = pTriaje;
            }
            return Json(oREspuesta, JsonRequestBehavior.AllowGet);

        }
        public JsonResult ListarTriajePruebas()
        {
            Triaje pTriaje = new Triaje();
            try
            {
               
                oREspuesta.ObjListaTriaje = oTriaje_SD.ListarTriajePrueba();
             
            }
            catch (Exception ex)
            {
                pTriaje.CodigoError = 5;
                pTriaje.DescripcionError = ex.Message;
                oREspuesta.ObjTriaje = pTriaje;
            }
            return Json(oREspuesta, JsonRequestBehavior.AllowGet);
        }
        public JsonResult ListarTriajeConfirmado()
        {
            Triaje pTriaje = new Triaje();
            try
            {

                oREspuesta.ObjListaTriaje = oTriaje_SD.ListarTriajeConfirmado();

            }
            catch (Exception ex)
            {
                pTriaje.CodigoError = 5;
                pTriaje.DescripcionError = ex.Message;
                oREspuesta.ObjTriaje = pTriaje;
            }
            return Json(oREspuesta, JsonRequestBehavior.AllowGet);
        }
        public JsonResult ListarTriajeHospitalizado()
        {
            Triaje pTriaje = new Triaje();
            try
            {

                oREspuesta.ObjListaTriaje = oTriaje_SD.ListarTriajeHospitalizado();

            }
            catch (Exception ex)
            {
                pTriaje.CodigoError = 5;
                pTriaje.DescripcionError = ex.Message;
                oREspuesta.ObjTriaje = pTriaje;
            }
            return Json(oREspuesta, JsonRequestBehavior.AllowGet);
        }
        public JsonResult ListarTriajeRecuperado()
        {
            Triaje pTriaje = new Triaje();
            try
            {

                oREspuesta.ObjListaTriaje = oTriaje_SD.ListarTriajeRecuperado();

            }
            catch (Exception ex)
            {
                pTriaje.CodigoError = 5;
                pTriaje.DescripcionError = ex.Message;
                oREspuesta.ObjTriaje = pTriaje;
            }
            return Json(oREspuesta, JsonRequestBehavior.AllowGet);
        }
        public JsonResult ListarTriajeFallecido()
        {
            Triaje pTriaje = new Triaje();
            try
            {

                oREspuesta.ObjListaTriaje = oTriaje_SD.ListarTriajeFallecido();

            }
            catch (Exception ex)
            {
                pTriaje.CodigoError = 5;
                pTriaje.DescripcionError = ex.Message;
                oREspuesta.ObjTriaje = pTriaje;
            }
            return Json(oREspuesta, JsonRequestBehavior.AllowGet);
        }
        public JsonResult ListarKey(System.Int32 pCodigoTriaje)
        {
            try
            {
                oREspuesta.ObjTriaje = oTriaje_SD.ListarKey(pCodigoTriaje);
                return Json(oREspuesta, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                Triaje oTriaje_BE = new Triaje();
                oTriaje_BE.CodigoError = ex.GetHashCode();
                oTriaje_BE.MensajeError = ex.Message;
                oREspuesta.ObjTriaje = oTriaje_BE;
                return Json(oREspuesta, JsonRequestBehavior.AllowGet);
            }

        }

        public JsonResult Lista()
        {
            try
            {
                oREspuesta.ObjListaTriaje = oTriaje_SD.Listar();
                return Json(oREspuesta, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                Triaje oTriaje_BE = new Triaje();
                oTriaje_BE.CodigoError = ex.GetHashCode();
                oTriaje_BE.MensajeError = ex.Message;
                oREspuesta.ObjTriaje = oTriaje_BE;
                return Json(oREspuesta, JsonRequestBehavior.AllowGet);
            }

        }
        public JsonResult ListaTriaje()
        {
            try
            {
                oREspuesta.ObjListaTriaje = oTriaje_SD.ListarTriaje();
                return Json(oREspuesta, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                Triaje oTriaje_BE = new Triaje();
                oTriaje_BE.CodigoError = ex.GetHashCode();
                oTriaje_BE.MensajeError = ex.Message;
                oREspuesta.ObjTriaje = oTriaje_BE;
                return Json(oREspuesta, JsonRequestBehavior.AllowGet);
            }

        }

        public JsonResult RegistraModifica(Triaje pBETriaje_BE, string pTipoTransaccion)
        {
            try
            {
                Triaje oTriaje_BE = new Triaje();
                oTriaje_BE.MensajeError = "";
                oTriaje_BE.CodigoError = 0;

                if (!pBETriaje_BE.NumeroDocumento.Equals(""))
                {

                    pBETriaje_BE.NumeroDocumento = Convert.ToString(oTriaje_SD.RegistraModifica(pBETriaje_BE, pTipoTransaccion));

                    return Json(pBETriaje_BE, JsonRequestBehavior.AllowGet);

                }
                else
                {

                    return Json(null);
                }


            }
            catch (Exception ex)
            {
                Triaje oTriaje_BE = new Triaje();
                oTriaje_BE.CodigoError = ex.GetHashCode();
                oTriaje_BE.MensajeError = ex.Message;
                return Json(oTriaje_BE, JsonRequestBehavior.AllowGet);
            }

        }
        public JsonResult Elimina(System.Int32 pCodigoTriaje)
        {
            try
            {
                Triaje oTriaje_BE = new Triaje();
                oTriaje_BE.CodigoError = 0;
                oTriaje_BE.MensajeError = "";
                oTriaje_BE.Eliminado = oTriaje_SD.Elimina(pCodigoTriaje);
                return Json(oTriaje_BE, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                Triaje oTriaje_BE = new Triaje();
                oTriaje_BE.CodigoError = ex.GetHashCode();
                oTriaje_BE.MensajeError = ex.Message;
                return Json(oTriaje_BE, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index2()
        {
            return View();
        }
        public ActionResult Index3()
        {
            return View();
        }
        public ActionResult Index4()
        {
            return View();
        }
        public ActionResult Index5()
        {
            return View();
        }
        public ActionResult Index6()
        {
            return View();
        }
        public ActionResult Index7()
        {
            return View();
        }
        public ActionResult Create()
        {

            return View();
        }

    }
}