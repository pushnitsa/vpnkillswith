using System.Diagnostics;

namespace VpnKillSwitch.Gui;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
    }

    private async void button2_Click(object sender, EventArgs e)
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

    }
}
