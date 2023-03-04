using MathGamesApp.Core.Contracts;
using MathGamesApp.Core.Models;
using MathGamesApp.Infrastructure.Data;
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
                    Name= c.Name,
                    Description= c.Description,
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
                   Instruction= c.Instruction,
                   
               })
               .FirstAsync();
        }
    }
}
