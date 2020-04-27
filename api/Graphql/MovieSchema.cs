using GraphQL.Types;
using GraphQL;
using api.Database;

namespace api.Graphql 
{
  public class MovieSchema: Schema
  {
    public MovieSchema(IDependencyResolver resolver) : base(resolver)
    {
      Query = resolver.Resolve<MovieQuery>();      
    }

  }
}