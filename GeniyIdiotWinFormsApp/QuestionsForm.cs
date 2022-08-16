using System;
using System.Windows.Forms;
using GeniyIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    public partial class QuestionsForm : Form
    {
        private QuestionsStorage questionsStorage = new();
        public QuestionsForm()
        {
            InitializeComponent();
        }

        private void Questions_Load(object sender, EventArgs e)
        {
            SetValuesTable();
        }

        private void deleteQuestion_Click(object sender, EventArgs e)
        {
            var deletedRows = dataGridView1.SelectedRows;
            for (int i = 0; i < deletedRows.Count; i++)
            {
                var row = deletedRows[i];
                var textQuestions = row.Cells[1]?.Value?.ToString();
                if (textQuestions != null)
                    questionsStorage.Remove(textQuestions);
            }
            Controls.Clear();
            InitializeComponent();
            SetValuesTable();
        }

        private void addNewQuestion_Button_Click(object sender, EventArgs e)
        {
            var addNewQuestionForm = new AddNewQuestionForm();
            addNewQuestionForm.ShowDialog();
            Controls.Clear();
            InitializeComponent();
            SetValuesTable();
        }

        private void resetQuestions_Button_Click(object sender, EventArgs e)
        {
            questionsStorage.ReturnDefoultQuestions();
            Controls.Clear();
            InitializeComponent();
            SetValuesTable();
        }

        private void SetValuesTable()
        {
            questionsStorage = new();
            var questions = questionsStorage.Questions;
            for (int i = 0; i < questions.Count; i++)
            {
                var question = questions[i];
                dataGridView1.Rows.Add(i + 1, question.Text, question.Answer);
            }
        }
    }
}
