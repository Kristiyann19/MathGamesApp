using MathGamesApp.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGamesApp.Infrastructure.Data.Configurations
{
    internal class DifficultyLevelConfiguration : IEntityTypeConfiguration<DifficultyLevel>
    {
        public void Configure(EntityTypeBuilder<DifficultyLevel> builder)
        {
            builder.HasData(CreateDifficultyLevels());
        }

        private List<DifficultyLevel> CreateDifficultyLevels()
        {
            var difficultyLevels = new List<DifficultyLevel>()
            {
                new DifficultyLevel()
                {
                    Id = 1,
                    Name = "1st Grade",
                    ProblemTypeId = 1,
                },
                new DifficultyLevel()
                {
                    Id = 2,
                    Name = "2nd Grade",
                    ProblemTypeId = 1,
                },
                new DifficultyLevel()
                {
                    Id = 3,
                    Name = "3th Grade",
                    ProblemTypeId = 1,
                },
                new DifficultyLevel()
                {
                    Id = 4,
                    Name = "4th Grade",
                    ProblemTypeId = 1,
                },
                new DifficultyLevel()
                {
                    Id = 5,
                    Name = "5th Grade",
                    ProblemTypeId = 1,
                },
                new DifficultyLevel()
                {
                    Id = 6,
                    Name = "6th Grade",
                    ProblemTypeId = 1,
                },
                new DifficultyLevel()
                {
                    Id = 7,
                    Name = "7th Grade",
                    ProblemTypeId = 1,
                },
                new DifficultyLevel()
                {
                    Id = 8,
                    Name = "1st Grade",
                    ProblemTypeId = 2,
                },
                new DifficultyLevel()
                {
                    Id = 9,
                    Name = "2nd Grade",
                    ProblemTypeId = 2,
                },
                new DifficultyLevel()
                {
                    Id = 10,
                    Name = "3th Grade",
                    ProblemTypeId = 2,
                },
                new DifficultyLevel()
                {
                    Id = 11,
                    Name = "4th Grade",
                    ProblemTypeId = 2,
                },
                new DifficultyLevel()
                {
                    Id = 12,
                    Name = "5th Grade",
                    ProblemTypeId = 2,
                },
                new DifficultyLevel()
                {
                    Id = 13,
                    Name = "6th Grade",
                    ProblemTypeId = 2,
                },
                new DifficultyLevel()
                {
                    Id = 14,
                    Name = "7th Grade",
                    ProblemTypeId = 2,
                },
                 new DifficultyLevel()
                {
                    Id = 15,
                    Name = "1st Grade",
                    ProblemTypeId = 3,
                },
                  new DifficultyLevel()
                {
                    Id = 16,
                    Name = "2nd Grade",
                    ProblemTypeId = 3,
                },
                   new DifficultyLevel()
                {
                    Id = 17,
                    Name = "3th Grade",
                    ProblemTypeId = 3,
                },
                 new DifficultyLevel()
                {
                    Id = 18,
                    Name = "4th Grade",
                    ProblemTypeId = 3,
                },
                  new DifficultyLevel()
                {
                    Id = 19,
                    Name = "5th Grade",
                    ProblemTypeId = 3,
                },
                   new DifficultyLevel()
                {
                    Id = 20,
                    Name = "6th Grade",
                    ProblemTypeId = 3,
                },
                    new DifficultyLevel()
                {
                    Id = 21,
                    Name = "7th Grade",
                    ProblemTypeId = 3,
                },
                    new DifficultyLevel()
                {
                    Id = 22,
                    Name = "1st Grade",
                    ProblemTypeId = 4,
                },
                  new DifficultyLevel()
                {
                    Id = 23,
                    Name = "2nd Grade",
                    ProblemTypeId = 4,
                },
                   new DifficultyLevel()
                {
                    Id = 24,
                    Name = "3th Grade",
                    ProblemTypeId = 4,
                },
                 new DifficultyLevel()
                {
                    Id = 25,
                    Name = "4th Grade",
                    ProblemTypeId = 4,
                },
                  new DifficultyLevel()
                {
                    Id = 26,
                    Name = "5th Grade",
                    ProblemTypeId = 4,
                },
                   new DifficultyLevel()
                {
                    Id = 27,
                    Name = "6th Grade",
                    ProblemTypeId = 4,
                },
                    new DifficultyLevel()
                {
                    Id = 28,
                    Name = "7th Grade",
                    ProblemTypeId = 4,
                }
            };

            return difficultyLevels;
        }
    }
}
