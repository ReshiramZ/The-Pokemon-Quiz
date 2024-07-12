using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Quiz.Questions.EasyQuestions
{
    internal class EasyQuestion03:QuestionBase
    {
        public override void AskAndAnswer()
        {
        Case_Invalid_Answer:;
            Console.Clear();
            Console.WriteLine("Qual é o tipo do meowth de kanto?\n\n" +
                "A. Lutador (Fighting)\n" +
                "B. Sombrio (Dark)\n" +
                "C. Fada (Fairy)\n" +
                "D. Normal\n");

            try
            {
                char Input = Convert.ToChar(Console.ReadLine().ToUpper());
                switch (Input)
                {
                    case 'A':
                        Console.WriteLine("Que pena! você Errou...");
                        Console.ReadKey();
                        break;

                    case 'B':
                        Console.WriteLine("Que pena! você Errou...");
                        Console.ReadKey();
                        break;

                    case 'C':
                        Console.WriteLine("Que pena! você Errou...");
                        Console.ReadKey();
                        break;

                    case 'D':
                        Console.WriteLine("Eba! Você Acertou!");
                        Score++;
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Resposta inválida, digite novamente sua resposta..." +
                                          "Pressione enter para continuar...");
                        Console.ReadKey();
                        goto Case_Invalid_Answer;
                }
            }
            catch
            {
                Console.WriteLine("Isso não é um caractere,digite novamente.\n" +
                                  "Pressione enter para continuar...");
                Console.ReadKey();
                goto Case_Invalid_Answer;
            }
        }
    }
}
