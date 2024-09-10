using System.Web.Mvc;
using System.Web;
using CapaNegocios;
using CapaEntidad;
using System.Collections.Generic;

namespace Capas_MVC_maryori.Controllers
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
            List<Usuario> oLista = new List<Usuario>();

            oLista = new CN_Usuarios().Listar();

            return Json(oLista,JsonRequestBehavior.AllowGet);
        }
    }
}