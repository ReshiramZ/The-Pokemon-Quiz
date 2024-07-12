using Pokemon_Quiz.Questions;
using Pokemon_Quiz.Questions.EasyQuestions;
using Pokemon_Quiz.Questions.HardQuestions;
using Pokemon_Quiz.Questions.MediumQuestions;
using static System.Formats.Asn1.AsnWriter;

EasyQuestionsClass easyQuestions = new();
MediumQuestionsClass mediumQuestions = new();
HardQuestionsClass hardQuestions = new();

easyQuestions.StartEasyQuestions();
mediumQuestions.StartMediumQuestions();
hardQuestions.StartHardQuestions();
CalculateScore();

static void CalculateScore()
{
    Console.WriteLine($"Pontuação: {QuestionBase.Score}/10");

    if (QuestionBase.Score <= 4)
    {
        Console.WriteLine("Você errou muitas vezes, mais sorte na próxima vez!");
    }
    else if (QuestionBase.Score >= 5 && QuestionBase.Score < 8)
    {
        Console.WriteLine("Você está indo bem!");
    }
    else if (QuestionBase.Score >= 8 && QuestionBase.Score < 10)
    {
        Console.WriteLine("Você sabe de MUITA coisa sobre pokémon!");
    }
    else if (QuestionBase.Score == 10)
    {
        Console.WriteLine("Você é um verdadeiro mestre pokémon!");
    }
}