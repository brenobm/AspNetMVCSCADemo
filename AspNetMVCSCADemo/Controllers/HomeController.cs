using AspNetMVCSCADemo.Controllers.Base;
using System.Web.Mvc;

namespace AspNetMVCSCADemo.Controllers
{
    public class HomeController : CustomController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Logoff()
        {
            DeslogarUsuario();

            return View("Index");
        }
    }
}