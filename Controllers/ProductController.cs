using Microsoft.AspNetCore.Mvc;
using WebShopKnjiga.DataAccess.Data;

namespace WebShopKnjiga.Controllers;

public class ProductController : Controller
{
    private readonly ApplicationDbContext _context;

    public ProductController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }
}
