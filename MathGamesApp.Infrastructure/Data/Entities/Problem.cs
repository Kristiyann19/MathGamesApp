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

        [Key]
        public int Id { get; set; }

        public int Answer { get; set; }

        [Required]
        [MaxLength(500)]
        public string Description { get; set; } = null!;

        [Required]
        [MaxLength(500)]
        public string Instruction { get; set; } = null!;

        [Required]
        public int DifficultyLevelId { get; set; }
        [ForeignKey(nameof(DifficultyLevelId))]
        public DifficultyLevel DifficultyLevel { get; set; } = null!;


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
