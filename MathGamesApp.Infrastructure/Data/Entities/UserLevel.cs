using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGamesApp.Infrastructure.Data.Entities
{
    public class UserLevel
    {
        public int Id { get; set; }

        public int Level { get; set; }

        public int Experience { get; set; }

        //make foreign key
        public string UserId { get; set; }

        public User User { get; set; }

    }
}
