using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Quiz.Questions
{
    internal abstract class QuestionBase
    {
        public static int Score { get; set; } = 0;
        public abstract void AskAndAnswer();
    }
}
