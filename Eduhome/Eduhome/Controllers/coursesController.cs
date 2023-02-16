using Microsoft.AspNetCore.Mvc;

namespace EduHome.Controllers
{
    public class coursesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
