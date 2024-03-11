namespace VpnKillSwitch.Core;

public class Process : IProcess
{
    public async Task<string> ExecuteAsync(string command, params string[] args)
    {
        using var process = new System.Diagnostics.Process();
        process.StartInfo.FileName = $"{command}";
        process.StartInfo.Arguments = $"{string.Join(' ', args)}";
        process.StartInfo.CreateNoWindow = true;
        process.StartInfo.RedirectStandardOutput = true;
        process.StartInfo.RedirectStandardError = true;

        process.Start();

        await process.WaitForExitAsync();

        var result = await process.StandardOutput.ReadToEndAsync();

        return result;
    }
}
