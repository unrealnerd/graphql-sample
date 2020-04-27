using System.Collections.Generic;
using GraphQL;
using System.Linq;
using GraphQL.Types;
using api.Graphql;

namespace api.Database
{
    public class MovieQuery : ObjectGraphType
    {
        private readonly MovieRepository moviesRepo;
        public MovieQuery(MovieRepository repo)
        {
            moviesRepo = repo;
            
            Field<ListGraphType<MovieType>>("movies", resolve: context => GetMovies());
            
            Field<ListGraphType<MovieType>>(
                "moviesByGenre",
                arguments: new QueryArguments(
                    new QueryArgument<StringGraphType> { Name = "genre" }
                ),
                resolve: context =>
                {
                    return GetMoviesByGenre(context.GetArgument<string>("genre"));
                });
        }

        public IEnumerable<Movie> GetMovies()
        {
            return moviesRepo.GetAll();
        }


        public IEnumerable<Movie> GetMoviesByGenre(string genre)
        {
            return moviesRepo.GetAll().Where(q => q.Genre == genre);
        }
    }
}