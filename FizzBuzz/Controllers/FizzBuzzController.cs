using FizzBuzz.Interfaces;
using FizzBuzz.Logic;
using FizzBuzz.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FizzBuzz.Controllers
{
    public class FizzBuzzController : Controller
    {
        ICalculation _calculation;

        public FizzBuzzController(ICalculation calculation)
        {
            _calculation = calculation;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PrintValues(int Value, int pageIndex=1)
        {
            if (ModelState.IsValid)
            {
                ViewData["value"] = Value;
                int pageSize = 20;
                List<ValuesToPrint> list = _calculation.GetValueList(Value);
                return View(PaginatedList<ValuesToPrint>.Create(list,pageIndex,pageSize));
            }
            else
            {
                return RedirectToAction("Index", "FizzBuzz");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}