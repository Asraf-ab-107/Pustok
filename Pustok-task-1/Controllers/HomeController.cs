using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pustok_task_1.DAL;
using Pustok_task_1.Models;
using Pustok_task_1.Views.myViewModels;

namespace Pustok_task_1.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext Db;
        public HomeController(AppDbContext db)
        {
            Db = db;
        }
        public IActionResult Index()
        {
            List<Slider> sliderList = Db.sliders.ToList();
            List<Product> productsList = Db.Products.ToList();
            List<ProductImages> productImages = Db.ProductImages.ToList();

            HomeVm vm = new HomeVm()
            {
                sliders=sliderList,
                Products=productsList,
                ProductImages = productImages
            };
            return View(vm);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product=await Db.Products.Include(p=>p.Catagory).
                Include(p=>p.ProductImages).
                Include(p => p.TagProducts).
                ThenInclude(tp=>tp.Tag).
                FirstOrDefaultAsync(p=>p .Id == id);

            return View(product);
        }
    }
}
