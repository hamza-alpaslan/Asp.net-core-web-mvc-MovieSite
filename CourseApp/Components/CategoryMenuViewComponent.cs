using Microsoft.AspNetCore.Mvc;
using CourseApp.Models;
namespace CourseApp.Components
{
    public class CategoryMenuViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(CategoryRepo.AllCategories());
        }
    }
}
