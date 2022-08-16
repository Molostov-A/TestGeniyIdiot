namespace GeniyIdiotWinFormsApp
{
    partial class Menu_UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restart_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableResults_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.admin_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(426, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_ToolStripMenuItem
            // 
            this.menu_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restart_ToolStripMenuItem,
            this.tableResults_ToolStripMenuItem,
            this.admin_ToolStripMenuItem,
            this.exit_ToolStripMenuItem});
            this.menu_ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menu_ToolStripMenuItem.Name = "menu_ToolStripMenuItem";
            this.menu_ToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.menu_ToolStripMenuItem.Text = "Меню";
            // 
            // restart_ToolStripMenuItem
            // 
            this.restart_ToolStripMenuItem.Name = "restart_ToolStripMenuItem";
            this.restart_ToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.restart_ToolStripMenuItem.Text = "Перезапустить приложение";
            this.restart_ToolStripMenuItem.Click += new System.EventHandler(this.restart_ToolStripMenuItem_Click_1);
            // 
            // tableResults_ToolStripMenuItem
            // 
            this.tableResults_ToolStripMenuItem.Name = "tableResults_ToolStripMenuItem";
            this.tableResults_ToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.tableResults_ToolStripMenuItem.Text = "Вывести таблицу результатов";
            this.tableResults_ToolStripMenuItem.Click += new System.EventHandler(this.tableResults_ToolStripMenuItem_Click_1);
            // 
            // admin_ToolStripMenuItem
            // 
            this.admin_ToolStripMenuItem.Name = "admin_ToolStripMenuItem";
            this.admin_ToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.admin_ToolStripMenuItem.Text = "Зайти в режим администратора";
            this.admin_ToolStripMenuItem.Click += new System.EventHandler(this.admin_ToolStripMenuItem_Click_1);
            // 
            // exit_ToolStripMenuItem
            // 
            this.exit_ToolStripMenuItem.Name = "exit_ToolStripMenuItem";
            this.exit_ToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.exit_ToolStripMenuItem.Text = "Выйти";
            this.exit_ToolStripMenuItem.Click += new System.EventHandler(this.exit_ToolStripMenuItem_Click);
            // 
            // Menu_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.menuStrip1);
            this.Name = "Menu_UserControl";
            this.Size = new System.Drawing.Size(426, 31);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restart_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableResults_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem admin_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exit_ToolStripMenuItem;
    }
}
