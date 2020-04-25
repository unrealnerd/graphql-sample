using System.Collections.Generic;
using GraphQL;
using System.Linq;

namespace api.Database
{
    public class Query
    {
        static readonly Movie[] movies = new Movie[]{
                new Movie
                {
                    Title = "The Shawshank Redemption",
                    Year = "1994",
                    Stars = "Tim Robbins, Morgan Freeman, Bob Gunton",
                    Rating = 9.3F,
                    Genre = "Drama"
                },
                new Movie
                {
                    Title = "The Godfather",
                    Year = "1972",
                    Stars = "Marlon Brando, Al Pacino, James Caan",
                    Rating = 9.2F,
                    Genre = "Crime, Drama"
                },
                new Movie
                {
                    Title = "The Dark Knight",
                    Year = "2008",
                    Stars = "Christian Bale, Heath Ledger, Aaron Eckhart",
                    Rating = 9.0F,
                    Genre = "Action, Crime, Drama"
                },
                new Movie
                {
                    Title = "12 Angry Men",
                    Year = "1957",
                    Stars = "Henry Fonda, Lee J. Cobb, Martin Balsam",
                    Rating = 8.9F,
                    Genre = "Drama"
                },
                new Movie
                {
                    Title = "Schindler's List",
                    Year = "1993",
                    Stars = "Liam Neeson, Ralph Fiennes, Ben Kingsley",
                    Rating = 8.9F,
                    Genre = "Drama"
                },
            };

        [GraphQLMetadata("movies")]
        public IEnumerable<Movie> GetMovies()
        {
            return movies;
        }


        [GraphQLMetadata("moviesByGenre")]
        public IEnumerable<Movie> GetQuoteByRegion(string genre)
        {
            return movies.Where(q => q.Genre == genre);
        }
    }
}