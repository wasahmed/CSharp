using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using myfirstmvcapp.Models;
using System.Text.Encodings.Web;

namespace myfirstmvcapp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //Uses the C# optional-parameter feature to indicate that the department parameter defaults to
        // "Unknown" if no value is passed for that parameter.
        //Uses HtmlEncoder.Default.Encode to protect the app from malicious input (namely JavaScript).
        //Uses Interpolated Strings.
        public string SayHi(string name, string department = "Unknown")
        {
            return HtmlEncoder.Default.Encode($"Hello {name} from {department}");
        }

        // public string SayHiAgain(string name, int ID = 1)
        // {
        //     return HtmlEncoder.Default.Encode($"{ID}. Hello {name}");
        // }
        public IActionResult SayHiAgain(string name, int ID = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["ID"] = ID;

            return View();
        }

        public IActionResult Index()
        {
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
