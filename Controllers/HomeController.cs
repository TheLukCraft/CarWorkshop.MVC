using CarWorkshop.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CarWorkshop.MVC.Controllers
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
        public IActionResult About()
        {
            var product = new List<Product>()
            {
                new Product()
                {
                    Title = "Diagnostyka",
                    Description = "Sprawdzimy Twój samochód",
                    Tags = new List<string>() {"Diagnostyka", "Samochód", "Naprawa"}
                },
                new Product()
                {
                    Title = "Olej",
                    Description = "Wymiana oleju.",
                    Tags = new List<string>() {"Olej", "Wymiana", "Pomoc"}
                }
            };
            return View(product);
        }

        public IActionResult Privacy()
        {
            var model = new List<Person>()
            {
                new Person()
                {
                    FirstName = "Łukasz",
                    LastName = "Capała"
                },
                new Person() 
                {
                    FirstName = "Andrzej",
                    LastName = "Grabowski"
                },
            };

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}