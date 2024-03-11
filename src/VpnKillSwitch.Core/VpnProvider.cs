using System.Collections.Immutable;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace VpnKillSwitch.Core;
public class VpnProvider : IVpnProvider
{
    public async Task<bool> ConnectAsync(string connection)
    {
        using var process = new Process();
        process.StartInfo.FileName = "cmd.exe";
        process.StartInfo.Arguments = $"/c rasdial \"{connection}\"";
        process.StartInfo.CreateNoWindow = true;
        process.StartInfo.RedirectStandardOutput = true;
        process.StartInfo.RedirectStandardError = true;

        process.Start();

        await process.WaitForExitAsync();

        var result = await process.StandardOutput.ReadToEndAsync();

        return true;
    }

    public async Task<IReadOnlyCollection<string>> GetConnectionsAsync()
    {
        using var process = new Process();
        process.StartInfo.FileName = "powershell.exe";
        process.StartInfo.Arguments = "-Command Get-VpnConnection";
        process.StartInfo.CreateNoWindow = true;
        process.StartInfo.RedirectStandardOutput = true;
        process.StartInfo.RedirectStandardError = true;

        process.Start();

        await process.WaitForExitAsync();

        var output = await process.StandardOutput.ReadToEndAsync();
        var error = await process.StandardError.ReadToEndAsync();
        var exitCode = process.ExitCode;

        var result = output.Trim().Split(Environment.NewLine).Select(x => x.Trim()).Where(x => x.StartsWith("Name"));

        result = result.Select(x => Regex.Match(x, "(Name\\s+:)(.+)").Groups[2].Value.Trim());

        return result.ToImmutableList();
    }

    public Task<bool> IsConnectedAsync()
    {
        throw new NotImplementedException();
    }
}
