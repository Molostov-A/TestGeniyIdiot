namespace GeniyIdiotWinFormsApp
{
    partial class ResultsTestingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultsTestingForm));
            this.resultsDataGridView = new System.Windows.Forms.DataGridView();
            this.UserNameColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountScoresColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiagnoseColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restart_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.admin_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textAppeal_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultsDataGridView
            // 
            this.resultsDataGridView.BackgroundColor = System.Drawing.Color.OldLace;
            this.resultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserNameColumn1,
            this.CountScoresColumn,
            this.DiagnoseColumn,
            this.DataTimeColumn});
            this.resultsDataGridView.Location = new System.Drawing.Point(12, 56);
            this.resultsDataGridView.Name = "resultsDataGridView";
            this.resultsDataGridView.RowTemplate.Height = 25;
            this.resultsDataGridView.Size = new System.Drawing.Size(541, 409);
            this.resultsDataGridView.TabIndex = 0;
            // 
            // UserNameColumn1
            // 
            this.UserNameColumn1.HeaderText = "Имя";
            this.UserNameColumn1.Name = "UserNameColumn1";
            // 
            // CountScoresColumn
            // 
            this.CountScoresColumn.HeaderText = "Количество набранных баллов";
            this.CountScoresColumn.Name = "CountScoresColumn";
            // 
            // DiagnoseColumn
            // 
            this.DiagnoseColumn.HeaderText = "Диагноз";
            this.DiagnoseColumn.Name = "DiagnoseColumn";
            // 
            // DataTimeColumn
            // 
            this.DataTimeColumn.HeaderText = "Дата тестирования";
            this.DataTimeColumn.Name = "DataTimeColumn";
            this.DataTimeColumn.Width = 200;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(565, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_ToolStripMenuItem
            // 
            this.menu_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restart_ToolStripMenuItem,
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
            this.restart_ToolStripMenuItem.Click += new System.EventHandler(this.restart_ToolStripMenuItem_Click);
            // 
            // admin_ToolStripMenuItem
            // 
            this.admin_ToolStripMenuItem.Name = "admin_ToolStripMenuItem";
            this.admin_ToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.admin_ToolStripMenuItem.Text = "Зайти в режим администратора";
            this.admin_ToolStripMenuItem.Click += new System.EventHandler(this.admin_ToolStripMenuItem_Click);
            // 
            // exit_ToolStripMenuItem
            // 
            this.exit_ToolStripMenuItem.Name = "exit_ToolStripMenuItem";
            this.exit_ToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.exit_ToolStripMenuItem.Text = "Выйти";
            this.exit_ToolStripMenuItem.Click += new System.EventHandler(this.exit_ToolStripMenuItem_Click);
            // 
            // textAppeal_Label
            // 
            this.textAppeal_Label.AutoSize = true;
            this.textAppeal_Label.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.textAppeal_Label.Location = new System.Drawing.Point(167, 32);
            this.textAppeal_Label.Name = "textAppeal_Label";
            this.textAppeal_Label.Size = new System.Drawing.Size(211, 21);
            this.textAppeal_Label.TabIndex = 6;
            this.textAppeal_Label.Text = "Результаты тестирования";
            // 
            // ResultsTestingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(565, 476);
            this.Controls.Add(this.textAppeal_Label);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.resultsDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResultsTestingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Гений Идиот";
            this.Load += new System.EventHandler(this.ResultsTesting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView resultsDataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restart_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem admin_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exit_ToolStripMenuItem;
        private System.Windows.Forms.Label textAppeal_Label;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNameColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountScoresColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiagnoseColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataTimeColumn;
    }
}