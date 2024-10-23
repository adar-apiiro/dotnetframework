
using Nancy;
using Nancy.Hosting.Self;
using System;

namespace NancyApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var uri = "http://localhost:1234";
            var host = new NancyHost(new Uri(uri));
            host.Start();
            Console.WriteLine($"Nancy server listening at {uri}");
            Console.ReadLine();
            host.Stop();
        }
    }
}
