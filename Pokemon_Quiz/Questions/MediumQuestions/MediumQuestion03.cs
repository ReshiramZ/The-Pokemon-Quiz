using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Quiz.Questions.MediumQuestions
{
    internal class MediumQuestion03 : QuestionBase
    {
        public override void AskAndAnswer()
        {
        Case_Invalid_Answer:;
            Console.Clear();
            Console.WriteLine("O que acontece quando um pokémon envenenando fica fora da batalha nos jogos da geração 5 em diante?\n\n" +
                "A. Nenhuma das opções abaixo\n" +
                "B. O pokémon recebia dano,mas quando o HP chegava a 0, ele desmaiava imediatamente\n" +
                "C. O pokémon recebia dano,mas quando o HP chegava a 1, ele se curava do envenenamento\n" +
                "D. O pokémon recebia dano,mas se um pokémon tiver com a habilidade poison heal,ele cura o pokémon envenenado\n");

            try
            {
                char Input = Convert.ToChar(Console.ReadLine().ToUpper());
                switch (Input)
                {
                    case 'A':
                        Console.WriteLine("Eba! Você Acertou!");
                        Score++;
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
