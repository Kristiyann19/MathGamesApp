using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGamesApp.Infrastructure.Data.Entities
{
    public class Game //The game that you select to play
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public string Instruction { get; set; } = null!;

        public bool IsActive { get; set; }

        public double AverageRating { get; set; }

        //make the foreign keys
        public int GameCategoryId { get; set; }

        public GameCategory GameCategory { get; set; }

        //make foreign keys
        public int GameTypeId { get; set; }

        public GameType GameType { get; set; }

        //make foreign keys

        public int GameLevelId { get; set; }

        public GameLevel GameLevel { get; set; }    
    }
}
