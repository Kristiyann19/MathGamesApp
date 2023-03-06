﻿using MathGamesApp.Core.Contracts;
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


        public ProblemService(ApplicationDbContext _context)
        {
            context = _context;

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
                    Name = c.Name,
                    Description = c.Description,
                    ImageUrl = c.ImageUrl
                })
                .FirstAsync();

        }

        //public ProblemViewModel GetRandomAdditionProblem(int difficultyLevel)
        //{
        //    //int maxDigit = difficultyLevel * 2;
        //    //int firstDigit;

        //    //if (difficultyLevel > 5)
        //    //{
        //    //    firstDigit = random.Next(-maxDigit, maxDigit + 1);
        //    //}
        //    //else
        //    //{
        //    //    firstDigit = random.Next(maxDigit + 1);
        //    //}

        //    //int secondDigit = random.Next(maxDigit + 1);
        //    //int correctAnswer = firstDigit + secondDigit;

        //    //var problem = new ProblemViewModel()
        //    //{
        //    //    CorrectAnswer = correctAnswer.ToString(),
        //    //    DifficultyLevel = difficultyLevel,
        //    //    Description = $"What is {firstDigit} + {secondDigit}",
        //    //    Instruction = "Enter the correct answer.",
        //    //    IsActive = true
        //    //};

        //    //return problem;

        //}

        //public bool CheckAnswer(ProblemViewModel problem, int answer)
        //{
        //    int correctAnswer = int.Parse(problem.CorrectAnswer);
        //    return answer == correctAnswer;
        //}


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

        public async Task<IEnumerable<DifficultyLevelsViewModel>> GetAllDifficultyLevelsAsync()
        {
            var entities = await context.DifficultyLevels.ToListAsync();

            return entities
                .Select(e => new DifficultyLevelsViewModel
                {
                    Id = e.Id,
                    Name = e.Name
                });
        }
    }
}
