using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjectTracker.Mvc.Controllers
{
    public class ProjectsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
