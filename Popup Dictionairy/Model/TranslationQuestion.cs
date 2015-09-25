using Newtonsoft.Json;
using System;

namespace PopupDictionairy.App.Model
{
    public class TranslationQuestion : QuestionBase, IEquatable<TranslationQuestion>
    {
        private string fromLanguage;
        private string toLanguage;


        public TranslationQuestion()
        {
            SetStatisticsOnValidation = true;
        }

        public TranslationQuestion(string fromLanguage, string toLanguage)
        {
            this.fromLanguage = fromLanguage;
            this.toLanguage = toLanguage;
        }

        public string FromLanguage
        {
            get { return fromLanguage; }
            set { fromLanguage = value; }
        }

        public string ToLanguage
        {
            get { return toLanguage; }
            set { toLanguage = value; }
        }

        public override string Answer { get { return toLanguage; } }

        public override string Question { get { return fromLanguage; } }


        public bool Equals(TranslationQuestion other)
        {
            return string.Equals(fromLanguage, other.fromLanguage, StringComparison.CurrentCultureIgnoreCase) &&
                string.Equals(toLanguage, other.toLanguage, StringComparison.CurrentCultureIgnoreCase);
        }
    }
}