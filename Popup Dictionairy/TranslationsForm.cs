using PopupDictionairy.App.Model;
using PopupDictionairy.App.Controller;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace PopupDictionairy.App
{
    public partial class TranslationsForm : Form
    {
        private BindingList<TranslationQuestion> translationList;
        private TranslationsController controller;

        public TranslationsForm(TranslationsController controller)
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoGenerateColumns = false;
            this.controller = controller;
            translationList = new BindingList<TranslationQuestion>(controller.Translations.ToList());
            this.dataGridView1.DataSource = translationList;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            controller.Translations.Clear();
            controller.Translations.AddRange(translationList);
            controller.Save();
            this.Close();
        }
    }
}