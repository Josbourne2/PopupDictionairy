using PopupDictionairy.App.Model;
using System.Collections.Generic;

namespace PopupDictionairy.App.Controller
{
    public interface ITranslationsPersistenceProvider
    {
        IEnumerable<TranslationQuestion> LoadTranslations();

        void SaveTranslations(IEnumerable<TranslationQuestion> translations);
    }
}