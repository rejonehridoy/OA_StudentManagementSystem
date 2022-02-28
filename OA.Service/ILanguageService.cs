using OA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service
{
    public interface ILanguageService
    {
        IEnumerable<Language> GetLanguages();
        Language GetLanguage(int id);
        void InsertLanguage(Language language);
        void UpdateLanguage(Language language);
        void DeleteLanguage(int id);
    }
}
