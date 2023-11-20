using Microsoft.EntityFrameworkCore;
using StoriesPG.DAL;

namespace StoriesPG
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer("server=DESKTOP-4R5RDF2;database=StoriesDB;Trusted_connection=true;Integrated security=true;Encrypt=false"));
            var app = builder.Build();
            app.UseStaticFiles();
            app.UseRouting();
            app.MapControllerRoute(
                name: "Home",
                pattern: "{controller=Home}/{action=Index}/{id?}"
                );
            app.Run();
        }
    }
}
