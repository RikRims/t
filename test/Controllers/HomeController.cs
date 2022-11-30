using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using test.Models;
using test.Dal.Interfaces;

namespace test.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOrderRep _orderRep;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IOrderRep orderRep)
        {
            _logger = logger;
            _orderRep = orderRep;
        }

        public async Task<IActionResult> Index()
        {
            var responce = await _orderRep.Select();

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
}