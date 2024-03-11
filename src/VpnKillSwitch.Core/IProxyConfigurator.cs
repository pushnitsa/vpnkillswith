namespace VpnKillSwitch.Core;

public interface IProxyConfigurator
{
    void SetPort(int port);
    void SetAsDefault(bool isDefault);
    void Start();
    void Stop();
    bool IsRunning();
}
