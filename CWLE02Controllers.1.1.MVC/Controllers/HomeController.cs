using CWLE02Controllers._1._1.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Web;


namespace CWLE02Controllers._1._1.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult MyJson()
        {
            var obj = new MyDictionaryEntry() { Word = "Add", Meaning = "join (something) to something else so as to increase the size" };
            return Json(obj);  
        }

        public IActionResult MyPdf()
        {
            return File("Lab 10.pdf", "application/pdf");
        }

        public IActionResult BarGraph(string? values)
        {
            values = HttpUtility.HtmlEncode(values);
            var model = values.Split("/");
            return View(model); 
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