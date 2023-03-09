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


        public IActionResult GenerateAdditionProblems(int difficultyLevelId)
        {
            var problems = problemService.GenerateAdditionProblemsByLevel(difficultyLevelId);

            var additionProblemViewModels = problems.Select(p => new AdditionProblemViewModel
            {
                Id = p.Id,
                Description = p.Description,
                UserAnswer = p.UserAnswer
                // initialize answer to null as user has not submitted anything yet
            });

            return View(additionProblemViewModels);
        }

        [HttpPost]
        public IActionResult CheckAnswers(IEnumerable<AdditionProblemViewModel> problems)
        {
            var allCorrect = problemService.CheckAdditionProblemAnswers(problems);

            if (allCorrect)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("GenerateAdditionProblems", new { difficultyLevelId = problems.First().DifficultyLevelId });
            }
        }

        //public IActionResult GenerateProblem(int difficultyLevelId, int problemTypeId)
        //{
        //    var difficultyLevel = context.DifficultyLevels.SingleOrDefault(dl => dl.Id == difficultyLevelId);
        //    var problemType = context.ProblemTypes.SingleOrDefault(p => p.Id == problemTypeId);

        //    if (difficultyLevel == null)
        //    {
        //        return NotFound();
        //    }


        //    var problems = problemService.GenerateProblemsByLevel(difficultyLevel.Id)
        //        .Select(p => new ProblemViewModel
        //        {
        //            Id = p.Id,
        //            Description = p.Description,
        //            Answer = p.Answer,
        //            DifficultyLevelId = p.DifficultyLevelId,

        //        });

        //    return View(problems);
        //}


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


        //[HttpPost]
        //public ActionResult CheckAnswers(List<Problem> problems, List<int> answers)
        //{
        //    List<bool> results = problemService.CheckAnswers(problems, answers);
        //    ViewBag.Results = results;

        //    return View();
        //}

       
    }
}

