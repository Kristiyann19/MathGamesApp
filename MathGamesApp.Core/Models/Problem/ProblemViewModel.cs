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
        public int DifficultyLevel { get; set; }

        [Required]
        public string CorrectAnswer { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public string Instruction { get; set; } = null!;
        public bool IsActive { get; set; }
        public double AverageRating { get; set; }

    
        public int ProblemCategoryId { get; set; }

   


      
        public int ProblemTypeId { get; set; }

    }
}
