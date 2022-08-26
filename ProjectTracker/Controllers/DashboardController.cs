using Microsoft.AspNetCore.Mvc;

namespace ProjectTracker.Mvc.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
