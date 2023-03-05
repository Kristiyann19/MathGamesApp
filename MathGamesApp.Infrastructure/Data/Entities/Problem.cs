using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGamesApp.Infrastructure.Data.Entities
{
    public class Problem //The game that you select to play
    {
        //MAYBE ADD EXPERIENCE OR THINK ABOUT A WAY TO DO THE LEVEL UPPING!

        [Key]
        public int Id { get; set; }

        [Required]
        [Range(1, 7)]
        public int DifficultyLevel { get; set; }

        [Required]
        public string CorrectAnswer { get; set; } = null!;

        [Required]
        [MaxLength(500)]
        public string Description { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [MaxLength(500)]
        public string Instruction { get; set; } = null!;

        [Required]
        public bool IsActive { get; set; }

        //Maybe delete this later
        [Required]
        [Range(0.0, 5.0)]
        public double AverageRating { get; set; }

        [Required]
        public int ProblemCategoryId { get; set; }

        [ForeignKey(nameof(ProblemCategoryId))]
        public ProblemCategory ProblemCategory { get; set; } = null!;


        [Required]
        public int ProblemTypeId { get; set; }

        [ForeignKey(nameof(ProblemTypeId))]
        public ProblemType ProblemType { get; set; } = null!;

    }
}
