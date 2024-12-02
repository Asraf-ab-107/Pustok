using Microsoft.AspNetCore.Mvc;

namespace Pustok_task_1.Areas.Manage.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
