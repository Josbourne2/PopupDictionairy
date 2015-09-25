using PopupDictionairy.App.Model;
using System;
using System.Collections.Generic;

namespace PopupDictionairy.App.Controller
{
    public interface ITranslationQuestionSelector
    {
        IEnumerable<TranslationQuestion> GetBatch(int take, IEnumerable<TranslationQuestion> source);
    }
}
