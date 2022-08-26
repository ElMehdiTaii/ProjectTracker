using Microsoft.AspNetCore.Mvc;

namespace ProjectTracker.Mvc.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
