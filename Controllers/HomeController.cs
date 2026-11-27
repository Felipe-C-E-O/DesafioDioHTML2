using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SistemaDeClinica.Models;

namespace SistemaDeClinica.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult SobreAClinica()
    {
        return View();
    }

    public IActionResult Horarios()
    {
        return View();
    }
    public IActionResult Contato()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
