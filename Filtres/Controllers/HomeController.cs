using Filtres.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filtres.Controllers
{
    public class HomeController : Controller
    {
        //[CustomAuth(false)]
        [Authorize(Users = "admin")]
        public string Index()
        {
            return "Это Index действие Home контроллера";
        }
    }
}