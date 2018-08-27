﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filtres.Infrastructure
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = true)]
    public class SimpleMessageAttribute : FilterAttribute, IActionFilter
    {
        public string Message { get; set; }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            filterContext.HttpContext.Response.Write(
                string.Format($"<div>[После действия: {Message}]<div>"));
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.HttpContext.Response.Write(
                string.Format($"<div>[Перед действием: {Message}]<div>"));
        }
    }
}