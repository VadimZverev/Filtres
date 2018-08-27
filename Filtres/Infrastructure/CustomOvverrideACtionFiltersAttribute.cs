using System;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace Filtres.Infrastructure
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]
    public class CustomOvverrideActionFiltersAttribute : FilterAttribute, IOverrideFilter
    {
        public Type FiltersToOverride => typeof(IActionFilter);
    }
}