namespace VpnKillSwitch.Core;

public interface IVpnProvider
{
    Task<IReadOnlyCollection<string>> GetConnectionsAsync();
    Task<bool> ConnectAsync(string connection);
    Task<bool> IsConnectedAsync();
}
