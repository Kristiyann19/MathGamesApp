using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGamesApp.Infrastructure.Data.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public int Level { get; set; }

        public int Experience { get; set; }

        //DateOfBirth: To store the user's date of birth.
        //Gender: To store the user's gender.
        //Country and City: To store the user's location.
        //ProfilePictureUrl: To store a URL to the user's profile picture.
    }
}
