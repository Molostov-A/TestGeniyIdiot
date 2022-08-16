using System;
using System.Windows.Forms;
using GeniyIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    public partial class AdminPanelForm : Form
    {
        private TestResultsStorage testResultsStorage = new();
        public AdminPanelForm()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
        }

        private void resetTestResult_Click(object sender, EventArgs e)
        {
            testResultsStorage.Reset();
            var resultsTesting = new ResultsTestingForm();
            resultsTesting.ShowDialog();
        }

        private void managerQuestions_Click(object sender, EventArgs e)
        {
            Hide();
            var questionsForm = new QuestionsForm();
            questionsForm.ShowDialog();
            Show();
        }
    }
}
