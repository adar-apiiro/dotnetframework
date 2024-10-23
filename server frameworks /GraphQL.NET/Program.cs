
using GraphQL.Types;
using GraphQL;
using GraphQL.Server;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace GraphQLNetApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddGraphQL(options => options.EnableMetrics = false)
                            .AddSystemTextJson();

            var app = builder.Build();
            app.UseGraphQL<ISchema>("/graphql");

            app.Run();
        }
    }

    public class HelloQuery : ObjectGraphType
    {
        public HelloQuery()
        {
            Field<StringGraphType>("hello", resolve: context => "Hello, GraphQL.NET!");
        }
    }
}
