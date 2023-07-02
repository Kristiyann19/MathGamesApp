using MathGamesApp.Infrastructure.Data.Configurations;
using MathGamesApp.Infrastructure.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MathGamesApp.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        private bool seedDb;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, bool seed = true)
            : base(options)
        {
            if (Database.IsRelational())
            {
                Database.Migrate();
            }
            else
            {
                Database.EnsureCreated();
            }

            seedDb = seed;
        }

        public DbSet<Problem> Problems { get; set; }
        public DbSet<ProblemCategory> ProblemCategories { get; set; }
        public DbSet<ProblemType> ProblemTypes { get; set; }
       
        public DbSet<DifficultyLevel> DifficultyLevels { get; set; }
        public DbSet<AdditionProblem> AdditionProblems { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder
                .Entity<DifficultyLevel>()
                .HasOne(d => d.ProblemType)
                .WithMany(p => p.DifficultyLevels)
                .HasForeignKey(d => d.ProblemTypeId)
                .OnDelete(DeleteBehavior.Restrict);


            builder
                .Entity<ProblemType>()
                .HasOne(x => x.ProblemCategory)
                .WithMany()
                .HasForeignKey(x => x.ProblemCategoryId)
                .OnDelete(DeleteBehavior.Restrict);


            if (seedDb)
            {
                builder.ApplyConfiguration(new ProblemCategoryConfiguration());
                builder.ApplyConfiguration(new ProblemTypeConfiguration());
                builder.ApplyConfiguration(new DifficultyLevelConfiguration());
                //builder.ApplyConfiguration(new ProblemConfiguration());
                
            }

            base.OnModelCreating(builder);
        }

    }
}