using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace standalone
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .ConfigureLogging(options => 
                {
                    options.AddConsole(LogLevel.Debug);
                })
                .UseKestrel()
                .UseDefaultHostingConfiguration(args)
                .UseEnvironment("Development")
                .UseIISIntegration()
                .ConfigureServices(services =>
                {
                    services.AddMvc();
                })
                .Configure(app =>
                {
                    app.UseDeveloperExceptionPage();
                    app.UseStaticFiles();
                    app.UseMvcWithDefaultRoute();
                }).Build();
                host.Run();  
        }
    }
}