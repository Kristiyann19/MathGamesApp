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
    }
}
