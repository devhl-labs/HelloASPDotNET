using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloASPDotNET_2.Controllers
{
    public class HelloController : Controller
    {
        public static string CreateMessage(string language, string name)
        {
            string result = $"Hello {name}.";

            if (language == "es")
                result = $"Holla {name}.";

            if (language == "fr")
                result = $"Bonjour {name}.";

            if (language == "ar")
                result = $".{name} مرحبا";

            if (language == "ja")
                result = $"こんにちは {name}.";

            return result;
        }

        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form action='hello/welcome' method='post'>" +
                            "<input required name='name' value='Your Name'></input>" +
                            "<select required name='language'>" +
                                "<option>--Select Language--</option>" +
                                "<option value='en'>English</option>" +
                                "<option value='es'>Spanish</option>" +
                                "<option value='fr'>French</option>" +
                                "<option value='ar'>Arabic</option>" +
                                "<option value='ja'>Japanese</option>" +
                            "</select>" +
                            "<input type='submit' value='Submit'>" +
                          "</form>";

            return Content(html, "text/html");
        }

        //[HttpPost]
        //[HttpGet]
        [Route("hello/welcome/{name?}")]
        public IActionResult Welcome(string language = "en", string name = ", World")
        {
            return Content(CreateMessage(language, name), "text/html");
        }
    }
}
