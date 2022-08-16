namespace GeniyIdiotWinFormsApp
{
    partial class AdminPanelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanelForm));
            this.managerQuestions = new System.Windows.Forms.Button();
            this.resetTestResult = new System.Windows.Forms.Button();
            this.textNameFormLabel = new System.Windows.Forms.Label();
            this.menu_UserControl1 = new GeniyIdiotWinFormsApp.Menu_UserControl();
            this.SuspendLayout();
            // 
            // managerQuestions
            // 
            this.managerQuestions.BackColor = System.Drawing.Color.SlateBlue;
            this.managerQuestions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.managerQuestions.ForeColor = System.Drawing.Color.Wheat;
            this.managerQuestions.Location = new System.Drawing.Point(17, 70);
            this.managerQuestions.Name = "managerQuestions";
            this.managerQuestions.Size = new System.Drawing.Size(450, 35);
            this.managerQuestions.TabIndex = 1;
            this.managerQuestions.Text = "Редактирование вопросов";
            this.managerQuestions.UseVisualStyleBackColor = false;
            this.managerQuestions.Click += new System.EventHandler(this.managerQuestions_Click);
            // 
            // resetTestResult
            // 
            this.resetTestResult.BackColor = System.Drawing.Color.SlateBlue;
            this.resetTestResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resetTestResult.ForeColor = System.Drawing.Color.Wheat;
            this.resetTestResult.Location = new System.Drawing.Point(17, 111);
            this.resetTestResult.Name = "resetTestResult";
            this.resetTestResult.Size = new System.Drawing.Size(450, 35);
            this.resetTestResult.TabIndex = 1;
            this.resetTestResult.Text = "Очистить таблицу результатов";
            this.resetTestResult.UseVisualStyleBackColor = false;
            this.resetTestResult.Click += new System.EventHandler(this.resetTestResult_Click);
            // 
            // textNameFormLabel
            // 
            this.textNameFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.textNameFormLabel.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.textNameFormLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textNameFormLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.textNameFormLabel.Location = new System.Drawing.Point(18, 34);
            this.textNameFormLabel.Name = "textNameFormLabel";
            this.textNameFormLabel.Size = new System.Drawing.Size(449, 33);
            this.textNameFormLabel.TabIndex = 6;
            this.textNameFormLabel.Text = "Панель администратора";
            this.textNameFormLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menu_UserControl1
            // 
            this.menu_UserControl1.BackColor = System.Drawing.Color.Transparent;
            this.menu_UserControl1.Location = new System.Drawing.Point(6, 2);
            this.menu_UserControl1.Name = "menu_UserControl1";
            this.menu_UserControl1.Size = new System.Drawing.Size(91, 31);
            this.menu_UserControl1.TabIndex = 7;
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(484, 190);
            this.Controls.Add(this.menu_UserControl1);
            this.Controls.Add(this.textNameFormLabel);
            this.Controls.Add(this.resetTestResult);
            this.Controls.Add(this.managerQuestions);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminPanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель администратора";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button managerQuestions;
        private System.Windows.Forms.Button resetTestResult;
        private System.Windows.Forms.Label textNameFormLabel;
        private Menu_UserControl menu_UserControl1;
    }
}