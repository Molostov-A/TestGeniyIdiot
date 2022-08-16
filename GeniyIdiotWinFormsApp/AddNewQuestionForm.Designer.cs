namespace GeniyIdiotWinFormsApp
{
    partial class AddNewQuestionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewQuestionForm));
            this.textAppealLabel = new System.Windows.Forms.Label();
            this.textEnterAnswerLabel = new System.Windows.Forms.Label();
            this.inputTextQuestion = new System.Windows.Forms.TextBox();
            this.inputeAnswerQuestion = new System.Windows.Forms.TextBox();
            this.enterQuestion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textAppealLabel
            // 
            this.textAppealLabel.AutoSize = true;
            this.textAppealLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textAppealLabel.Location = new System.Drawing.Point(12, 9);
            this.textAppealLabel.Name = "textAppealLabel";
            this.textAppealLabel.Size = new System.Drawing.Size(546, 21);
            this.textAppealLabel.TabIndex = 0;
            this.textAppealLabel.Text = "Пожалуйста, напишите текст вопроса, который вы хотите добавить";
            this.textAppealLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textEnterAnswerLabel
            // 
            this.textEnterAnswerLabel.AutoSize = true;
            this.textEnterAnswerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textEnterAnswerLabel.Location = new System.Drawing.Point(91, 75);
            this.textEnterAnswerLabel.Name = "textEnterAnswerLabel";
            this.textEnterAnswerLabel.Size = new System.Drawing.Size(359, 21);
            this.textEnterAnswerLabel.TabIndex = 0;
            this.textEnterAnswerLabel.Text = "Введите ответ на вопрос (в цифровом виде)";
            this.textEnterAnswerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // inputTextQuestion
            // 
            this.inputTextQuestion.Location = new System.Drawing.Point(14, 38);
            this.inputTextQuestion.Name = "inputTextQuestion";
            this.inputTextQuestion.Size = new System.Drawing.Size(543, 23);
            this.inputTextQuestion.TabIndex = 1;
            // 
            // inputeAnswerQuestion
            // 
            this.inputeAnswerQuestion.Location = new System.Drawing.Point(190, 111);
            this.inputeAnswerQuestion.Name = "inputeAnswerQuestion";
            this.inputeAnswerQuestion.Size = new System.Drawing.Size(168, 23);
            this.inputeAnswerQuestion.TabIndex = 2;
            // 
            // enterQuestion
            // 
            this.enterQuestion.BackColor = System.Drawing.Color.SlateBlue;
            this.enterQuestion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enterQuestion.ForeColor = System.Drawing.Color.Wheat;
            this.enterQuestion.Location = new System.Drawing.Point(232, 149);
            this.enterQuestion.Name = "enterQuestion";
            this.enterQuestion.Size = new System.Drawing.Size(90, 39);
            this.enterQuestion.TabIndex = 3;
            this.enterQuestion.Text = "ОК";
            this.enterQuestion.UseVisualStyleBackColor = false;
            this.enterQuestion.Click += new System.EventHandler(this.enterQuestion_Click);
            // 
            // AddNewQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(576, 209);
            this.Controls.Add(this.enterQuestion);
            this.Controls.Add(this.inputeAnswerQuestion);
            this.Controls.Add(this.inputTextQuestion);
            this.Controls.Add(this.textEnterAnswerLabel);
            this.Controls.Add(this.textAppealLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddNewQuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление нового вопроса";
            this.Load += new System.EventHandler(this.AddNewQuestionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textAppealLabel;
        private System.Windows.Forms.Label textEnterAnswerLabel;
        public System.Windows.Forms.TextBox inputTextQuestion;
        public System.Windows.Forms.TextBox inputeAnswerQuestion;
        private System.Windows.Forms.Button enterQuestion;
    }
}