using api.Database;
using GraphQL.Types;

namespace api.Graphql
{
    public class MovieType : ObjectGraphType<Movie>
    {
        public MovieType()
        {
            Field(m => m.Title);
            Field(m => m.Rating);
            Field(m => m.Genre);
            Field(m => m.Stars);
            Field(m => m.Year);
        }

    }
}
