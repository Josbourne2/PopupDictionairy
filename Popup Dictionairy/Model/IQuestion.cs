using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopupDictionairy.App.Model
{
    public interface IQuestion
    {
        /// <summary>
        /// The question to ask.
        /// </summary>
        string Question { get; }

        /// <summary>
        /// The correct answer to the question.
        /// </summary>
        string Answer { get; }

        /// <summary>
        /// Last time the question was answered correctly.
        /// </summary>
        DateTime LastCorrectAnswer { get; set; }

        /// <summary>
        /// Total amount of correct answers given.
        /// </summary>
        int CorrectAnswers { get; set; }

        /// <summary>
        /// Validates if the given answer is correct.
        /// </summary>
        /// <param name="userAnswer">The answer provided by the user.</param>
        /// <returns></returns>
        bool Validate(string userAnswer);
    }
}
