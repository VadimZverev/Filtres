using System.Diagnostics;
using System.Web.Mvc;

namespace Filtres.Infrastructure
{
    public class ProfileResultAttribute : FilterAttribute, IResultFilter
    {
        private Stopwatch timer;

        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            timer.Stop();
            filterContext.HttpContext.Response.Write(
                    string.Format($"<div>Время результата: {timer.Elapsed.TotalSeconds}</div>"));
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            timer = Stopwatch.StartNew();
        }
    }
}