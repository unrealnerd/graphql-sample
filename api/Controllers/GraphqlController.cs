using System.Threading.Tasks;
using api.Graphql;
using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Mvc;

namespace api.Database.Controllers
{
    [Route("/graphql")]
    [ApiController]
    public class GraphqlController : ControllerBase
    {
        readonly ISchema schema;
        public GraphqlController(ISchema schema)
        {
            this.schema = schema;
        }

        // [HttpPost]
        // public async Task<ActionResult> Post([FromBody] GraphQLQuery query)
        // {
        //     var inputs = query.Variables.ToInputs();

        //     var result = await new DocumentExecuter().ExecuteAsync(_ =>
        //     {
        //         _.Schema = schema.GraphQLQuoteSchema;
        //         _.Query = query.Query;
        //         _.OperationName = query.OperationName;
        //         _.Inputs = inputs;
        //     });

        //     if (result.Errors?.Count > 0)
        //     {
        //         return BadRequest();
        //     }

        //     return Ok(result.Data);
        // }
    }
}