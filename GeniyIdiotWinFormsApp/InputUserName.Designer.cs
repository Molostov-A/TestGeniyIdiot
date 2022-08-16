using GeniyIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    partial class InputUserName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputUserName));
            this.startingGreeting_Lable = new System.Windows.Forms.Label();
            this.inputNameUser_Label = new System.Windows.Forms.Label();
            this.inputUserName_TextBox = new System.Windows.Forms.TextBox();
            this.enterUserName_Button = new System.Windows.Forms.Button();
            this.menu_UserControl1 = new GeniyIdiotWinFormsApp.Menu_UserControl();
            this.SuspendLayout();
            // 
            // startingGreeting_Lable
            // 
            this.startingGreeting_Lable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startingGreeting_Lable.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.startingGreeting_Lable.Location = new System.Drawing.Point(32, 25);
            this.startingGreeting_Lable.Name = "startingGreeting_Lable";
            this.startingGreeting_Lable.Size = new System.Drawing.Size(440, 27);
            this.startingGreeting_Lable.TabIndex = 0;
            this.startingGreeting_Lable.Text = "startingGreeting_Lable";
            this.startingGreeting_Lable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // inputNameUser_Label
            // 
            this.inputNameUser_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inputNameUser_Label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inputNameUser_Label.Location = new System.Drawing.Point(32, 58);
            this.inputNameUser_Label.Name = "inputNameUser_Label";
            this.inputNameUser_Label.Size = new System.Drawing.Size(440, 27);
            this.inputNameUser_Label.TabIndex = 1;
            this.inputNameUser_Label.Text = "inputNameUser_Label";
            this.inputNameUser_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // inputUserName_TextBox
            // 
            this.inputUserName_TextBox.Location = new System.Drawing.Point(119, 88);
            this.inputUserName_TextBox.Name = "inputUserName_TextBox";
            this.inputUserName_TextBox.Size = new System.Drawing.Size(249, 23);
            this.inputUserName_TextBox.TabIndex = 2;
            // 
            // enterUserName_Button
            // 
            this.enterUserName_Button.BackColor = System.Drawing.Color.SlateBlue;
            this.enterUserName_Button.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.enterUserName_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enterUserName_Button.Location = new System.Drawing.Point(198, 117);
            this.enterUserName_Button.Name = "enterUserName_Button";
            this.enterUserName_Button.Size = new System.Drawing.Size(96, 34);
            this.enterUserName_Button.TabIndex = 3;
            this.enterUserName_Button.Text = "enterUserName_Button";
            this.enterUserName_Button.UseVisualStyleBackColor = false;
            this.enterUserName_Button.Click += new System.EventHandler(this.enterUserNameButton_Click);
            // 
            // menu_UserControl1
            // 
            this.menu_UserControl1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.menu_UserControl1.BackColor = System.Drawing.Color.Transparent;
            this.menu_UserControl1.Location = new System.Drawing.Point(0, 1);
            this.menu_UserControl1.Name = "menu_UserControl1";
            this.menu_UserControl1.Size = new System.Drawing.Size(92, 28);
            this.menu_UserControl1.TabIndex = 4;
            // 
            // InputUserName
            // 
            this.AcceptButton = this.enterUserName_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 161);
            this.Controls.Add(this.menu_UserControl1);
            this.Controls.Add(this.enterUserName_Button);
            this.Controls.Add(this.inputUserName_TextBox);
            this.Controls.Add(this.inputNameUser_Label);
            this.Controls.Add(this.startingGreeting_Lable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InputUserName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Гений Идиот";
            this.Load += new System.EventHandler(this.InputUserName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label startingGreeting_Lable;
        private System.Windows.Forms.Label inputNameUser_Label;
        public System.Windows.Forms.TextBox inputUserName_TextBox;
        private System.Windows.Forms.Button enterUserName_Button;
        private Menu_UserControl menu_UserControl1;
    }
}