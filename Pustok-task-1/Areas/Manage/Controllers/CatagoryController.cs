using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pustok_task_1.DAL;
using Pustok_task_1.Models;

namespace Pustok_task_1.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class CatagoryController : Controller
    {
        AppDbContext Context { get; set; }

        public CatagoryController(AppDbContext context)
        {
            Context = context;
        }

        public async Task<IActionResult> Index()
        {
            var catagories = await Context.Catagores.Include(c=>c.Products).ToListAsync();
            return View(catagories);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Catagory catagory)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            Context.Catagores.Add(catagory);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)return NotFound();
            var catagories = Context.Catagores.FirstOrDefault(c => c.Id == id);
            if(catagories == null) return NotFound();
            Context.Catagores.Remove(catagories);
            Context.SaveChanges();
            return RedirectToAction("Index");
            
        }
        public IActionResult Update(int? id)
        {
            if(id== null)return BadRequest();
            var catagory = Context.Catagores.FirstOrDefault(c =>c.Id == id);
            if (catagory == null) return NotFound(); 
            return View(catagory);

        }
        [HttpPost]
        public IActionResult Update(Catagory newcatagory)
        {
            if (!ModelState.IsValid)
            {
                return View(newcatagory);
            }
            var oldcatagory = Context.Catagores.FirstOrDefault(c => c.Id == newcatagory.Id);
            if (oldcatagory == null) return NotFound();

            oldcatagory.Name = newcatagory.Name;
            Context.SaveChanges();
            return RedirectToAction("Index");  

        }
    }
}
