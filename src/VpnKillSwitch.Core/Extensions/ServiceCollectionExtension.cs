using Microsoft.Extensions.DependencyInjection;

namespace VpnKillSwitch.Core.Extensions;

public static class ServiceCollectionExtension
{
    public static void AddCoreServices(this IServiceCollection services)
    {
        services.AddTransient<IVpnProvider, VpnProvider>();
    }
}
