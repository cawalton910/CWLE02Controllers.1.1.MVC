using CWLE02Controllers._1._1.MVC.Controllers;
using CWLE02Controllers._1._1.MVC.Models;

namespace CWLE02Controllers._1._1.MVC.Services
{
    public class WordService : IWordService
    {
        private static List<MyDictionaryEntry> _words = new List<MyDictionaryEntry>();
      

        public void AddWord(string word, string meaning)
        {
            MyDictionaryEntry entry = new MyDictionaryEntry() { Meaning = meaning, Word = word };
            _words.Add(entry);
        }

        public List<MyDictionaryEntry> GetWords()
        {
            return _words;  
        }
    }
}
