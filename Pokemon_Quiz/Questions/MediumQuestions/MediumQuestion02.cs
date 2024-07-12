using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Quiz.Questions.MediumQuestions
{
    internal class MediumQuestion02 : QuestionBase
    {
        public override void AskAndAnswer()
        {
        Case_Invalid_Answer:;
            Console.Clear();
            Console.WriteLine("De todas essas cadeias evolutivas, qual é a verdadeira?\n\n" +
                "A. Ekans -> Seviper\n" +
                "B. Luvdisc -> Alomomola\n" +
                "C. Wynaut -> Wobbuffet\n" +
                "D. Scatterbug -> Spewpa -> Beautifly\n");

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
                        Console.WriteLine("Eba! Você Acertou!");
                        Score++;
                        Console.ReadKey();
                        break;

                    case 'D':
                        Console.WriteLine("Que pena! você Errou...");
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
