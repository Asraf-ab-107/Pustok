using Microsoft.EntityFrameworkCore;
using Pustok_task_1.DAL;

namespace Pustok_task_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseSqlServer(builder.Configuration.GetConnectionString("MsqSql"));
            });
            var app = builder.Build();

            app.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=DashBoard}/{action=Index}/{id?}"
                );

            app.MapControllerRoute(
                name:"default",
                pattern:"{controller=home}/{action=index}/{id?}"
                );
            app.UseStaticFiles();
            app.Run();
        }
    }
}
