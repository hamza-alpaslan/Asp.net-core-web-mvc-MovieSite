
using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CourseApp.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index(int? Id)
		{
			if (Id == null)
			{
                return View(Repo.Movies);
            }
			else
			{
				int a;

                List<Movie> movies = new List<Movie>();
				foreach (var j in Repo.Movies) {
					a =j.CategoriesId.FirstOrDefault(m => m == Id);
                        if (a!=0)
						{
							movies.Add(j);
						}
					
					
				}
                return View(movies);
            }
			
		}
		public IActionResult Contact()
		{
			return View();
		}
		public IActionResult Details(int id)
		{
			string cat="";
			Movie movie = new Movie();
			movie=Repo.GetMovieById(id);
			List<Category> categories = new List<Category>();
			categories=CategoryRepo.AllCategories();
			foreach(var i in categories)
			{
				if(movie.CategoriesId.FirstOrDefault(m=>m==i.Id)!=0)
				{
					if(cat == "")
					{
						cat = i.Name;

					}
					else
					{
						cat = cat + ", " + i.Name;
					}

				}
			}
			ViewBag.Cat = cat;
            return View(movie);
		}
	}
}
