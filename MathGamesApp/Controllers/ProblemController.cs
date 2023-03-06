using MathGamesApp.Core.Contracts;
using MathGamesApp.Core.Models.Problem;
using MathGamesApp.Infrastructure.Data;
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

        public IActionResult GenerateProblem(int difficultyLevelId)
        {
            var difficultyLevel = context.DifficultyLevels.SingleOrDefault(dl => dl.Id == difficultyLevelId);

            if (difficultyLevel == null)
            {
                return NotFound();
            }


            var problems = problemService.GenerateProblemsByLevel(difficultyLevel.Id)
                .Select(p => new ProblemViewModel
                {
                    Description = p.Description,
                    Answer = p.Answer,
                    DifficultyLevelId = p.DifficultyLevelId
                });
            return View(problems);
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


        //public IActionResult GetRandomAdditionProblem(int difficultyLevel)
        //{
        //    var problem = problemService.GetRandomAdditionProblem(difficultyLevel);

        //    return View(problem);
        //}


        //[HttpPost]
        //public IActionResult RandomAdditionProblem(string answer)
        //{
        //    int userAnswer;
        //    bool isNumeric = int.TryParse(answer, out userAnswer);

        //    if (!isNumeric)
        //    {
        //        ViewBag.Result = "Please enter a valid number.";
        //    }
        //    else if (problemService.CheckAnswer(ViewBag.Problem, userAnswer))
        //    {
        //        ViewBag.Result = "Correct!";
        //    }
        //    else
        //    {
        //        ViewBag.Result = "Incorrect. Please try again.";
        //    }

        //    return View();
        //}
    }
}

