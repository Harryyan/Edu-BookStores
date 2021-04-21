using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace BookStoresBackend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        // config web server
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder
                        .ConfigureAppConfiguration((hostingContext, config) =>
                        {
                            config.SetBasePath(hostingContext.HostingEnvironment.ContentRootPath);
                            config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                            config.AddEnvironmentVariables();
                        })
                        .UseStartup<Startup>();
                });
    }
}
