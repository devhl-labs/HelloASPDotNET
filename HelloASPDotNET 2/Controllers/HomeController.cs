using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HelloASPDotNET_2.Models;

namespace HelloASPDotNET_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // GET: /Home/
        [HttpGet]
        public IActionResult Index()
        {
            return View();
            //string html = "<form action='post'>" +
            //                "<input value='Your Name'></input>" +
            //                "<select>" +
            //                    "<option>--Select Language--</option>" +
            //                    "<option value='1'>English</option>" +
            //                "</select>" +
            //                "<input type='submit' value='Submit'>" +
            //              "</form>";

            //return Content(html, "text/html");
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
