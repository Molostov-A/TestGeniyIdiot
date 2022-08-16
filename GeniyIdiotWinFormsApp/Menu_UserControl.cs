using System;
using System.Windows.Forms;
using GeniyIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    public partial class Menu_UserControl : UserControl
    {
        private MainForm _mainForm;
        public Menu_UserControl()
        {
            InitializeComponent();
        }
        public Menu_UserControl(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
        }

        private void exit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void admin_ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (_mainForm == null)
            {
                if (MyConstant.AdminAutorisation)
                {
                    var AdminPanel = new AdminPanelForm();
                    AdminPanel.ShowDialog();
                }
                else
                {
                    var password = new Password();
                    password.ShowDialog();
                }
            }
            else
            {
                _mainForm?.Hide();
                _mainForm?.timer_limitTimeAnswer?.Stop();
                if (MyConstant.AdminAutorisation)
                {
                    var AdminPanel = new AdminPanelForm();
                    AdminPanel.ShowDialog();
                }
                else
                {
                    var password = new Password();
                    password.ShowDialog();
                }
                _mainForm?.timer_limitTimeAnswer?.Start();
                _mainForm?.Show();
            }

        }

        private void tableResults_ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var ResultsTesting = new ResultsTestingForm();
            ResultsTesting.ShowDialog();
        }

        private void restart_ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
