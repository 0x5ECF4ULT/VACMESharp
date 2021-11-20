using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TGIT.ACME.Protocol.Services;
using VACMESharp.Service;

namespace VACMESharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddHostedService<Worker>();
                    services.AddACMEServer(hostContext.Configuration);
                    services.AddACMEFileStore(hostContext.Configuration, "AcmeServer");
                    services.AddScoped<IAccountService, CustomAccountService>();
                });
    }
}