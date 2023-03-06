using MathGamesApp.Core.Models;
using MathGamesApp.Core.Models.Problem;
using MathGamesApp.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGamesApp.Core.Contracts
{
    public interface IProblemService
    {
        Task<IEnumerable<ProblemCategoryViewModel>> GetAllCategoriesAsync();

        Task<ProblemCategoryViewModel> GetCategoryDescriptionAsync(int id);

        Task<ProblemTypeViewModel> GetTypeInformationAsync(int id);

        Task<IEnumerable<ProblemTypeViewModel>> GetAllTypesByCategoryAsync(int categoryId);

        Task<IEnumerable<DifficultyLevelsViewModel>> GetAllDifficultyLevelsAsync();

        List<Problem> GenerateProblemsByLevel(int difficultyLevel);
    }
}
