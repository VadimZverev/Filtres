﻿using System;
using System.Web.Mvc;

namespace Filtres.Infrastructure
{
    public class CustomActionAttribute : FilterAttribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (filterContext.HttpContext.Request.IsLocal)
            {
                filterContext.Result = new HttpNotFoundResult();
            }
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            // Пока ещё не реализован
        }
    }
}