using FizzBuzz.Logic;
using FizzBuzz.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FizzBuzz.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        Calculation cal = new Calculation();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GetData(Input input)
        {
            if (ModelState.IsValid)
            {
                
                List<ValuesToPrint> list = cal.GetValueList(input.Value);
                return View(list);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}