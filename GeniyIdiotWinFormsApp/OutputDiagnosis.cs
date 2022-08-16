using System;
using System.Windows.Forms;
using GeniyIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    public partial class OutputDiagnosis : Form
    {
        private TestResultsStorage testResultsStorage;
        public OutputDiagnosis()
        {
            InitializeComponent();
        }
        private void OutputDiagnosis_Load(object sender, EventArgs e)
        {
            testResultsStorage = new TestResultsStorage();
            var numLastDiagnosis = testResultsStorage.GetTestResults().Count - 1;
            var diagnose = testResultsStorage.GetTestResults()[numLastDiagnosis];
            nameLabel.Text = diagnose.Patient.Name;
            textAppeal1_Label.Text = "Поздравляем!";
            outputDiagnose.Text = string.Format($"Вы - {diagnose.Diagnosis}!");
        }

        private void exit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tableResults_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var resultsTestingForm = new ResultsTestingForm();
            resultsTestingForm.ShowDialog();
        }

        private void restart_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void admin_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            var adminPanelForm = new AdminPanelForm();
            adminPanelForm.ShowDialog();
            Show();
        }
    }
}
