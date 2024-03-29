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

    private async void button2_Click(object sender, EventArgs e)
    {
        var connections = await _vpnProvider.GetConnectionsAsync();
        comboBox1.Items.AddRange(connections.ToArray());
    }

    private async void button3_Click(object sender, EventArgs e)
    {
        var connection = comboBox1.Text;

        await _vpnProvider.ConnectAsync(connection);
    }
}
