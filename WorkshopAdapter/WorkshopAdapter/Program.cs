using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

var host = CreateHostBuilder(args).Build();

IHostBuilder CreateHostBuilder(string[] args)
{
    var hostBuilder = Host.CreateDefaultBuilder(args)
        .ConfigureAppConfiguration((context, builder) =>
        {
            builder.SetBasePath(Directory.GetCurrentDirectory());
        })
        .ConfigureServices((context, services) =>
        {
        });

    return hostBuilder;
}
