using GeniyIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    partial class OutputDiagnosis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutputDiagnosis));
            this.textAppeal1_Label = new System.Windows.Forms.Label();
            this.outputDiagnose = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.restart_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableResults_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.admin_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textAppeal1_Label
            // 
            this.textAppeal1_Label.BackColor = System.Drawing.Color.Transparent;
            this.textAppeal1_Label.Font = new System.Drawing.Font("Segoe UI Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textAppeal1_Label.ForeColor = System.Drawing.Color.Wheat;
            this.textAppeal1_Label.Location = new System.Drawing.Point(143, 63);
            this.textAppeal1_Label.Name = "textAppeal1_Label";
            this.textAppeal1_Label.Size = new System.Drawing.Size(389, 44);
            this.textAppeal1_Label.TabIndex = 0;
            this.textAppeal1_Label.Text = "textAppeal1_Label";
            this.textAppeal1_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // outputDiagnose
            // 
            this.outputDiagnose.BackColor = System.Drawing.Color.Transparent;
            this.outputDiagnose.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.outputDiagnose.ForeColor = System.Drawing.Color.Wheat;
            this.outputDiagnose.Location = new System.Drawing.Point(143, 297);
            this.outputDiagnose.Name = "outputDiagnose";
            this.outputDiagnose.Size = new System.Drawing.Size(389, 44);
            this.outputDiagnose.TabIndex = 0;
            this.outputDiagnose.Text = "outputDiagnose";
            this.outputDiagnose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.ForeColor = System.Drawing.Color.Wheat;
            this.nameLabel.Location = new System.Drawing.Point(143, 19);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(389, 44);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "nameLabel";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // restart_ToolStripMenuItem
            // 
            this.restart_ToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.restart_ToolStripMenuItem.ForeColor = System.Drawing.Color.Goldenrod;
            this.restart_ToolStripMenuItem.Name = "restart_ToolStripMenuItem";
            this.restart_ToolStripMenuItem.Size = new System.Drawing.Size(325, 26);
            this.restart_ToolStripMenuItem.Text = "Перезапуск тестирования";
            this.restart_ToolStripMenuItem.Click += new System.EventHandler(this.restart_ToolStripMenuItem_Click);
            // 
            // tableResults_ToolStripMenuItem
            // 
            this.tableResults_ToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tableResults_ToolStripMenuItem.ForeColor = System.Drawing.Color.Goldenrod;
            this.tableResults_ToolStripMenuItem.Name = "tableResults_ToolStripMenuItem";
            this.tableResults_ToolStripMenuItem.Size = new System.Drawing.Size(325, 26);
            this.tableResults_ToolStripMenuItem.Text = "Показать таблицу результатов";
            this.tableResults_ToolStripMenuItem.Click += new System.EventHandler(this.tableResults_ToolStripMenuItem_Click);
            // 
            // admin_ToolStripMenuItem
            // 
            this.admin_ToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.admin_ToolStripMenuItem.ForeColor = System.Drawing.Color.Goldenrod;
            this.admin_ToolStripMenuItem.Name = "admin_ToolStripMenuItem";
            this.admin_ToolStripMenuItem.Size = new System.Drawing.Size(325, 26);
            this.admin_ToolStripMenuItem.Text = "Зайти в режим администратора";
            this.admin_ToolStripMenuItem.Click += new System.EventHandler(this.admin_ToolStripMenuItem_Click);
            // 
            // exit_ToolStripMenuItem
            // 
            this.exit_ToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.exit_ToolStripMenuItem.ForeColor = System.Drawing.Color.Goldenrod;
            this.exit_ToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.exit_ToolStripMenuItem.Name = "exit_ToolStripMenuItem";
            this.exit_ToolStripMenuItem.Size = new System.Drawing.Size(325, 26);
            this.exit_ToolStripMenuItem.Text = "Выйти";
            this.exit_ToolStripMenuItem.Click += new System.EventHandler(this.exit_ToolStripMenuItem_Click);
            // 
            // menu_ToolStripMenuItem
            // 
            this.menu_ToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.menu_ToolStripMenuItem.BackgroundImage = global::GeniyIdiotWinFormsApp.Properties.Resources.screensaver1;
            this.menu_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restart_ToolStripMenuItem,
            this.tableResults_ToolStripMenuItem,
            this.admin_ToolStripMenuItem,
            this.exit_ToolStripMenuItem});
            this.menu_ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menu_ToolStripMenuItem.ForeColor = System.Drawing.Color.Goldenrod;
            this.menu_ToolStripMenuItem.Name = "menu_ToolStripMenuItem";
            this.menu_ToolStripMenuItem.Size = new System.Drawing.Size(69, 25);
            this.menu_ToolStripMenuItem.Text = "Меню";
            // 
            // OutputDiagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.outputDiagnose);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.textAppeal1_Label);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OutputDiagnosis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Гений Идиот";
            this.Load += new System.EventHandler(this.OutputDiagnosis_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textAppeal1_Label;
        private System.Windows.Forms.Label outputDiagnose;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restart_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableResults_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem admin_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exit_ToolStripMenuItem;
    }
}