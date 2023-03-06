using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGamesApp.Core.Models.Problem
{
    public class ProblemViewModel
    { 
        public int Id { get; set; }

        [Required]
        public int Answer { get; set; } 

        public string Description { get; set; } = null!;

        public string Instruction { get; set; } = null!;

        public int DifficultyLevelId { get; set; }

        public int ProblemCategoryId { get; set; }

        public int ProblemTypeId { get; set; }

    }
}
