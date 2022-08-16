using System;
using System.Windows.Forms;
using GeniyIdiot.Common;
using GeniyIdiot.Common.Models;

namespace GeniyIdiotWinFormsApp
{
    public partial class MainForm : Form
    {
        private UsersStorage usersStorage = new();
        private InputUserName inputUserName = new();
        private OutputDiagnosis outputDiagnosis = new();
        private TestResultsStorage testResultsStorage = new();
        private PatientTesting patienTesting = new();
        private Question question;
        private Verification verification = new();

        private int timeSec = MyConstant.TimeLimitAnswer; //количество секунд на ответ
        private int timerMiliSec; //количество милисекунд
        public MainForm()
        {
            InitializeComponent();
            timerMiliSec = timeSec * 1000;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Hide();
            inputUserName.ShowDialog();

            if (usersStorage.GetCurrentUser().Name == null) Close();
            else
            {
                // инстукция
                var instructionText = string.Format(
                                                    "В игре \"Гений Идиот\" Вам будут задаваться вопросы, \n" +
                                                    "на которые нужно будет давать целочисленные ответы. \n" +
                                                    $"Время, которое даётся на каждый ответ равно {timeSec} секундам.");
                MessageBox.Show(instructionText, "Инструкция");

                //Запуск таймера
                var textTime = GetTextTimer(timerMiliSec);
                timer_label.Text = textTime;
                timer_limitTimeAnswer.Interval = 100;
                timer_limitTimeAnswer.Start();

                Show();
                Test();
            }
        }
        private User user { get; set; }
        private void Test()
        {
            user = usersStorage.GetCurrentUser();
            patienTesting.User = user;
            // пишем первый вопрос
            question = patienTesting.GetQuestion();
            questionNumberLabel.Text = "Вопрос № 1";
            questionTextLabel.Text = question.Text;
        }

        private void enterQuestionButton_Click(object sender, EventArgs e)
        {
            bool answerValidation = false;
            int answer = 0;
            if (!answerValidation)
            {
                if (timerMiliSec <= 0)
                {
                    if (AnswerTextBox.Text == "")
                    {
                        AnswerTextBox.Text = MyConstant.IncorrectAnswer;
                    }
                    if (!int.TryParse(AnswerTextBox.Text, out answer))
                    {
                        answer = int.Parse(MyConstant.IncorrectAnswer);
                    }
                    answerValidation = true;
                }
                else
                {
                    (answerValidation, answer) = verification.CheckNumericInput(AnswerTextBox.Text);
                }
                if (!answerValidation)
                {
                    AnswerTextBox.Clear();
                }
            }
            if (answerValidation)
            {
                patienTesting.RateAnswer(question, answer);
                AnswerTextBox.Clear();
                if (patienTesting.GetRemainingNumberQuestions() > 0)
                {
                    // пишем № следующего вопроса
                    var numberQuestions = patienTesting.CountQuestions - patienTesting.GetRemainingNumberQuestions() + 1;
                    questionNumberLabel.Text = string.Format($"Вопрос №{numberQuestions}");

                    question = patienTesting.GetQuestion();
                    timerReset();

                    // пишем следующий вопрос
                    questionTextLabel.Text = question.Text;
                }
                else
                {
                    TestResult dataTestResult = patienTesting.GetTestResult();
                    testResultsStorage.Add(dataTestResult);
                    timer_limitTimeAnswer.Stop();
                    Hide();
                    outputDiagnosis.ShowDialog();
                    Close();
                }
            }
        }

        private void timer_limitTimeAnswer_Tick(object sender, EventArgs e)
        {
            
            timerMiliSec -= timer_limitTimeAnswer.Interval; //количество милисекунд
            var textTime = GetTextTimer(timerMiliSec);
            timer_label.Text = textTime;
            if (timerMiliSec <= 0)
            {
                enterQuestionButton_Click(this, e);
            }
        }

        private void timerReset()
        {
            timerMiliSec = timeSec * 1000;
        }

        private string GetTextTimer(int timerMiliSec)
        {
            TimeSpan span = TimeSpan.FromMilliseconds(timerMiliSec);
            return $"Время: {span.Seconds},{Math.Abs(span.Milliseconds % 1000) / 100} секунд";
        }
    }
}
