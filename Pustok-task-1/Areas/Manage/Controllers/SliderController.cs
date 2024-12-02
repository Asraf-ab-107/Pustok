using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pustok_task_1.DAL;
using Pustok_task_1.Helpers;
using Pustok_task_1.Models;

namespace Pustok_task_1.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class SliderController : Controller
    {

        private readonly IWebHostEnvironment env;
        AppDbContext Db { get; set; }

        public SliderController(AppDbContext db, IWebHostEnvironment env)
        {
            Db = db;
            this.env = env;
        }

        public async Task<IActionResult> Index()
        {
            List<Slider> sliderList =await Db.sliders.ToListAsync();
            return View(sliderList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Slider slider)
        {
            if (!slider.File.ContentType.Contains("image"))
            {
                ModelState.AddModelError("File", "dogru fayl tipi yukleyin");
                return View();
            }
            if (slider.File.Length > 2097152)
            {
                ModelState.AddModelError("File","fayl 2mb dan cox ola bilmez");
                return View();
            }
            slider.ImgUrl = slider.File.Upload(env.WebRootPath, "Upload/Slider");
            if (!ModelState.IsValid)
            {
                return View();
            }
                
            Db.sliders.Add(slider);
            Db.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            var slider = Db.sliders.FirstOrDefault(s=>s.Id== id);
            if (slider == null)
            {
                return NotFound();
            }

            Db.sliders.Remove(slider);
            Db.SaveChanges();

            return RedirectToAction("Index");
        }
        
    }
}
