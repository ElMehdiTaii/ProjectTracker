using Microsoft.AspNetCore.Mvc;

namespace ProjectTracker.Mvc.Controllers
{
    public class TicketsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
