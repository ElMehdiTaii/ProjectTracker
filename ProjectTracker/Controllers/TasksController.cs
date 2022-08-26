using Microsoft.AspNetCore.Mvc;

namespace ProjectTracker.Mvc.Controllers
{
    public class TasksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
