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
        private readonly ApplicationDbContext context;

        public ProblemController(IProblemService _problemService, ApplicationDbContext _context)
        {
            problemService = _problemService;
            context = _context;
        }


        public IActionResult GetProblems(IEnumerable<AdditionProblemViewModel> problems)
        {
            var problemList = problemService.GetAdditionProblemsByLevel(problems);

            return View(problemList);
        }

        public IActionResult GenerateAdditionProblems(int difficultyLevelId)
        {
            var problems = problemService.GenerateAdditionProblemsByLevel(difficultyLevelId);

            var additionProblemViewModels = problems.Select(p => new AdditionProblemViewModel
            {
                Id = p.Id,
                Description = p.Description,
                UserAnswer = p.UserAnswer,
                Answer = p.Answer,
                DifficultyLevelId = difficultyLevelId,
                ProblemCategoryId = 1,
                ProblemTypeId = 1,
                IsCorrect = false,
                // initialize answer to null as user has not submitted anything yet
            });

            return View(additionProblemViewModels);
        }

        [HttpPost]
        
        public IActionResult CheckAnswers(IEnumerable<AdditionProblemViewModel> problems)
        {
            var problemList = problemService.GetAdditionProblemsByLevel(problems);
            bool allCorrect = problemService.CheckAdditionProblemAnswers(problemList);

            if (allCorrect)
            {
                ViewData["Message"] = "Congratulations! All your answers are correct.";
            }
            else
            {

                ViewData["Message"] = "Sorry, some of your answers are incorrect. Please try again.";
            }

            return View("CheckAnswers", problemList);
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

        public async Task<IActionResult> GetDifficultyLevels()
        {
            var levels = await problemService.GetAllDifficultyLevelsAsync();

            return View(levels);
        }

    }
}

