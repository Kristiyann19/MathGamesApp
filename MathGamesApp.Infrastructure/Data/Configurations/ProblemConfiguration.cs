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
    internal class ProblemConfiguration : IEntityTypeConfiguration<Problem>
    {
        public void Configure(EntityTypeBuilder<Problem> builder)
        {
            builder.HasData(CreateProblem());
        }

        //TODO MAYBE: Make the addition and the easy problems with random method and the once that cant be random to be hard-coded!
        private List<Problem> CreateProblem()
        {
            var problems = new List<Problem>()
            {
                new Problem()
                {
                    Id = 1,
                    DifficultyLevel = 1,
                    AverageRating = 5,
                    Description = "s",
                    ImageUrl = "https://www.theschoolrun.com/sites/theschoolrun.com/files/article_images/addition.jpg",
                    Instruction = "test",
                    ProblemCategoryId = 1,
                    IsActive = true,
                    ProblemTypeId = 1

                }
            };

            return problems;
        }
    }
}
