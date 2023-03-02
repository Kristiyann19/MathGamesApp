using MathGamesApp.Core.Contracts;
using MathGamesApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MathGamesApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProblemService problemService;

        public HomeController(IProblemService _carService)
        {
            problemService = _carService;
        }


        public async Task<IActionResult> Index()
        {
            var categories = await problemService.GetAllCategoriesAsync();

            return View(categories);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        
    }
}