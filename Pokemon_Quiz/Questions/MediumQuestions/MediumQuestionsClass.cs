using Pokemon_Quiz.Questions.EasyQuestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Quiz.Questions.MediumQuestions
{
    internal class MediumQuestionsClass
    {
        private List<QuestionBase> QuestionsMediumList;

        public MediumQuestionsClass()
        {
            QuestionsMediumList = new List<QuestionBase>
            {
                new MediumQuestion01(),
                new MediumQuestion02(),
                new MediumQuestion03(),
                new MediumQuestion04()
            };
        }

        public void StartMediumQuestions()
        {
            Random Dice = new Random();
            while (QuestionsMediumList.Count > 0)
            {
                int QuestionChoosed = Dice.Next(QuestionsMediumList.Count);
                QuestionsMediumList[QuestionChoosed].AskAndAnswer();
                QuestionsMediumList.RemoveAt(QuestionChoosed);
            }

            if (QuestionsMediumList.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("Você respondeu todas as perguntas médias,agora vamos para as perguntas difíceis.");
                Console.ReadKey();
            }
        }
    }
}
