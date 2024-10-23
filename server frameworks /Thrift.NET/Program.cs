
using Thrift.Server;
using Thrift.Transport;
using System;

namespace ThriftApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var server = new TSimpleServer(new MyProcessor(), new TServerSocket(9090));
            Console.WriteLine("Thrift server listening on port 9090");
            server.Serve();
        }
    }
}
