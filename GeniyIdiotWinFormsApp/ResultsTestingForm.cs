using System;
using System.Windows.Forms;
using GeniyIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    public partial class ResultsTestingForm : Form
    {
        private TestResultsStorage testResultsStorage = new();
        public ResultsTestingForm()
        {
            InitializeComponent();
        }

        private void ResultsTesting_Load(object sender, EventArgs e)
        {
            
            var results = testResultsStorage.GetTestResults();
            foreach (var result in results)
            {
                resultsDataGridView.Rows.Add(result.Patient.Name,result.Scores, result.Diagnosis, result.Time.ToLocalTime());
            }
        }

        private void admin_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
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

        private void restart_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
