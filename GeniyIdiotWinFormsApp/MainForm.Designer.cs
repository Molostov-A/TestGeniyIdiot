using GeniyIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.enterQuestionButton = new System.Windows.Forms.Button();
            this.questionNumberLabel = new System.Windows.Forms.Label();
            this.questionTextLabel = new System.Windows.Forms.Label();
            this.AnswerTextBox = new System.Windows.Forms.TextBox();
            this.timer_limitTimeAnswer = new System.Windows.Forms.Timer(this.components);
            this.timer_label = new System.Windows.Forms.Label();
            this.menu_UserControl1 = new GeniyIdiotWinFormsApp.Menu_UserControl(this)
            {
                Name = "menu_MainForm"
            };
            this.SuspendLayout();
            // 
            // enterQuestionButton
            // 
            this.enterQuestionButton.BackColor = System.Drawing.Color.SlateBlue;
            this.enterQuestionButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.enterQuestionButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.enterQuestionButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enterQuestionButton.ForeColor = System.Drawing.Color.Wheat;
            this.enterQuestionButton.Location = new System.Drawing.Point(149, 179);
            this.enterQuestionButton.Name = "enterQuestionButton";
            this.enterQuestionButton.Size = new System.Drawing.Size(187, 40);
            this.enterQuestionButton.TabIndex = 0;
            this.enterQuestionButton.Text = "Далее";
            this.enterQuestionButton.UseVisualStyleBackColor = false;
            this.enterQuestionButton.Click += new System.EventHandler(this.enterQuestionButton_Click);
            // 
            // questionNumberLabel
            // 
            this.questionNumberLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.questionNumberLabel.Location = new System.Drawing.Point(19, 64);
            this.questionNumberLabel.Name = "questionNumberLabel";
            this.questionNumberLabel.Size = new System.Drawing.Size(453, 23);
            this.questionNumberLabel.TabIndex = 1;
            this.questionNumberLabel.Text = "Вопрос №1";
            this.questionNumberLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // questionTextLabel
            // 
            this.questionTextLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.questionTextLabel.Location = new System.Drawing.Point(25, 98);
            this.questionTextLabel.MaximumSize = new System.Drawing.Size(440, 100);
            this.questionTextLabel.Name = "questionTextLabel";
            this.questionTextLabel.Size = new System.Drawing.Size(440, 49);
            this.questionTextLabel.TabIndex = 2;
            this.questionTextLabel.Text = "Текст вопроса";
            this.questionTextLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AnswerTextBox
            // 
            this.AnswerTextBox.Location = new System.Drawing.Point(147, 150);
            this.AnswerTextBox.Name = "AnswerTextBox";
            this.AnswerTextBox.Size = new System.Drawing.Size(189, 23);
            this.AnswerTextBox.TabIndex = 3;
            // 
            // timer_limitTimeAnswer
            // 
            this.timer_limitTimeAnswer.Tick += new System.EventHandler(this.timer_limitTimeAnswer_Tick);
            // 
            // timer_label
            // 
            this.timer_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timer_label.ForeColor = System.Drawing.Color.Tan;
            this.timer_label.Location = new System.Drawing.Point(19, 35);
            this.timer_label.Name = "timer_label";
            this.timer_label.Size = new System.Drawing.Size(446, 21);
            this.timer_label.TabIndex = 6;
            this.timer_label.Text = "timer_label";
            this.timer_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menu_UserControl1
            // 
            this.menu_UserControl1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.menu_UserControl1.BackColor = System.Drawing.Color.Transparent;
            this.menu_UserControl1.Location = new System.Drawing.Point(4, 5);
            this.menu_UserControl1.Name = "menu_UserControl1";
            this.menu_UserControl1.Size = new System.Drawing.Size(153, 27);
            this.menu_UserControl1.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AcceptButton = this.enterQuestionButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 231);
            this.Controls.Add(this.menu_UserControl1);
            this.Controls.Add(this.timer_label);
            this.Controls.Add(this.AnswerTextBox);
            this.Controls.Add(this.questionTextLabel);
            this.Controls.Add(this.questionNumberLabel);
            this.Controls.Add(this.enterQuestionButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Гений Идиот";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enterQuestionButton;
        private System.Windows.Forms.Label questionNumberLabel;
        private System.Windows.Forms.Label questionTextLabel;
        public System.Windows.Forms.TextBox AnswerTextBox;
        public System.Windows.Forms.Timer timer_limitTimeAnswer;
        private System.Windows.Forms.Label timer_label;
        private Menu_UserControl menu_UserControl1;
    }
}
