namespace CourseApp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImgURL { get; set; }
        public List<int> CategoriesId { get; set; }
    }
}
