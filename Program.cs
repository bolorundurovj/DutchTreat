using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace DutchTreat
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*What this means to me, it that when the Console program is run,
             * and  calls the main method, it creates a host, builds, then runs the app */
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
        //This calls the startup class to setup the webhost builder
    }
}
