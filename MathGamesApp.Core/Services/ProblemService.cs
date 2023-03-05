using MathGamesApp.Core.Contracts;
using MathGamesApp.Core.Models;
using MathGamesApp.Core.Models.Problem;
using MathGamesApp.Infrastructure.Data;
using MathGamesApp.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGamesApp.Core.Services
{
    public class ProblemService : IProblemService
    {
        private readonly ApplicationDbContext context;
        private readonly Random random;

        public ProblemService(ApplicationDbContext _context)
        {
            context = _context;
            random = new Random();
        }

        public async Task<IEnumerable<ProblemCategoryViewModel>> GetAllCategoriesAsync()
        {


            var entities = await context.ProblemCategories               
                .ToListAsync();

            return entities
                .Select(c => new ProblemCategoryViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Description = c.Description,
                    ImageUrl = c.ImageUrl
                });
        }

        public async Task<IEnumerable<ProblemTypeViewModel>> GetAllTypesByCategoryAsync(int categoryId)
        {
            var entities = await context.ProblemTypes
                .Include(c => c.ProblemCategory)
                .Where(c => c.ProblemCategory.Id == categoryId)
                .ToListAsync();

            return entities
                .Select(c => new ProblemTypeViewModel
                {
                    ProblemCategoryId = c.ProblemCategory.Id,
                    Id = c.Id,
                    ImageUrl = c.ImageUrl,
                    Instruction = c.Instruction,
                    Name = c.Name
                });
        }

        public async Task<ProblemCategoryViewModel> GetCategoryDescriptionAsync(int id)
        {
            return await context.ProblemCategories
                .Where(c => c.Id == id)
                .Select(c => new ProblemCategoryViewModel
                {
                    Id = c.Id,
                    Name= c.Name,
                    Description= c.Description,
                    ImageUrl = c.ImageUrl
                })
                .FirstAsync();
  
        }

        public async Task<ProblemViewModel> GenerateRandomAdditionProblem(ProblemViewModel model,int difficultyLevel)
        {
            int maxDigit = difficultyLevel * 2;
            int firstDigit;

            if (difficultyLevel > 5)
            {
                firstDigit = random.Next(-maxDigit, maxDigit + 1);
            }
            else
            {
                firstDigit = random.Next(0, maxDigit + 1);
            }

            int secondDigit = random.Next(0, maxDigit + 1);
            int correctAnswer = firstDigit + secondDigit;

            var problem = new ProblemViewModel
            {
                DifficultyLevel = model.DifficultyLevel,
                Description = $"What is {firstDigit} + {secondDigit}?",
                ImageUrl = "https://example.com/image.jpg",
                Instruction = "Enter the correct answer.",
                IsActive = true,
                AverageRating = 0.0,
                ProblemCategoryId = 1, // or whatever category id you want to assign
                ProblemTypeId = 1,
                CorrectAnswer = correctAnswer.ToString()
            };

            context.Problems.Add(problem);
            context.SaveChanges();

            return problem;
        }

        public async Task<ProblemTypeViewModel> GetTypeInformationAsync(int id)
        {
            return await context.ProblemTypes
               .Where(c => c.Id == id)
               .Select(c => new ProblemTypeViewModel
               {
                   Id = c.Id,
                   Name = c.Name,
                   ImageUrl = c.ImageUrl,
                   Instruction= c.Instruction,
                   
               })
               .FirstAsync();
        }
    }
}
