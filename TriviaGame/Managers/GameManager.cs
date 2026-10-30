using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriviaGame.Models;

namespace TriviaGame.Managers
{
    internal class GameManager
    {
        private List<Question> questions;
        private Random random;
        public int Score { get; private set; }
        public GameManager()
        {
            random = new Random();
            Score = 0;
            questions = new List<Question>
            { 

            };
        }
        public Question getQuestion()
        {
            if (questions.Count == 0)
            {
                return null;
            }
            int index = random.Next(questions.Count);
            Question selected = questions[index];
            questions.RemoveAt(index);
            return selected;
           
        }
        public bool CheckAnswer(Question question, string answer)
        {
            bool correct = string.Equals(question.CorrectAnswer,answer.Trim(), StringComparison.OrdinalIgnoreCase);
            if (correct)
            {
                Score++;
                return correct;
            }
            return false;
        }
    }
}
