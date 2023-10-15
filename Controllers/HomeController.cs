using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebUI.Data;
using WebUI.Models;
using WebUI.ViewModels;

namespace WebUI.Controllers;

public class HomeController : Controller
{
     private readonly ILogger<HomeController> _logger;
    private readonly  AppDbContext _context ;
    public HomeController(AppDbContext context, ILogger<HomeController> logger = null)
    {
        _context = context;
        _logger = logger;
    }
    public IActionResult Index()
    {
         var banner = _context.Banners.FirstOrDefault();
        var services = _context.Services.Take(3).ToList();
        var portfolio = _context.Portfolios.ToList();
        

        HomeVM homeVM = new()
        {
            Banner = banner,
            Portfolio= portfolio,
            Service = services
        };
       
        return View(homeVM);
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
