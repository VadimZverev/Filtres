using System;
using System.Web.Mvc;

namespace Filtres.Controllers
{
    public class SelectiveCacheController : Controller
    {
        public ActionResult Index()
        {
            Response.Write("Метод действия звпущен: " + DateTime.Now);
            return View();
        }

        [OutputCache(Duration = 30)]
        public ActionResult ChildAction()
        {
            Response.Write("дочерний метод действия звпущен: " + DateTime.Now);
            return View();
        }
    }
}