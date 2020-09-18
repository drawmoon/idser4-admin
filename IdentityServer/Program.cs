using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer.EntityFramework.Entities;
using IdentityServer.EntityFramework.Shared.DbContexts;
using IdentityServer.EntityFramework.Shared.Entities.Identity;
using IdentityServer.Helpers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace IdentityServer
{
    public class Program
    {
        private const string SeedArgs = "/seed";

        public static async Task Main(string[] args)
        {
            var seed = args.Any(x => x == SeedArgs);
            if (seed) args = args.Except(new[] { SeedArgs }).ToArray();

            var host = CreateHostBuilder(args).Build();

            // Uncomment this to seed upon startup, alternatively pass in `dotnet run /seed` to seed using CLI
            await DbMigrationHelpers.EnsureSeedData<IdentityServerConfigurationDbContext, AdminIdentityDbContext, IdentityServerPersistedGrantDbContext, AdminLogDbContext, AdminAuditLogDbContext, UserIdentity, UserIdentityRole>(host);
            if (seed)
            {
                await DbMigrationHelpers
                    .EnsureSeedData<IdentityServerConfigurationDbContext, AdminIdentityDbContext,
                        IdentityServerPersistedGrantDbContext, AdminLogDbContext, AdminAuditLogDbContext,
                        UserIdentity, UserIdentityRole>(host);
            }

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                 .ConfigureAppConfiguration((hostContext, configApp) =>
                 {
                     configApp.AddJsonFile("identitydata.json", optional: true, reloadOnChange: true);
                     configApp.AddJsonFile("identityserverdata.json", optional: true, reloadOnChange: true);

                     if (hostContext.HostingEnvironment.IsDevelopment())
                     {
                         configApp.AddUserSecrets<Startup>();
                     }

                     configApp.AddEnvironmentVariables();
                     configApp.AddCommandLine(args);
                 })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.ConfigureKestrel(options => options.AddServerHeader = false);
                    webBuilder.UseStartup<Startup>();
                });
    }
}
