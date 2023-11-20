using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoriesPG.DAL;
using StoriesPG.ViewModels;

namespace StoriesPG.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM()
            {
                meals = _context.meals.ToList(),
                recentWorks = _context.recentWorks.ToList(),
                blogs = _context.blogs.ToList(),
            };
            return View(homeVM);
        }
    }
}
