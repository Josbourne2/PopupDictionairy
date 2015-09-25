using System.Collections.Generic;
using System.Linq;

namespace PopupDictionairy.App.Model
{
    public class QuestionSession : IQuestionSession
    {
        private IQuestion[] questions;

        private int size;
        private int currentQuestionIndex;

        public QuestionSession(IEnumerable<IQuestion> questions)
        {
            this.questions = questions.ToArray();
            size = questions.Count();
            currentQuestionIndex = 0;
        }

        public IQuestion Next()
        {
            if (currentQuestionIndex > questions.Count() - 1)
                return null;

            var translation = questions[currentQuestionIndex];
            currentQuestionIndex++;
            return translation;
        }
    }
}