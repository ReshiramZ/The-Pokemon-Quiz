using Pokemon_Quiz.Questions.MediumQuestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Quiz.Questions.HardQuestions
{
    internal class HardQuestionsClass
    {
        private List<QuestionBase> QuestionsHardList;

        public HardQuestionsClass()
        {
            QuestionsHardList = new List<QuestionBase>
            {
                new HardQuestion01(),
                new HardQuestion02(), 
                new HardQuestion03()
            };
        }

        public void StartHardQuestions()
        {
            Random Dice = new Random();
            while (QuestionsHardList.Count > 0)
            {
                int QuestionChoosed = Dice.Next(QuestionsHardList.Count);
                QuestionsHardList[QuestionChoosed].AskAndAnswer();
                QuestionsHardList.RemoveAt(QuestionChoosed);
            }

            if (QuestionsHardList.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("Você completou o jogo!");

                Console.ReadKey();
            }
        }
    }
}
