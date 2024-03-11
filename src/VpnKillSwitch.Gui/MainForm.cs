using VpnKillSwitch.Core;

namespace VpnKillSwitch.Gui;

public partial class MainForm : Form
{
    private readonly IVpnProvider _vpnProvider;

    public MainForm(IVpnProvider vpnProvider)
    {
        InitializeComponent();
        _vpnProvider = vpnProvider;
    }

    private void button1_Click(object sender, EventArgs e)
    {

    }

    private async void button2_Click(object sender, EventArgs e)
    {
        var connections = await _vpnProvider.GetConnectionsAsync();
        comboBox1.Items.AddRange(connections.ToArray());
    }
}
