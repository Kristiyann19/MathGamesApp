﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGamesApp.Infrastructure.Data.Entities
{
    public class DifficultyLevel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int ProblemTypeId { get; set; } 

        [ForeignKey(nameof(ProblemTypeId))]
        public ProblemType ProblemType { get; set; }

        public List<Problem> Problem { get; set; } = new List<Problem>();
    }
}
