using System.Diagnostics;
using CheckBoxesAspdotnet.Models;
using Microsoft.AspNetCore.Mvc;

namespace CheckBoxesAspdotnet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //public IActionResult Index()
        //{
        //    var model = new ViewModel()
        //    {
        //        AcceptTerms = false,
        //        Text = "I Accept The Terms"
        //    };
        //    return View(model);
        //}

        public IActionResult Index()
        {
            var model = new ViewModel()
            {
                CheckBoxes = new List<CheckBoxOption>()
                {
                    new CheckBoxOption() { IsChecked = false, Text = "Option 1", Value = "1" },
                    new CheckBoxOption() { IsChecked = true, Text = "Option 2", Value = "2" },
                    new CheckBoxOption() { IsChecked = false, Text = "Option 3", Value = "3" },
                }

            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(ViewModel data)
        {
            //var value = data.AcceptTerms;
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
