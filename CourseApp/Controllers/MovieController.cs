using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
	public class MovieController : Controller
	{
		public IActionResult Index()
		{
			return View(Repo.Movies);
		}
        [HttpPost]
        public IActionResult Index(string submitButton)
        {
			
            Repo.Delete_movie_by_id(Convert.ToInt32(submitButton));
            return View(Repo.Movies);
        }
        public IActionResult Create()
		{
			return View();
		}
		public IActionResult List()
		{
			return View();
		}
		public IActionResult Details()
		{
			return View();
		}
	}
}
