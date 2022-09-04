using CWLE02Controllers._1._1.MVC.Models;

namespace CWLE02Controllers._1._1.MVC.Services
{
    public interface IWordService
    {
        void AddWord(string word, string meaning);
        List<MyDictionaryEntry> GetWords();
    }
}
