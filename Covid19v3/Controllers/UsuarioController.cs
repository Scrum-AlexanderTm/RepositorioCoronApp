using Covid19v3.Models;
using Covid19v3.SD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Covid19v3.Controllers
{
    
    public class UsuarioController : Controller
    {
       
        private Usuario_SD oUsuario_SD = new Usuario_SD();
        private UsuarioResponse oREspuesta = new UsuarioResponse();
       
        public JsonResult BuscarUsuarioPorNombres(String pNombres)
        {
            Usuario pUsuario = new Usuario();
            try
            {
                pUsuario.Nombres = pNombres;
                oREspuesta.ObjListaUsuario = oUsuario_SD.Listar(pUsuario);
            }
            catch (Exception ex)
            {
                pUsuario.CodigoError = 5;
                pUsuario.DescripcionError = ex.Message;
                oREspuesta.ObjUsuario = pUsuario;
            }
            return Json(oREspuesta, JsonRequestBehavior.AllowGet);
        }
        
        public JsonResult ListarKey(System.Int32 pCodigoUsuario)
        {
            try
            {
                oREspuesta.ObjUsuario = oUsuario_SD.ListarKey(pCodigoUsuario);
                return Json(oREspuesta, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                Usuario oUsuario_BE = new Usuario();
                oUsuario_BE.CodigoError = ex.GetHashCode();
                oUsuario_BE.MensajeError = ex.Message;
                oREspuesta.ObjUsuario = oUsuario_BE;
                return Json(oREspuesta, JsonRequestBehavior.AllowGet);
            }

        }
        [Authorize(Roles = "Admin")]
        public JsonResult Lista(Usuario pUsuario_BE)
        {
            try
            {
                oREspuesta.ObjListaUsuario = oUsuario_SD.Listar(pUsuario_BE);
                return Json(oREspuesta, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                Usuario oUsuario_BE = new Usuario();
                oUsuario_BE.CodigoError = ex.GetHashCode();
                oUsuario_BE.MensajeError = ex.Message;
                oREspuesta.ObjUsuario = oUsuario_BE;
                return Json(oREspuesta, JsonRequestBehavior.AllowGet);
            }

        }
        
        public JsonResult RegistraModifica(Usuario pBEUsuario_BE, string pTipoTransaccion)
        {
            try
            {
                Usuario oUsuario_BE = new Usuario();
                oUsuario_BE.MensajeError = "";
                oUsuario_BE.CodigoError = 0;

                if (!pBEUsuario_BE.Nombres.Equals(""))
                {

                    pBEUsuario_BE.Nombres = Convert.ToString(oUsuario_SD.RegistraModifica(pBEUsuario_BE, pTipoTransaccion));

                    return Json(pBEUsuario_BE, JsonRequestBehavior.AllowGet);

                }
                else
                {

                    return Json(null);
                }


            }
            catch (Exception ex)
            {
                Usuario oUsuario_BE = new Usuario();
                oUsuario_BE.CodigoError = ex.GetHashCode();
                oUsuario_BE.MensajeError = ex.Message;
                return Json(oUsuario_BE, JsonRequestBehavior.AllowGet);
            }

        }
        [Authorize(Roles = "Admin")]
        public JsonResult Elimina(System.Int32 pCodigoUsuario)
        {
            try
            {
                Usuario oUsuario_BE = new Usuario();
                oUsuario_BE.CodigoError = 0;
                oUsuario_BE.MensajeError = "";
                oUsuario_BE.Eliminado = oUsuario_SD.Elimina(pCodigoUsuario);
                return Json(oUsuario_BE, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                Usuario oUsuario_BE = new Usuario();
                oUsuario_BE.CodigoError = ex.GetHashCode();
                oUsuario_BE.MensajeError = ex.Message;
                return Json(oUsuario_BE, JsonRequestBehavior.AllowGet);
            }
        }
        [Authorize(Roles = "Admin")]
        public ActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {

            return View();
        }
        [Authorize(Roles = "Admin")]
        public ActionResult Edit()
        {

            return View();
        }
    }


    
}