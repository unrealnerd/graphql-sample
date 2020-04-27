using GraphQL.Types;
using GraphQL;
using api.Database;

namespace api.Graphql 
{
  public class MovieSchema: Schema
  {
    private ISchema Schema { get; set; }
    public ISchema GraphQLQuoteSchema 
    {  
      get 
      {
        return this.Schema;
      }
    }

    public MovieSchema(IDependencyResolver resolver) : base(resolver)
    {
      Query = resolver.Resolve<MovieQuery>();

      // this.Schema = GraphQL.Types.Schema.For(@"
      //     type Movie {
      //       title: String,
      //       year: String,
      //       stars: String,
      //       rating: Float,
      //       genre: String,
      //     }

      //     type Query {
      //         movies: [Movie],
      //         moviesByGenre(genre: String): [Movie],
      //     }
      // ", _ =>
      // {
      //   _.Types.Include<Query>();
      // });
    }

  }
}