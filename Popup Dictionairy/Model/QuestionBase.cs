using Newtonsoft.Json;
using System;

namespace PopupDictionairy.App.Model
{
    public abstract class QuestionBase : IQuestion, IEquatable<IQuestion>
    {
        public QuestionBase()
        {
            SetStatisticsOnValidation = true;
        }

        private int correctAnswers;
        private DateTime lastCorrectAnswer;

        [JsonIgnore]
        public abstract string Question { get; }

        [JsonIgnore]
        public abstract string Answer { get; }
 
        public int CorrectAnswers
        {
            get { return correctAnswers; }
            set { correctAnswers = value; }
        }

        public DateTime LastCorrectAnswer
        {
            get { return lastCorrectAnswer; }
            set { lastCorrectAnswer = value; }
        }

        public virtual bool Validate(string userAnswer)
        {
            bool result = string.Equals(Answer.Trim(), userAnswer.Trim(), StringComparison.CurrentCultureIgnoreCase);

            if (result && SetStatisticsOnValidation)
            {
                lastCorrectAnswer = DateTime.Now;
                correctAnswers++;
            }

            return result;
        }

        [JsonIgnore]
        public bool SetStatisticsOnValidation { get; set; }

        public bool Equals(IQuestion other)
        {
            return string.Equals(Question, other.Question, StringComparison.CurrentCultureIgnoreCase) &&
                 string.Equals(Answer, other.Answer, StringComparison.CurrentCultureIgnoreCase);
        }
    }
}