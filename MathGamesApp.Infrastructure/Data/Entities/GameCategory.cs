using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGamesApp.Infrastructure.Data.Entities
{
    public class GameCategory //Algebra, Geometry etc.
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public bool IsActive { get; set; }

        public List<GameType> GamesTypes { get; set; } = new List<GameType>();   
    }
}
