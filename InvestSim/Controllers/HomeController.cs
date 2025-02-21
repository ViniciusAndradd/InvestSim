using InvestSim.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using InvestSim.Models;

namespace InvestSim.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new Investment());
        }

        [HttpPost]
        public IActionResult Index(Investment investment)
        {
            if (ModelState.IsValid)
            {
                investment.SimulateInvestment();
            }
            return View(investment);
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
