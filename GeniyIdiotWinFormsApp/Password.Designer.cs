namespace GeniyIdiotWinFormsApp
{
    partial class Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Password));
            this.label1 = new System.Windows.Forms.Label();
            this.remember_checkBox = new System.Windows.Forms.CheckBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.enterPassword_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(63, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пожалуйста, введите пароль";
            // 
            // remember_checkBox
            // 
            this.remember_checkBox.AutoSize = true;
            this.remember_checkBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.remember_checkBox.Location = new System.Drawing.Point(114, 87);
            this.remember_checkBox.Name = "remember_checkBox";
            this.remember_checkBox.Size = new System.Drawing.Size(154, 25);
            this.remember_checkBox.TabIndex = 1;
            this.remember_checkBox.Text = "Запомнить меня";
            this.remember_checkBox.UseVisualStyleBackColor = true;
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(51, 58);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(275, 23);
            this.password_textBox.TabIndex = 2;
            // 
            // enterPassword_button
            // 
            this.enterPassword_button.BackColor = System.Drawing.Color.SlateBlue;
            this.enterPassword_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enterPassword_button.ForeColor = System.Drawing.Color.Wheat;
            this.enterPassword_button.Location = new System.Drawing.Point(147, 118);
            this.enterPassword_button.Name = "enterPassword_button";
            this.enterPassword_button.Size = new System.Drawing.Size(75, 33);
            this.enterPassword_button.TabIndex = 3;
            this.enterPassword_button.Text = "Ок";
            this.enterPassword_button.UseVisualStyleBackColor = false;
            this.enterPassword_button.Click += new System.EventHandler(this.enterPassword_button_Click);
            // 
            // Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(395, 163);
            this.Controls.Add(this.enterPassword_button);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.remember_checkBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox remember_checkBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Button enterPassword_button;
    }
}