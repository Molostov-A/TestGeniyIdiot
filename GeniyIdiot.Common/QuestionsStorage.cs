using System.Collections.Generic;
using GeniyIdiot.Common.Models;

namespace GeniyIdiot.Common
{
    public class QuestionsStorage
    {
        private readonly JsonProvider _storage = new("test_questions");
        public List<Question> Questions { get; private set; }

        public QuestionsStorage()
        {
            Questions = GetFromFile();
        }

        private List<Question> GetFromFile()
        {
            var questionsFromStorage = _storage.Read<List<Question>>();
            if (questionsFromStorage.Count != 0)
                return questionsFromStorage;
            return TakeDefoultQuestions();
        }
        
        private List<Question> TakeDefoultQuestions()
        {
            List<Question> defoultQuestions = new()
            {
                new Question("Сколько будет два плюс два умноженное на два?", 6),
                new Question("Бревно нужно распилить на 10 частей, сколько надо сделать пропилов?", 9),
                new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25),
                new Question("Укол делают каждые полчаса, сколько нужно минут для трёх уколов?", 60),
                new Question("Пять свечей горело, две потухли. Сколько свечей осталось?", 2)
            };
            return defoultQuestions;
        }

        private void Save()
        {
            _storage.Write(Questions);
        }

        public void Add(Question newQuestion)
        {
            Questions.Add(newQuestion);
            Save();
        }

        public void Remove(Question question)
        {
            Questions.Remove(question);
            Save();
        }

        public void Remove(string textQuestion)
        {
            Questions.RemoveAll(x => x.Text == textQuestion);
            Save();
        }

        public void ReturnDefoultQuestions()
        {
            Questions = TakeDefoultQuestions();
            Save();
        }

    }
}
