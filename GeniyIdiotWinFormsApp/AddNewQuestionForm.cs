using System;
using System.Windows.Forms;
using GeniyIdiot.Common;
using GeniyIdiot.Common.Models;

namespace GeniyIdiotWinFormsApp
{
    public partial class AddNewQuestionForm : Form
    {
        private QuestionsStorage questionsStorage = new();
        public AddNewQuestionForm()
        {
            InitializeComponent();
        }

        private void AddNewQuestionForm_Load(object sender, EventArgs e)
        {

        }

        private void enterQuestion_Click(object sender, EventArgs e)
        {
            if (inputTextQuestion.Text == "")
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("Вопрос не должен быть пустой строкой!", "Неверный ввод", buttons);
            }
            else
            {
                try
                {
                    var answer = Convert.ToInt32(inputeAnswerQuestion.Text);
                    questionsStorage.Add(new Question(inputTextQuestion.Text, answer));
                    enterQuestion.DialogResult = DialogResult.OK;
                    Close();
                }
                catch (FormatException)
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show("Пожалуйста, введите число!", "Неверный ввод", buttons);
                }
                catch
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show("Неверный ввод!", "Неверный ввод", buttons);
                }
            }
        }
    }
}
