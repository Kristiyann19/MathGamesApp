using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGamesApp.Infrastructure.Data.Entities
{
    public class GameLevel //The difficulty u want for the game 
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int DifficultyLevel { get; set; }
    }
}
