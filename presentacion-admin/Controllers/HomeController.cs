using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dominio;
using Negocio;
namespace presentacion_admin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Usuarios()
        {


            return View();
        }

        public JsonResult ListarUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();

            lista = new CN_USUARIOS().ListarUsuarios();

            return Json(lista,JsonRequestBehavior.AllowGet);
        }
    }
   
}