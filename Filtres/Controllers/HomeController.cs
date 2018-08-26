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

        [GoogleAuth]
        [Authorize(Users = "bob@google.com")]
        public string List()
        {
            return "Это List действие Home контроллера";
        }

        [HandleError(ExceptionType = typeof(ArgumentOutOfRangeException), View = "RangeError")]
        public string RangeTest(int id)
        {
            if (id > 100)
            {
                return string.Format($"The id value is: {id}");
            }
            else
            {

                throw new ArgumentOutOfRangeException("id", id, "");
            }
        }
    }
}