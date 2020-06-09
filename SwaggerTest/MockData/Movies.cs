using SwaggerTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerTest.MockData
{
    public static class Movies
    {
        private static Movie[] MovieList =
        {
            new Movie(){ Id = 1, Title = "Parasite", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Imdb = 4.3 },
            new Movie(){ Id = 2, Title = "Jumanji", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Imdb = 6 },
            new Movie(){ Id = 3, Title = "Avengers", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Imdb = 8.5 },
            new Movie(){ Id = 4, Title = "Batman The Dark Knight", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Imdb = 9.1 },
            new Movie(){ Id = 5, Title = "X-Men", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", Imdb = 6.7 }
        };

        public static IEnumerable<Movie> GetMovies()
        {
            return MovieList;
        }
    }
}
