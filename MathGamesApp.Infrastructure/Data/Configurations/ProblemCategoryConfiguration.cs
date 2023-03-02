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
            var problemCategories = new List<ProblemCategory>()
            {
                new ProblemCategory()
                {
                    Id = 1,
                    Name = "Arithmetic",
                    Description = "Traditional operations on numbers - addition, subtraction, multiplication, division, exponentiation",
                    ImageUrl = "https://media.proprofs.com/images/QM/user_images/2169923/1514977691.jpg"
                },

                new ProblemCategory()
                {
                    Id = 2,
                    Name = "Algebra",
                    Description = "Algebra deals with the manipulation of variables and the rules for manipulating these variables in formulas",
                    ImageUrl = "https://st3.depositphotos.com/3591429/13656/i/450/depositphotos_136562916-stock-photo-creative-website-banner.jpg"
                },

                new ProblemCategory()
                {
                    Id = 3,
                    Name = "Geometry",
                    Description = "Geometry is concerned with the shapes of individual objects or shapes and their properties",
                    ImageUrl = "https://www.gyanipandit.com/en/wp-content/uploads/2021/06/Geometry-2cde81a7.jpg"
                }

            };

            return problemCategories;
        }
    }
}
