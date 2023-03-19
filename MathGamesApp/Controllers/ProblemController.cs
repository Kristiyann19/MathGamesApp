using MathGamesApp.Core.Contracts;
using MathGamesApp.Core.Models.Problem;
using MathGamesApp.Infrastructure.Data;
using MathGamesApp.Infrastructure.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MathGamesApp.Controllers
{
    public class ProblemController : Controller
    {
        private readonly IProblemService problemService;  

        public ProblemController(IProblemService _problemService)
        {
            problemService = _problemService;
        }


        public IActionResult AdditionProblems(int difficultyLevelId, int problemTypeId)
        {
            var problems = problemService.GenerateAdditionProblemsByLevel(difficultyLevelId, problemTypeId);

            var additionProblemViewModels = problems.Select(p => new AdditionProblemViewModel
            {
                Id = p.Id,
                Description = p.Description,
                UserAnswer = p.UserAnswer,
                Answer = p.Answer,
                DifficultyLevelId = difficultyLevelId,
                ProblemCategoryId = 1,
                ProblemTypeId = problemTypeId,
                IsCorrect = false,

            });

            return View(additionProblemViewModels);
        }


        public IActionResult SubtractionProblems(int difficultyLevelId, int problemTypeId)
        {
            var subProblems = problemService.GenerateSubtractionProblemsByLevel(difficultyLevelId, problemTypeId);

            var subtractionProblemViewModels = subProblems.Select(sp => new SubtractionProblemViewModel
            {
                Id = sp.Id,
                Description = sp.Description,
                UserAnswer = sp.UserAnswer,
                Answer = sp.Answer,
                DifficultyLevelId = difficultyLevelId,
                ProblemCategoryId = 1,
                ProblemTypeId = problemTypeId, 
                IsCorrect = false,
            });

            return View(subtractionProblemViewModels);
        }

        [HttpPost]       
        public IActionResult CheckAnswersAddition(IEnumerable<AdditionProblemViewModel> problems)
        {
            
            bool allCorrect = problemService.CheckAdditionProblemAnswers(problems);

            if (allCorrect)
            {
                ViewData["Message"] = "Congratulations! All your answers are correct.";
            }
            else
            {

                ViewData["Message"] = "Sorry, some of your answers are incorrect. Please try again.";
            }

            return View("CheckAnswersAddition", problems);
        }


        [HttpPost]
        public IActionResult CheckAnswersSubtraction(IEnumerable<SubtractionProblemViewModel> subProblems)
        {

            bool allCorrect = problemService.CheckSubtractionProblemAnswers(subProblems);

            if (allCorrect)
            {
                ViewData["Message"] = "Congratulations! All your answers are correct.";
            }
            else
            {

                ViewData["Message"] = "Sorry, some of your answers are incorrect. Please try again.";
            }

            return View("CheckAnswersSubtraction", subProblems);
        }


        public async Task<IActionResult> Description(int id)
        {
            
            var categoryModel = await problemService.GetCategoryDescriptionAsync(id);

            return View(categoryModel);
        }

        public async Task<IActionResult> Information(int id)
        {

            var typeModel = await problemService.GetTypeInformationAsync(id);

            return View(typeModel);
        }

        [HttpGet]
        [HttpPost]
        public async Task<IActionResult> GetProblemType(int categoryId)
        {
            var types = await problemService.GetAllTypesByCategoryAsync(categoryId);

            return View(types);
        }

        public IActionResult SubtractionDifficultyLevels()
        {
            var difficultyLevels = problemService.GetDifficultyLevelsByProblemType(2);

            var difficultyLevelViewModels = difficultyLevels.Select(d => new DifficultyLevelsViewModel
            {
                Id = d.Id,
                Name = d.Name,
                ProblemTypeId = 2
            });

            return View(difficultyLevelViewModels);
        }

        public IActionResult AdditionDifficultyLevels()
        {
            var difficultyLevels = problemService.GetDifficultyLevelsByProblemType(1);

            var difficultyLevelViewModels = difficultyLevels.Select(d => new DifficultyLevelsViewModel
            {
                Id = d.Id,
                Name = d.Name,
                ProblemTypeId = 1
            });

            return View(difficultyLevelViewModels);
        }

    }
}

