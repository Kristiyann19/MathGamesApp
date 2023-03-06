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
                   

                }
            };

            return problems;
        }
    }
}
