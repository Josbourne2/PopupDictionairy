using PopupDictionairy.App.Model;
using System;
using System.Windows.Forms;

namespace PopupDictionairy.App
{
    public partial class QuestionForm : Form
    {
        private IQuestionSession session;
        private IQuestion currentQuestion;

        public QuestionForm(IQuestionSession session)
        {
            InitializeComponent();

            this.session = session;
            this.Shown += QuestionForm_Shown;
        }

        private void QuestionForm_Shown(object sender, EventArgs e)
        {
            GetNextQuestion();
        }

        private void ProcessAndDisplayTranslation()
        {
            if (HasAnswer)
            {
                if (currentQuestion.Validate(Answer))
                {
                    MessageBox.Show("You answered correctly!");
                    GetNextQuestion();
                }
                else
                {
                    MessageBox.Show("You're Stupid!!!", "You answer was not correctly", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    buttonSkip.Visible = true;
                }
            }
        }

        private void GetNextQuestion()
        {
            //Get next translation
            currentQuestion = session.Next();
            txtAnswer.Text = String.Empty;
            if (currentQuestion != null)
            {
                lblQuestion.Text = currentQuestion.Question;
                return;
            }

            this.Close();
        }

        public bool HasAnswer { get { return Answer.Length > 0; } }

        public string Answer { get { return txtAnswer.Text; } set { txtAnswer.Text = value; } }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            this.ProcessAndDisplayTranslation();
        }

        private void buttonSkip_Click(object sender, EventArgs e)
        {
            buttonSkip.Visible = false;
            GetNextQuestion();
        }
    }
}