
using HotChocolate;
using HotChocolate.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace HotChocolateApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddGraphQLServer().AddQueryType<Query>();

            var app = builder.Build();
            app.UseRouting();
            app.UseEndpoints(endpoints => endpoints.MapGraphQL("/graphql"));

            app.Run();
        }
    }

    public class Query
    {
        public string Hello() => "Hello, GraphQL!";
    }
}
