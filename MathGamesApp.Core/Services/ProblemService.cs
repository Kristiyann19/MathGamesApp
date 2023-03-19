using MathGamesApp.Core.Contracts;
using MathGamesApp.Core.Models;
using MathGamesApp.Core.Models.Problem;
using MathGamesApp.Infrastructure.Data;
using MathGamesApp.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGamesApp.Core.Services
{
    public class ProblemService : IProblemService
    {
        private readonly ApplicationDbContext context;

        public ProblemService(ApplicationDbContext _context)
        {
            context = _context;
        }

        private readonly Random random = new Random();

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
                    Name = c.Name,
                    Description = c.Description,
                    ImageUrl = c.ImageUrl
                })
                .FirstAsync();

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
                   Instruction = c.Instruction,


               })
               .FirstAsync();
        }

        public async Task<IEnumerable<DifficultyLevelsViewModel>> GetAllDifficultyLevelsAsync(int problemTypeId)
        {
            var entities = await context.DifficultyLevels
                .ToListAsync();

            return entities
                .Select(e => new DifficultyLevelsViewModel
                {
                    Id = e.Id,
                    Name = e.Name,
                    ProblemTypeId = problemTypeId
                });
        }
        

        public IEnumerable<DifficultyLevel> GetDifficultyLevelsByProblemType(int problemTypeId)
        {
            return context.DifficultyLevels
                .Where(dl => dl.ProblemTypeId == problemTypeId)
                .ToList();
        }


        public IEnumerable<SubtractionProblemViewModel> GenerateSubtractionProblemsByLevel(int difficultyLevelId, int problemTypeId)
        {
            var random = new Random();
            var subProblems = new List<SubtractionProblemViewModel>();
            int id = 0;

            for (int i = 0; i < 10; i++)
            {
                int num1 = 0;
                int num2 = 0;
                int answer;


                if (difficultyLevelId == 8)
                {
                    num1 = random.Next(1, 10);
                    num2 = random.Next(1, 10);
                }
                else if (difficultyLevelId == 9)
                {
                    num1 = random.Next(1, 100);
                    num2 = random.Next(1, 100);
                }
                else if (difficultyLevelId == 10)
                {
                    num1 = random.Next(10, 150);
                    num2 = random.Next(10, 150);
                }
                else if (difficultyLevelId == 11)
                {
                    num1 = random.Next(100, 1000);
                    num2 = random.Next(100, 1000);
                }
                else if (difficultyLevelId == 12)
                {
                    num1 = random.Next(-100, 100);
                    num2 = random.Next(10, 100);
                }
                else if (difficultyLevelId == 13)
                {
                    num1 = random.Next(-500, 200);
                    num2 = random.Next(-50, 500);
                }
                else if (difficultyLevelId == 14)
                {
                    num1 = random.Next(-1000, 1000);
                    num2 = random.Next(-1000, -1);
                }


                answer = num1 - num2;

                var subProblem = new SubtractionProblemViewModel()
                {
                    Id = id,
                    Description = $"What is the subtraction between {num1} and {num2}",
                    DifficultyLevelId = difficultyLevelId,
                    Answer = answer,
                    UserAnswer = null,
                    IsCorrect = false,
                    ProblemTypeId = problemTypeId,
                    ProblemCategoryId = 1,
                    Instruction = "smth"

                };

                subProblems.Add(subProblem);
                id++;
            }
            return subProblems;
        }

        public bool CheckSubtractionProblemAnswers(IEnumerable<SubtractionProblemViewModel> subProblems)
        {
            if (subProblems == null)
            {
                throw new ArgumentNullException(nameof(subProblems));
            }

            bool allCorrect = true;

            foreach (var subProblem in subProblems)
            {
                subProblem.IsCorrect = subProblem.Answer == subProblem.UserAnswer;


                if (!subProblem.IsCorrect)
                {
                    allCorrect = false;
                }
            }

            return allCorrect;
        }


        public IEnumerable<AdditionProblemViewModel> GenerateAdditionProblemsByLevel(int difficultyLevelId, int problemTypeId)
        {
          

            var random = new Random();
            var problems = new List<AdditionProblemViewModel>();
            int id = 0;

            for (int i = 0; i < 10; i++)
            {
                int num1 = 0;
                int num2 = 0;
                int answer;
                

                if (difficultyLevelId == 1)
                {
                    num1 = random.Next(1, 10);
                    num2 = random.Next(1, 10);
                }
                else if (difficultyLevelId == 2)
                {
                    num1 = random.Next(1, 100);
                    num2 = random.Next(1, 100);
                }
                else if (difficultyLevelId == 3)
                {
                    num1 = random.Next(10, 150);
                    num2 = random.Next(10, 150);
                }
                else if (difficultyLevelId == 4)
                {
                    num1 = random.Next(100, 1000);
                    num2 = random.Next(100, 1000);
                }
                else if (difficultyLevelId == 5)
                {
                    num1 = random.Next(-100, 100);
                    num2 = random.Next(10, 100);
                }
                else if (difficultyLevelId == 6)
                {
                    num1 = random.Next(-500, 200);
                    num2 = random.Next(-50, 500);
                }
                else if (difficultyLevelId == 7)
                {
                    num1 = random.Next(-1000, 1000);
                    num2 = random.Next(-1000, -1);
                }

                
                answer = num1 + num2;

                var problem = new AdditionProblemViewModel()
                {
                    Id = id,
                    Description = $"What is the sum between {num1} and {num2}",
                    DifficultyLevelId = difficultyLevelId,
                    Answer = answer,
                    UserAnswer = null,
                    IsCorrect = false,
                    ProblemTypeId = problemTypeId,
                    ProblemCategoryId = 1,
                    Instruction = "smth"
                    
                };  

                problems.Add(problem);
                id++;
            }
            return problems;
        }


        public bool CheckAdditionProblemAnswers(IEnumerable<AdditionProblemViewModel> problems)
        {
            if (problems == null)
            {
                throw new ArgumentNullException(nameof(problems));
            }

            bool allCorrect = true;

            foreach (var problem in problems)
            {
                problem.IsCorrect = problem.Answer == problem.UserAnswer;
                

                if (!problem.IsCorrect)
                {
                    allCorrect = false;
                }
            }

            return allCorrect;
        }

        

    }
}
