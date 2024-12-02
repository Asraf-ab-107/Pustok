using Microsoft.EntityFrameworkCore;
using Pustok_task_1.Models;

namespace Pustok_task_1.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Slider> sliders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Catagory> Catagores { get; set; }
        public DbSet<Tag> Tag {  get; set; }
        public DbSet<TagProducts> TagProducts { get; set; }
        public DbSet<ProductImages> ProductImages { get; set; }
        
    }
}
