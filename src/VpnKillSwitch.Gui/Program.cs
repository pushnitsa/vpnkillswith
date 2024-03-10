using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace VpnKillSwitch.Gui;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        var host = Host
            .CreateDefaultBuilder()
            .ConfigureServices(ConfigureServices)
            .Build();

        var services = host.Services;

        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(services.GetRequiredService<Form1>());
    }

    static void ConfigureServices(IServiceCollection services)
    {
        services.AddTransient<Form1>();
    }
}