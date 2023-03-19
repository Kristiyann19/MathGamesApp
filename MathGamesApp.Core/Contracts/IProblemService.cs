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

        Task<IEnumerable<DifficultyLevelsViewModel>> GetAllDifficultyLevelsAsync(int problemTypeId);

        IEnumerable<AdditionProblemViewModel> GenerateAdditionProblemsByLevel(int difficultyLevelId, int problemTypeId);

        IEnumerable<SubtractionProblemViewModel> GenerateSubtractionProblemsByLevel(int difficultyLevelId, int problemTypeId);

        bool CheckSubtractionProblemAnswers(IEnumerable<SubtractionProblemViewModel> subProblems);

        bool CheckAdditionProblemAnswers(IEnumerable<AdditionProblemViewModel> problems);

        IEnumerable<DifficultyLevel> GetDifficultyLevelsByProblemType(int problemTypeId);

    }
}   
