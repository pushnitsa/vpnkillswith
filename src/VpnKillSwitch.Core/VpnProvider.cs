using System.Collections.Immutable;
using System.Text.RegularExpressions;

namespace VpnKillSwitch.Core;
public class VpnProvider : IVpnProvider
{
    private readonly Func<IProcess> _processFactory;

    public VpnProvider(Func<IProcess> processFactory)
    {
        _processFactory = processFactory;
    }
    public async Task<bool> ConnectAsync(string connection)
    {
        var process = _processFactory();
        await process.ExecuteAsync("cmd.exe", "/c rasdial", connection);

        return true;
    }

    public async Task<IReadOnlyCollection<string>> GetConnectionsAsync()
    {
        var process = _processFactory();
        var output = await process.ExecuteAsync("powershell.exe", "-Command Get-VpnConnection");

        var result = output.Split(Environment.NewLine).Where(x => x.StartsWith("Name"));

        result = result.Select(x => Regex.Match(x, "(Name\\s+:)(.+)").Groups[2].Value.Trim());

        return result.ToImmutableList();
    }

    public Task<bool> IsConnectedAsync()
    {
        throw new NotImplementedException();
    }
}
