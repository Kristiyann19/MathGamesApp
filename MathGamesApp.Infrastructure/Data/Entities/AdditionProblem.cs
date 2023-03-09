using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGamesApp.Infrastructure.Data.Entities
{
    public class AdditionProblem : Problem
    {
        public int FirstDigit { get; set; }

        public int SecondDigit { get; set; }

        public bool IsCorrect { get; set; }

        public int? UserAnswer { get; set; }
    }
}
