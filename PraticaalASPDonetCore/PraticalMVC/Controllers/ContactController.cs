using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PraticalMVC.Models;

namespace PraticalMVC.Controllers;

public class ContactController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public ContactController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Contact()
    {
        return View();
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}