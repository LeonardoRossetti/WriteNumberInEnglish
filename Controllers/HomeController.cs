using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestUnleashed.Models;

namespace TestUnleashed.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new ValueConversor());
        }

        public IActionResult ConvertNumberToEnglishWord(ValueConversor valueConversor)
        {
            valueConversor.WordValue = Utils.Converter.WriteExtensive(valueConversor.Value);
            
            return View("Index", valueConversor);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "This is a test application for Unleashed";

            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
