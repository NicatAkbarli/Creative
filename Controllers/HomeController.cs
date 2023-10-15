using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebUI.Data;
using WebUI.Models;
using WebUI.WiewModels;

namespace WebUI.Controllers;

public class HomeController : Controller
{
     private readonly ILogger<HomeController> _logger;
    private readonly  AppDbContext _context ;
    public HomeController(AppDbContext context)
    {
       _context = context;
    }
    public IActionResult Index()
    {
         var banner = _context.Banners.FirstOrDefault();
        var services = _context.Services.Take(3).ToList();
        var portfolio = _context.Banners.FirstOrDefault();
        

        HomeVM homeVM1 = new()
        {
            Banner = banner,
            Portfolio= portfolio,

            Services = services,
        };
       
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
