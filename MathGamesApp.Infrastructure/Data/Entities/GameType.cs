using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGamesApp.Infrastructure.Data.Entities
{
    public class GameType //addition, subtraction etc.
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public string Instruction { get; set; } = null!;

        public bool IsActive { get; set; }

        public List<Game> Games { get; set; } = new List<Game>();

    }
}
