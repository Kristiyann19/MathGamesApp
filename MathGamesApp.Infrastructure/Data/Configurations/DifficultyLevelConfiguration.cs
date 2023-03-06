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
                    Name = "1st Grade"
                },
                new DifficultyLevel()
                {
                    Id = 2,
                    Name = "2nd Grade"
                },
                new DifficultyLevel()
                {
                    Id = 3,
                    Name = "3th Grade"
                },
                new DifficultyLevel()
                {
                    Id = 4,
                    Name = "4th Grade"
                },
                new DifficultyLevel()
                {
                    Id = 5,
                    Name = "5th Grade"
                },
                new DifficultyLevel()
                {
                    Id = 6,
                    Name = "6th Grade"
                },
                new DifficultyLevel()
                {
                    Id = 7,
                    Name = "7th Grade"
                },

            };

            return difficultyLevels;
        }
    }
}
