using Filtres.Infrastructure;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filtres.Controllers
{
    public class HomeController : Controller
    {
        private Stopwatch timer;

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

        public string FilterTest()
        {
            return "Это FilterTest действие";
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            timer = Stopwatch.StartNew();
        }

        protected override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            timer.Stop();
            filterContext.HttpContext.Response.Write(
                    string.Format($"<div>Общее время: {timer.Elapsed.TotalSeconds}</div>"));
        }
    }
}