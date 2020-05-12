using Covid19v3.Models;
using Covid19v3.SD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Covid19v3.Controllers
{
    public class AccesoController : Controller
    {
        private string srtUser = "CuentaUsuario";
        private Usuario_SD oUsuario_SD = new Usuario_SD();
        private UsuarioResponse oREspuesta = new UsuarioResponse();

        // GET: Acesso

        public ActionResult Close()
        {
            Session[srtUser] = null;
         
            FormsAuthentication.SignOut();

            return RedirectToAction("Login", "Acceso");
        }

        public JsonResult ValidarUsuario(String pLogin, String pContrasenia)
        {
            Usuario pUsuario = new Usuario();
            try
            {
               
                oREspuesta.ObjUsuario = oUsuario_SD.ValidarAcceso(pLogin, pContrasenia);
            }
            catch (Exception ex)
            {
                pUsuario.CodigoError = 5;
                pUsuario.DescripcionError = ex.Message;
                oREspuesta.ObjUsuario = pUsuario;
            }
            if (oREspuesta.ObjUsuario !=null )
                return Json( new { Success = true }, JsonRequestBehavior.AllowGet);
            else
                return Json( new { Success = false }, JsonRequestBehavior.AllowGet);
           //return Json(oREspuesta, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Login(Usuario u)
        {
            if (ModelState.IsValid)
            {
                Usuario pUsuario = new Usuario();

                var login = oUsuario_SD.ValidarAcceso(u.Login, u.Clave);
                if (login != null)
                {
                    if (!login.IdUsuario.Equals("") && !login.IdUsuario.Equals(""))
                    {


                        List<CuentaUsuario> lstUser = new List<CuentaUsuario>{
                       new CuentaUsuario(oUsuario_SD.ObtenerUsuario(u.Login),1)};
                        Session[srtUser] = lstUser;
                        if (Session[srtUser] != null)
                        {
                            FormsAuthentication.SetAuthCookie(u.Login, false);
                            return RedirectToAction("Index", "Home");
                        }
                        if (true)
                        {

                        }

                       


                    }
                }
            }



            ViewBag.Mensaje = "Usuario y/o Contraseña invalido";

            return View();
        }

    }
}