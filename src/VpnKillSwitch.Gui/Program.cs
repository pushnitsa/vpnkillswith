using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using VpnKillSwitch.Core.Extensions;
using VpnKillSwitch.Gui;

Thread.CurrentThread.SetApartmentState(ApartmentState.Unknown);
Thread.CurrentThread.SetApartmentState(ApartmentState.STA);

var host = Host
    .CreateDefaultBuilder()
    .ConfigureServices(ConfigureServices)
    .Build();

var services = host.Services;

ApplicationConfiguration.Initialize();
Application.Run(services.GetRequiredService<MainForm>());

static void ConfigureServices(IServiceCollection services)
{
    services.AddTransient<MainForm>();
    services.AddCoreServices();
}
