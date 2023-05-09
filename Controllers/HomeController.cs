using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace assignment_WEB_API.Controllers
{
   public class PortfolioController : Controller
{
    private readonly MyDbContext _context;

    public PortfolioController(MyDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var projects = _context.Projects.ToList();
        return View(projects);
    }
}
}
