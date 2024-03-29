﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGamesApp.Core.Models
{
    public class ProblemTypeViewModel
    { 
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public string Instruction { get; set; } = null!;

        public bool IsActive { get; set; }

        public int ProblemCategoryId { get; set; }
    }
}
