using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Quiz.Questions.EasyQuestions
{
    internal class EasyQuestionsClass
    {
        private List<QuestionBase> QuestionsEasyList;

        public EasyQuestionsClass()
        {
            QuestionsEasyList = new List<QuestionBase>
            {
                new EasyQuestion01(),
                new EasyQuestion02(),
                new EasyQuestion03()
            };
        }

        public void StartEasyQuestions()
        {
            Random Dice = new Random();
            while (QuestionsEasyList.Count > 0)
            {
                int QuestionChoosed = Dice.Next(QuestionsEasyList.Count);
                QuestionsEasyList[QuestionChoosed].AskAndAnswer();
                QuestionsEasyList.RemoveAt(QuestionChoosed);
            }

            if (QuestionsEasyList.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("Você respondeu todas as perguntas fáceis,agora vamos para as perguntas médias.");
                Console.ReadKey();
            }
        }
    }
}
