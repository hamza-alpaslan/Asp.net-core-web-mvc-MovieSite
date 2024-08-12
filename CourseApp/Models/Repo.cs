namespace CourseApp.Models
{
    public static class Repo
    {
        public static List<Movie> Movies=new List<Movie>();
        static Repo()
        {
            Movies = new List<Movie>() { 
                new Movie(){Id=0,Name="God father",Description="Don Vito Corleone, head of a mafia family, decides to hand over his empire to his youngest son, Michael. However, his decision unintentionally puts the lives of his loved ones in grave danger.",ImgURL="godfather.jpg",CategoriesId=new List<int>{1} },
                new Movie(){Id=1,Name="Lord of the rings", Description="A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.",ImgURL="lotr.jpg", CategoriesId =new List<int> {1,2,4 }},
                new Movie(){Id=2,Name="The martain",Description="An astronaut becomes stranded on Mars after his team assume him dead, and must rely on his ingenuity to find a way to signal to Earth that he is alive and can survive until a potential rescue.",ImgURL="martain.jpg",CategoriesId=new List<int>{3,4}},
                new Movie(){Id=3,Name="Pulp fiction",Description="The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",ImgURL="pulpfiction.jpg", CategoriesId = new List<int>{1}},
                new Movie(){Id=4,Name="Matrix",Description="When a beautiful stranger leads computer hacker Neo to a forbidding underworld, he discovers the shocking truth--the life he knows is the elaborate deception of an evil cyber-intelligence.",ImgURL="matrix.jpg", CategoriesId =new List<int> {3,4 }}
            
            };
        }
        public static List<Movie> GetMovies()
        {
            return Movies;
        }

        public static void AddMovie(Movie movie)
        {
            Movies.Add(movie);
        }
        public static Movie GetMovieById(int id)
        {
            Movie sendmovie = new Movie();
            sendmovie= Movies.FirstOrDefault(i => i.Id == id);
            return sendmovie;
        }
        public static void Delete_movie_by_id(int id)
        {
            Movie delete_movie=new Movie();
            foreach(Movie movie in Movies)
            {
                if(movie.Id == id)
                {
                    delete_movie=movie;
                }
            }
            Movies.Remove(delete_movie);
        }

    }
}
