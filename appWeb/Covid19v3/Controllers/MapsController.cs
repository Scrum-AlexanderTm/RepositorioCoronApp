using Covid19v3.Models;
using Covid19v3.SD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Covid19v3.Controllers
{
    public class MapsController : Controller
    {
        private Maps_SD oMaps_SD = new Maps_SD();
        private MapsResponse oREspuesta = new MapsResponse();
        public ActionResult Index()
        {
            
            return View();
        }
        public JsonResult GetAllLocation(Maps pMaps_BE)
        {
            try
            {
                oREspuesta.ObjListaMaps = oMaps_SD.Listar(pMaps_BE);
                return Json(oREspuesta, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                Maps oMaps_BE = new Maps();
                oMaps_BE.CodigoError = ex.GetHashCode();
                oMaps_BE.MensajeError = ex.Message;
                oREspuesta.ObjMaps = oMaps_BE;
                return Json(oREspuesta, JsonRequestBehavior.AllowGet);
            }

           
        }
       
    }
}