using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Quiz.Questions.MediumQuestions
{
    internal class MediumQuestion01 : QuestionBase
    {
        public override void AskAndAnswer()
        {
        Case_Invalid_Answer:;
            Console.Clear();
            Console.WriteLine("Qual é o efeito secundário da queimadura (Burn)?\n\n" +
                "A. Nenhuma dessas opções abaixo\n" +
                "B. Reduzir o dano de ataques físicos do pokémon queimado pela metade\n" +
                "C. Aumentar as chances do aplicador da condição dar crítico no pokémon queimado\n" +
                "D. Aumentar o dano de ataques do tipo fogo do aplicador da condição quando o pokémon queimado é do tipo planta\n");

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
                        Console.WriteLine("Eba! Você Acertou!");
                        Score++;
                        Console.ReadKey();
                        break;

                    case 'C':
                        Console.WriteLine("Que pena! você Errou...");
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
