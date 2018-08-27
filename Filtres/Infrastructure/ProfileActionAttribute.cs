using System.Diagnostics;
using System.Web.Mvc;

namespace Filtres.Infrastructure
{
    public class ProfileActionAttribute : FilterAttribute, IActionFilter
    {
        private Stopwatch timer;
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            timer.Stop();

            if (filterContext.Exception == null)
            {
                filterContext.HttpContext.Response.Write(
                    string.Format($"<div>Время действия: {timer.Elapsed.TotalSeconds}</div>"));
            }

        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            timer = Stopwatch.StartNew();
        }
    }
}