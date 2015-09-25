namespace PopupDictionairy.App
{
    partial class TranslationsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.columnFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnToLanguage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCorrectAnswers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnLastCorrectAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnFrom,
            this.columnToLanguage,
            this.columnCorrectAnswers,
            this.columnLastCorrectAnswer});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(637, 241);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(476, 268);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(574, 268);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // columnFrom
            // 
            this.columnFrom.DataPropertyName = "FromLanguage";
            this.columnFrom.HeaderText = "From Language";
            this.columnFrom.Name = "columnFrom";
            // 
            // columnToLanguage
            // 
            this.columnToLanguage.DataPropertyName = "ToLanguage";
            this.columnToLanguage.HeaderText = "To Language";
            this.columnToLanguage.Name = "columnToLanguage";
            // 
            // columnCorrectAnswers
            // 
            this.columnCorrectAnswers.DataPropertyName = "CorrectAnswers";
            this.columnCorrectAnswers.HeaderText = "Correct Answers";
            this.columnCorrectAnswers.Name = "columnCorrectAnswers";
            this.columnCorrectAnswers.ReadOnly = true;
            // 
            // columnLastCorrectAnswer
            // 
            this.columnLastCorrectAnswer.DataPropertyName = "LastCorrectAnswer";
            this.columnLastCorrectAnswer.HeaderText = "Last Correct Answered";
            this.columnLastCorrectAnswer.Name = "columnLastCorrectAnswer";
            this.columnLastCorrectAnswer.ReadOnly = true;
            // 
            // TranslationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 303);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TranslationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dictionairy";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnToLanguage;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCorrectAnswers;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnLastCorrectAnswer;

    }
}