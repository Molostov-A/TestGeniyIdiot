using System;
using GeniyIdiot.Common;
using GeniyIdiot.Common.Models;

namespace GeniyIdiotConsoleApp
{
    class Programm
    {
        private static Verification verification = new();
        private static TypicalInteract typical = new();
        private static TestResultsStorage testResultsStorage = new();
        private static QuestionsStorage questionsStorage = new();

        public static void Main()
        {
            while (true)
            {
                Console.WriteLine("Выберите номер одного из возможных действий:");
                Console.WriteLine("1) Пройти тестирование");
                Console.WriteLine("2) Вывести таблицу результатов");
                Console.WriteLine("3) Войти в режим администратора");
                Console.WriteLine("4) Выйти из программы");
                var choice = verification.CheckNumericInput();
                switch (choice)
                {
                    case 1:
                        Test();
                        Console.WriteLine("\nНажмите любую клавишу для возврата в меню.");
                        Console.ReadLine();
                        break;
                    case 2:
                        OutputConsole.ResultsTestInTable(testResultsStorage.GetTestResults());
                        Console.WriteLine("\nНажмите любую клавишу для возврата в меню.");
                        Console.ReadLine();
                        break;
                    case 3:
                        Admining();
                        Console.WriteLine("\nНажмите любую клавишу для возврата в меню.");
                        Console.ReadLine();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\nВведённого Вами номера действия не существует\n");
                        break;
                }
            }
        }

        public static void Test()
        {
            string name = "";
            do
            {
                Console.Write("Пожалуйста, введите своё имя: ");
                name = Console.ReadLine();
            } 
            while (verification.EmptyName(name));
            User user = new User(name);
            PatientTesting patienTesting = new PatientTesting(){User = user};

            // инстукция
            var timeSec = MyConstant.TimeLimitAnswer;
            Console.WriteLine();
            var instructionText = string.Format(
                "В игре \"Гений Идиот\" Вам будут задаваться вопросы, \n" +
                "на которые нужно будет давать целочисленные ответы. \n" +
                $"Время, которое даётся на каждый ответ равно {timeSec} секундам.\n\n" +
                "Нажмите любую клавишу для продолжения.");
            Console.WriteLine(instructionText);
            Console.ReadLine();

            for (int i = 0; i < patienTesting.CountQuestions; i++)
            {
                var question = patienTesting.GetQuestion();
                Console.WriteLine($"№{i + 1}. {question.Text}");
                var answer = verification.CheckNumericInputTimer(timeSec);
                patienTesting.RateAnswer(question, answer);
            }
            var testResult = patienTesting.GetTestResult();
            Console.WriteLine($"Наш диагноз: {user.Name}, Вы - {testResult.Diagnosis}!");
            testResultsStorage.Add(testResult);
        }

        public static void Admining()
        {
            var desgireWorkAsAnAdmin = verification.CheckInputPassword("admin");
            while (desgireWorkAsAnAdmin)
            {
                Console.WriteLine("Выберите номер одного из возможных действий:");
                Console.WriteLine($"1) Добавить тестовый вопрос.");
                Console.WriteLine($"2) Удалить тестовый вопрос.");
                Console.WriteLine($"3) Восстановить список тестовых вопросов до стандартного.");
                var choice = verification.CheckNumericInput();

                switch (choice)
                {
                    case 1:
                        AskAddNewTestQuestion();
                        break;
                    case 2:
                        RemoveTestQuestion();
                        break;
                    case 3:
                        ReturnDefoultTestQuestion();
                        break;
                    default:
                        Console.WriteLine("Введённого Вами номера действия не существует");
                        break;
                }
                desgireWorkAsAnAdmin = typical.BinaryAsk("Желаете продолжить работать как администратор?");
            }
        }
        private static void AskAddNewTestQuestion()
        {
            
            Console.WriteLine("Добавление нового тестового вопроса.");
            var desireToAddNewTestQuestion = true;
            while (desireToAddNewTestQuestion)
            {
                Console.WriteLine("Пожалуйста, введите свой вопрос: ");
                string question = Console.ReadLine();
                Console.WriteLine("Теперь введите ответ на свой вопрос: ");
                Console.WriteLine("(ответ должен быть в целочисленной форме)");
                var answer = verification.CheckNumericInput();
                var newTestQuestion = new Question(question, answer);

                Console.WriteLine("Выводим новый тестовый вопрос:");
                Console.WriteLine("Вопрос: " + newTestQuestion.Text);
                Console.WriteLine("Ответ: " + newTestQuestion.Answer);
                var desireToAdd = typical.BinaryAsk(
                    "Желаете сохранить новый тестовый вопрос ?",
                    "Хорошо, вопрос добавлен в список вопросов",
                    "");
                if (desireToAdd)
                {
                    questionsStorage.Add(newTestQuestion);
                }
                desireToAddNewTestQuestion = typical.BinaryAsk(
                    "Желаете добавить новый тестовый вопрос?");
            }
        }
        private static void RemoveTestQuestion()
        {
            Console.WriteLine("Выбрано действие: удаление тестового вопроса.");
            var desireContinue = true;
            var questions = questionsStorage.Questions;
            while (desireContinue)
            {
                Console.WriteLine("Выберите номер вопроса, который необходимо удалить:");
                for (int i = 0; i < questions.Count; i++)
                {
                    Console.WriteLine($"Тестовый вопрос № {i + 1}.");
                    Console.WriteLine($"   Вопрос: {questions[i].Text}");
                    Console.WriteLine($"   Ответ: {questions[i].Answer}");
                }
                var choice = verification.CheckNumericInput();
                if (choice > questions.Count || choice <= 0)
                {
                    Console.WriteLine("Выбранного вами вопроса - не существует.");
                }
                else
                {
                    var question = questions[choice - 1];
                    questionsStorage.Remove(question);
                    Console.WriteLine($"Вопрос № {choice} удалён.");
                }
                desireContinue = typical.BinaryAsk(
                    "Желаете удалить ещё один вопрос?");
            }
        }

        private static void ReturnDefoultTestQuestion()
        {
            Console.WriteLine("Выбрано действие: восстановить список тестовых вопросов до стандартного.");
            questionsStorage.ReturnDefoultQuestions();
            Console.WriteLine("Список тестовых вопросов восстановлен до стандартного");
        }
    }
}

