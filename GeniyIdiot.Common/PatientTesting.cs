using System;
using System.Collections.Generic;
using GeniyIdiot.Common.Models;

namespace GeniyIdiot.Common
{
    public class PatientTesting
    {
        QuestionsStorage questionsStorage = new(); //запускаем хранилище вопросов

        private List<string> diagnoses = new()
        {
            "идиот",
            "кретин",
            "дурак",
            "нормальный",
            "талант",
            "гений"
        };
        public List<Question> RemainingQuestions { get; set; } = new();
        public int CountQuestions { get; set; }
        public double ScoreUser { get; set; }
        public double ResponseWeight { get; set; }
        public User User { get; set; } = new("indeterminate");

        public PatientTesting()
        {
            RemainingQuestions = questionsStorage.Questions; //создаём личный список вопросов для пациента
            CountQuestions = questionsStorage.Questions.Count; //получаем количество вопросов
            ScoreUser = 0; // счёт
            ResponseWeight = Convert.ToDouble(diagnoses.Count - 1) / CountQuestions; // определяем вес одного ответа
        }

        public void RateAnswer(Question question, int answer)
        {
            if (question.Answer == answer)
            {
                ScoreUser += ResponseWeight;
            }
        }

        public TestResult GetTestResult()
        {
            // определяем количество баллов в соответствии с количеством критериев
            var scoreInt = Convert.ToInt32(Math.Truncate(ScoreUser));
            var diagnosis = diagnoses[scoreInt];
            TestResult dataTestResult = new TestResult(User, ScoreUser, diagnosis);
            return dataTestResult;
        }

        public Question GetQuestion()
        {
            var rnd = new Random();
            var rndValue = rnd.Next(0, RemainingQuestions.Count);
            var rndQuestion = RemainingQuestions[rndValue];
            RemainingQuestions.Remove(rndQuestion);
            return rndQuestion;
        }

        public int GetRemainingNumberQuestions()
        {
            return RemainingQuestions.Count;
        }
    }
}
