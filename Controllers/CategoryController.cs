using Microsoft.AspNetCore.Mvc;

namespace MVCDemoS.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
