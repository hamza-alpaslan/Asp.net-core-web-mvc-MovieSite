namespace CourseApp.Models
{
    public static class CategoryRepo
    {
        public static List<Category> categories = new List<Category>();
        static CategoryRepo()
        {
            categories = new List<Category>()
            {
                new Category(){Id=1,Name="Drama"},
                new Category(){Id=2,Name="Fantasy"},
                new Category(){Id=3,Name="Science Fiction"},
                new Category(){Id=4,Name="Adventure"},
                new Category(){Id=5,Name="Comedy"}
            };

        }
        public static void AddCategory(Category category)
        {
            categories.Add(category);
        }
        public static List<Category> AllCategories()
        {
            return categories;
        }
        public static Category GetById(int Id)
        {
            return categories.FirstOrDefault(c => c.Id == Id);
        }
    }
}
