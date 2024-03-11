namespace VpnKillSwitch.Gui;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        comboBox1 = new ComboBox();
        button2 = new Button();
        button3 = new Button();
        SuspendLayout();
        // 
        // comboBox1
        // 
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new Point(8, 7);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(157, 23);
        comboBox1.TabIndex = 3;
        // 
        // button2
        // 
        button2.Font = new Font("Wingdings 3", 12F, FontStyle.Bold);
        button2.Location = new Point(171, 6);
        button2.Name = "button2";
        button2.Size = new Size(26, 25);
        button2.TabIndex = 4;
        button2.Text = "Q";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.Location = new Point(8, 46);
        button3.Name = "button3";
        button3.Size = new Size(75, 23);
        button3.TabIndex = 5;
        button3.Text = "Connect";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(230, 97);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(comboBox1);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(3, 2, 3, 2);
        MaximizeBox = false;
        Name = "MainForm";
        Text = "VpnKillSwitch";
        ResumeLayout(false);
    }

    #endregion
    private ComboBox comboBox1;
    private Button button2;
    private Button button3;
}
