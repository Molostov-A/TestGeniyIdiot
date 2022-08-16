using GeniyIdiot.Common;
using System;

namespace GeniyIdiotWinFormsApp
{
    partial class QuestionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionsForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numberQuestions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextQuestions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addNewQuestion_Button = new System.Windows.Forms.Button();
            this.resetQuestions_Button = new System.Windows.Forms.Button();
            this.deleteQuestion_Button = new System.Windows.Forms.Button();
            this.menu_UserControl1 = new GeniyIdiotWinFormsApp.Menu_UserControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.OldLace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberQuestions,
            this.TextQuestions,
            this.Answer});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(0, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(751, 203);
            this.dataGridView1.TabIndex = 0;
            // 
            // numberQuestions
            // 
            this.numberQuestions.HeaderText = "№";
            this.numberQuestions.Name = "numberQuestions";
            this.numberQuestions.Width = 50;
            // 
            // TextQuestions
            // 
            this.TextQuestions.HeaderText = "Вопрос";
            this.TextQuestions.Name = "TextQuestions";
            this.TextQuestions.Width = 550;
            // 
            // Answer
            // 
            this.Answer.HeaderText = "Ответ";
            this.Answer.Name = "Answer";
            // 
            // addNewQuestion_Button
            // 
            this.addNewQuestion_Button.BackColor = System.Drawing.Color.SlateBlue;
            this.addNewQuestion_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addNewQuestion_Button.ForeColor = System.Drawing.Color.Wheat;
            this.addNewQuestion_Button.Location = new System.Drawing.Point(12, 249);
            this.addNewQuestion_Button.Name = "addNewQuestion_Button";
            this.addNewQuestion_Button.Size = new System.Drawing.Size(338, 30);
            this.addNewQuestion_Button.TabIndex = 1;
            this.addNewQuestion_Button.Text = "Добавить вопрос";
            this.addNewQuestion_Button.UseVisualStyleBackColor = false;
            this.addNewQuestion_Button.Click += new System.EventHandler(this.addNewQuestion_Button_Click);
            // 
            // resetQuestions_Button
            // 
            this.resetQuestions_Button.BackColor = System.Drawing.Color.SlateBlue;
            this.resetQuestions_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resetQuestions_Button.ForeColor = System.Drawing.Color.Wheat;
            this.resetQuestions_Button.Location = new System.Drawing.Point(366, 249);
            this.resetQuestions_Button.Name = "resetQuestions_Button";
            this.resetQuestions_Button.Size = new System.Drawing.Size(338, 30);
            this.resetQuestions_Button.TabIndex = 1;
            this.resetQuestions_Button.Text = "Сбросить вопросы до базовых";
            this.resetQuestions_Button.UseVisualStyleBackColor = false;
            this.resetQuestions_Button.Click += new System.EventHandler(this.resetQuestions_Button_Click);
            // 
            // deleteQuestion_Button
            // 
            this.deleteQuestion_Button.BackColor = System.Drawing.Color.SlateBlue;
            this.deleteQuestion_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteQuestion_Button.ForeColor = System.Drawing.Color.Wheat;
            this.deleteQuestion_Button.Location = new System.Drawing.Point(12, 292);
            this.deleteQuestion_Button.Name = "deleteQuestion_Button";
            this.deleteQuestion_Button.Size = new System.Drawing.Size(338, 30);
            this.deleteQuestion_Button.TabIndex = 1;
            this.deleteQuestion_Button.Text = "Удалить выделенные вопросы";
            this.deleteQuestion_Button.UseVisualStyleBackColor = false;
            this.deleteQuestion_Button.Click += new System.EventHandler(this.deleteQuestion_Click);
            // 
            // menu_UserControl1
            // 
            this.menu_UserControl1.BackColor = System.Drawing.Color.Transparent;
            this.menu_UserControl1.Location = new System.Drawing.Point(0, 0);
            this.menu_UserControl1.Name = "menu_UserControl1";
            this.menu_UserControl1.Size = new System.Drawing.Size(111, 31);
            this.menu_UserControl1.TabIndex = 2;
            // 
            // QuestionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(734, 345);
            this.Controls.Add(this.menu_UserControl1);
            this.Controls.Add(this.resetQuestions_Button);
            this.Controls.Add(this.deleteQuestion_Button);
            this.Controls.Add(this.addNewQuestion_Button);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuestionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование вопросов";
            this.Load += new System.EventHandler(this.Questions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addNewQuestion_Button;
        private System.Windows.Forms.Button resetQuestions_Button;
        private System.Windows.Forms.Button deleteQuestion_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberQuestions;
        private System.Windows.Forms.DataGridViewTextBoxColumn TextQuestions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer;
        private Menu_UserControl menu_UserControl1;
    }
}