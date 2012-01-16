using System;
using System.Reflection;
using Funq;
using ServiceStack.Configuration;
using ServiceStack.Logging;
using ServiceStack.Logging.Support.Logging;
using ServiceStack.WebHost.Endpoints;

namespace ServiceStackTest
{
    /// <summary>
    /// Configure ServiceStack to run in stand alone mode
    /// </summary>
    public class AppHost
        : AppHostHttpListenerBase
    {

        private static string _ListenBaseUrl ="http://localhost:8080/";

        public AppHost()
            : base("Hello Web Services", typeof(HelloService).Assembly){}

        public override void Configure(Container container)
        {

            Routes.Add<Hello>("/hello").Add<Hello>("/hello/{Name}");
            try
            {
                this.Start(_ListenBaseUrl);
            }
            catch (System.Exception ex) 
            {
                Console.WriteLine("EXCEPTION: {0}", ex.Message);
            }

        }

    }
}