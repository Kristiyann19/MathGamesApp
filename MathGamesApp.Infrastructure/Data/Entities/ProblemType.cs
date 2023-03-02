using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGamesApp.Infrastructure.Data.Entities
{
    public class ProblemType //addition, subtraction etc.
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [MaxLength(500)]
        public string Instruction { get; set; } = null!;

        [Required]
        public bool IsActive { get; set; }

        [Required]
        public int ProblemCategoryId { get; set; }

        [ForeignKey(nameof(ProblemCategoryId))]
        public ProblemCategory ProblemCategory { get; set; } = null!;

        [Required]
        public List<Problem> Games { get; set; } = new List<Problem>();

    }
}
