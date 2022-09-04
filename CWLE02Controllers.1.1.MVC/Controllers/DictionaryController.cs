using CWLE02Controllers._1._1.MVC.Services;
using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace CWLE02Controllers._1._1.MVC.Controllers
{
    public class DictionaryController : Controller
    {
        private readonly IWordService _dictionary;
        public DictionaryController(IWordService dictionary)
        {
            _dictionary = dictionary;
        }
        
        public IActionResult AddWord()
        {
            return View();
        }

        public IActionResult AddNewWord(string word, string meaning)
        {
            word = HttpUtility.HtmlEncode(word);
            meaning = HttpUtility.HtmlEncode(meaning);
            _dictionary.AddWord(word, meaning);
            return RedirectToAction("Index");
        }
        public IActionResult Index()
        {
            return View(_dictionary.GetWords());
        }
    }
}
