
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using LojaDeRoupas.Models;
using LojaDeRoupas.Models.ViewModels;


namespace LojaDeRoupas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["message"] = "Sua aplicação description page";
            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["message"] = "Sua aplicação description page"
;            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
