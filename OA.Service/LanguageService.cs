using OA.Data;
using OA.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Service
{
    public class LanguageService : ILanguageService
    {
        private IRepository<Language> languageRepository;

        public LanguageService(IRepository<Language> languageRepository)
        {
            this.languageRepository = languageRepository;
        }

        public void DeleteLanguage(int id)
        {
            languageRepository.Delete(id);
        }

        public Language GetLanguage(int id)
        {
            return languageRepository.Get(id);
        }

        public IEnumerable<Language> GetLanguages()
        {
            return languageRepository.GetAll();
        }

        public void InsertLanguage(Language language)
        {
            languageRepository.Insert(language);
        }

        public void UpdateLanguage(Language language)
        {
            languageRepository.Update(language);
        }
    }
}
