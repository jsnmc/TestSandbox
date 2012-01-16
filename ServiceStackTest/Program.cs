using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ServiceStackTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var appHost = new AppHost();
            appHost.Init();

            Thread.Sleep(Timeout.Infinite);
            System.Console.WriteLine("ReadLine()");
            System.Console.ReadLine();
        }
    }

    public class Hello
    {
        public string Name { get; set; }
    }

    public class HelloResponse
    {
        public string Result { get; set; }
    }

    public class HelloService : ServiceStack.ServiceHost.IService<Hello>
    {
        public object Execute(Hello request)
        {
            return new HelloResponse { Result = "Hello, " + request.Name };
        }
    }
}
