using Filtres.Infrastructure;
using System.Web.Mvc;

namespace Filtres.Controllers
{
    [SimpleMessage(Message = "A")]
    public class CustomerController : Controller
    {
        public string Index()
        {
            return "Это Customer контроллер";
        }

        [CustomOvverrideActionFilters]
        [SimpleMessage(Message = "B")]
        public string OtherAction()
        {
            return "Это OtherAction в Customer контроллере";
        }
    }
}