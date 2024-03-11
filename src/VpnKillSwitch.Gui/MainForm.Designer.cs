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
        button1 = new Button();
        groupBox1 = new GroupBox();
        label1 = new Label();
        checkBox1 = new CheckBox();
        comboBox1 = new ComboBox();
        button2 = new Button();
        button3 = new Button();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new Point(5, 20);
        button1.Margin = new Padding(3, 2, 3, 2);
        button1.Name = "button1";
        button1.Size = new Size(82, 22);
        button1.TabIndex = 1;
        button1.Text = "Start";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(label1);
        groupBox1.Controls.Add(checkBox1);
        groupBox1.Controls.Add(button1);
        groupBox1.Location = new Point(10, 9);
        groupBox1.Margin = new Padding(3, 2, 3, 2);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(3, 2, 3, 2);
        groupBox1.Size = new Size(219, 94);
        groupBox1.TabIndex = 2;
        groupBox1.TabStop = false;
        groupBox1.Text = "Proxy server";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(3, 75);
        label1.Name = "label1";
        label1.Size = new Size(89, 15);
        label1.TabIndex = 3;
        label1.Text = "Status: Stopped";
        // 
        // checkBox1
        // 
        checkBox1.AutoSize = true;
        checkBox1.Checked = true;
        checkBox1.CheckState = CheckState.Checked;
        checkBox1.Location = new Point(102, 22);
        checkBox1.Margin = new Padding(3, 2, 3, 2);
        checkBox1.Name = "checkBox1";
        checkBox1.Size = new Size(103, 19);
        checkBox1.TabIndex = 2;
        checkBox1.Text = "system default";
        checkBox1.UseVisualStyleBackColor = true;
        // 
        // comboBox1
        // 
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new Point(15, 122);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(157, 23);
        comboBox1.TabIndex = 3;
        // 
        // button2
        // 
        button2.Location = new Point(178, 122);
        button2.Name = "button2";
        button2.Size = new Size(50, 23);
        button2.TabIndex = 4;
        button2.Text = "Load";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.Location = new Point(15, 151);
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
        ClientSize = new Size(488, 303);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(comboBox1);
        Controls.Add(groupBox1);
        Margin = new Padding(3, 2, 3, 2);
        MaximizeBox = false;
        Name = "MainForm";
        Text = "VpnKillSwitch";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion
    private Button button1;
    private GroupBox groupBox1;
    private CheckBox checkBox1;
    private Label label1;
    private ComboBox comboBox1;
    private Button button2;
    private Button button3;
}
