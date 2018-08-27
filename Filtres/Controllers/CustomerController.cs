using Filtres.Infrastructure;
using System.Web.Mvc;

namespace Filtres.Controllers
{
    public class CustomerController : Controller
    {
        [SimpleMessage(Message = "A", Order = 2)]
        [SimpleMessage(Message = "B", Order = 1)]
        public string Index()
        {
            return "Это Customer контроллер";
        }
    }
}