using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGamesApp.Infrastructure.Data.Entities
{
    public class Game //The game that you select to play
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; } = null!;

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

        [Required]
        [Range(0.0, 5.0)]
        public double AverageRating { get; set; }

        [Required]
        public int GameCategoryId { get; set; }

        [ForeignKey(nameof(GameCategoryId))]
        public GameCategory GameCategory { get; set; } = null!;


        [Required]
        public int GameTypeId { get; set; }

        [ForeignKey(nameof(GameTypeId))]
        public GameType GameType { get; set; } = null!;


        [Required]
        public int GameLevelId { get; set; }

        [ForeignKey(nameof(GameLevelId))]
        public GameLevel GameLevel { get; set; } = null!;
    }
}
