using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TGIT.ACME.Protocol.IssuanceServices;
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
                .ConfigureWebHostDefaults(builder =>
                {
                    builder.ConfigureServices((hostContext, services) =>
                    {
                        services.AddHostedService<Worker>();
                        services.AddACMEServer(hostContext.Configuration);
                        services.AddACMEFileStore(hostContext.Configuration, "AcmeServer");
                        services.AddScoped<ICertificateIssuer, VaultCertificateIssuer>();
                        //services.AddScoped<IAccountService, CustomAccountService>();
                    });
                    
                    builder.Configure(app =>
                    {
                        app.UseRouting();
                        
                        app.UseAcmeServer();
                        
                        app.UseEndpoints(endpoints => endpoints.MapControllers());
                    });
                });
    }
}