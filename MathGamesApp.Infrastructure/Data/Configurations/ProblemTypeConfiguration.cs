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
    internal class ProblemTypeConfiguration : IEntityTypeConfiguration<ProblemType>
    {
        public void Configure(EntityTypeBuilder<ProblemType> builder)
        {
            builder.HasData(CreateProblemType());
        }

        private List<ProblemType> CreateProblemType()
        {
            var problemTypes = new List<ProblemType>()
            {
                new ProblemType()
                {
                    Id = 1,
                    Name = "Addition",
                    Instruction = "Add numbers together",
                    ProblemCategoryId = 1,
                    ImageUrl = "https://www.theschoolrun.com/sites/theschoolrun.com/files/article_images/addition.jpg"

                },
                new ProblemType()
                {
                    Id = 2,
                    Name = "Subtraction",
                    Instruction = "Take away one number from another",
                    ProblemCategoryId = 1,
                    ImageUrl = "https://www.theschoolrun.com/sites/theschoolrun.com/files/article_images/subtraction.png"
                }
                
            };

            return problemTypes;
        }


    }
}
