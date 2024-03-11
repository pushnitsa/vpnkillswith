namespace VpnKillSwitch.Core;

public interface IProcess
{
    Task<string> ExecuteAsync(string command, params string[] args);
}
