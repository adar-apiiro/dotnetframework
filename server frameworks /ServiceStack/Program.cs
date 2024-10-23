
using ServiceStack;

namespace ServiceStackApi
{
    public class HelloService : Service
    {
        public object Any(Hello request) => new HelloResponse { Result = $"Hello, {request.Name}!" };
    }

    public class Hello
    {
        public string Name { get; set; }
    }

    public class HelloResponse
    {
        public string Result { get; set; }
    }
}
