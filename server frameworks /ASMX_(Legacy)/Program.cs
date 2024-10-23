
using System.Web.Services;

namespace AsmxApi
{
    [WebService(Namespace = "http://tempuri.org/")]
    public class HelloService : WebService
    {
        [WebMethod]
        public string HelloWorld() => "Hello, SOAP!";
    }
}
