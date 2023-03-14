using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGamesApp.Core.Models.Problem
{
    public class AdditionProblemWithAnswerViewModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int DifficultyLevelId { get; set; }
        public int Answer { get; set; }
        public int? UserAnswer { get; set; }
        public bool IsCorrect { get; set; }
        public int ProblemTypeId { get; set; }
        public int ProblemCategoryId { get; set; }
        public string Instruction { get; set; }
    }
}
