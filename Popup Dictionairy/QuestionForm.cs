﻿using PopupDictionairy.App.Model;
using System;
using System.Windows.Forms;

namespace PopupDictionairy.App
{
    public partial class QuestionForm : Form
    {
        private IQuestionSession session;
        private Translation current;

        public QuestionForm(IQuestionSession session)
        {
            InitializeComponent();

            this.session = session;
            this.ProcessAndDisplayTranslation();
        }

        private void ProcessAndDisplayTranslation()
        {
            //Process given translation
            string givenAnswer = txtAnswer.Text;

            if (!String.IsNullOrEmpty(givenAnswer))
            {
                if (current.ToLanguage == givenAnswer)
                {
                    current.CorrectAnswers += 1;
                    current.LastCorrectAnswer = DateTime.Now;
                    MessageBox.Show("You answered correctly!");
                }
                else
                {
                    MessageBox.Show("You're Stupid!!!", "You answer was not correctly", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            //Get next translation
            current = session.Next();
            txtAnswer.Text = String.Empty;
            if (current != null)
            {
                lblQuestion.Text = current.FromLanguage;
                return;
            }

            this.Close();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            this.ProcessAndDisplayTranslation();
        }
    }
}