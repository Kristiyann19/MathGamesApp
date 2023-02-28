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
    internal class ProblemCategoryConfiguration : IEntityTypeConfiguration<ProblemCategory>
    {
        public void Configure(EntityTypeBuilder<ProblemCategory> builder)
        {
            builder.HasData(CreateProblemCategory());
        }

        private List<ProblemCategory> CreateProblemCategory()
        {
            List<ProblemCategory> problemCategories = new List<ProblemCategory>()
            {
                new ProblemCategory()
                {
                    Id = 1,
                    Name = "Arithmetic",
                    Description = "Traditional operations on numbers - addition, subtraction, multiplication, division, exponentiation"
                },

                new ProblemCategory()
                {
                    Id = 2,
                    Name = "Algebra",
                    Description = "Algebra deals with the manipulation of variables and the rules for manipulating these variables in formulas"
                },

                new ProblemCategory()
                {
                    Id = 3,
                    Name = "Geometry",
                    Description = "Geometry is concerned with the shapes of individual objects or shapes and their properties"
                }

            };

            return problemCategories;
        }
    }
}
