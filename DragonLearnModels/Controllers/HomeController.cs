using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DragonLearnModels.Models;

namespace DragonLearnModels.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult FizzBuzz()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FizzBuzz(int fizz, int buzz)
        {
            // fbm -> fizz buzz model
            var fbm = new FizzBuzzModel
            {
                Fizz = fizz,
                Buzz = buzz,
                Output = $"Fizz: {fizz}, Buzz: {buzz}"
            };
            return RedirectToAction("Result", fbm);
        }

        // Accept Model/ViewModel
        public IActionResult Result(FizzBuzzModel model)
        {
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
