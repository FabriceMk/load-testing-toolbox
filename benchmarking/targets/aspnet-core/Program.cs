using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace AspNetCoreTarget
{
    /// <summary>
    /// Bootstrap class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry point of the application.
        /// </summary>
        /// <param name="args">Application arguments.</param>
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Creates the host for the application.
        /// </summary>
        /// <param name="args">Application arguments.</param>
        /// <returns>A Host builder.</returns>
        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            var hostBuilder = Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>()
                    .ConfigureKestrel((context, options) =>
                        {
                            // Set properties and call methods on options
                        });
                });

            return hostBuilder;
        }
    }
}
