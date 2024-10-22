namespace ColorMapper;

partial class Form1
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
        listBox1 = new ListBox();
        pictureBox1 = new PictureBox();
        formsPlot1 = new ScottPlot.WinForms.FormsPlot();
        pictureBox2 = new PictureBox();
        button1 = new Button();
        button2 = new Button();
        button3 = new Button();
        button4 = new Button();
        button5 = new Button();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        SuspendLayout();
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.Location = new Point(12, 12);
        listBox1.Name = "listBox1";
        listBox1.Size = new Size(121, 199);
        listBox1.TabIndex = 0;
        // 
        // pictureBox1
        // 
        pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        pictureBox1.BackColor = SystemColors.ControlDarkDark;
        pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        pictureBox1.Location = new Point(12, 217);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(475, 50);
        pictureBox1.TabIndex = 1;
        pictureBox1.TabStop = false;
        // 
        // formsPlot1
        // 
        formsPlot1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        formsPlot1.DisplayScale = 1F;
        formsPlot1.Location = new Point(12, 273);
        formsPlot1.Name = "formsPlot1";
        formsPlot1.Size = new Size(475, 285);
        formsPlot1.TabIndex = 2;
        // 
        // pictureBox2
        // 
        pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        pictureBox2.BackColor = SystemColors.ControlDarkDark;
        pictureBox2.BorderStyle = BorderStyle.FixedSingle;
        pictureBox2.Location = new Point(263, 12);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(224, 199);
        pictureBox2.TabIndex = 3;
        pictureBox2.TabStop = false;
        // 
        // button1
        // 
        button1.Location = new Point(139, 12);
        button1.Name = "button1";
        button1.Size = new Size(97, 31);
        button1.TabIndex = 4;
        button1.Text = "Add";
        button1.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        button2.Location = new Point(139, 49);
        button2.Name = "button2";
        button2.Size = new Size(97, 31);
        button2.TabIndex = 5;
        button2.Text = "Replace";
        button2.UseVisualStyleBackColor = true;
        // 
        // button3
        // 
        button3.Location = new Point(139, 86);
        button3.Name = "button3";
        button3.Size = new Size(97, 31);
        button3.TabIndex = 6;
        button3.Text = "Move Up";
        button3.UseVisualStyleBackColor = true;
        // 
        // button4
        // 
        button4.Location = new Point(139, 123);
        button4.Name = "button4";
        button4.Size = new Size(97, 31);
        button4.TabIndex = 7;
        button4.Text = "Move Down";
        button4.UseVisualStyleBackColor = true;
        // 
        // button5
        // 
        button5.Location = new Point(139, 160);
        button5.Name = "button5";
        button5.Size = new Size(97, 31);
        button5.TabIndex = 8;
        button5.Text = "Delete";
        button5.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(499, 570);
        Controls.Add(button5);
        Controls.Add(button4);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(pictureBox2);
        Controls.Add(formsPlot1);
        Controls.Add(pictureBox1);
        Controls.Add(listBox1);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private ListBox listBox1;
    private PictureBox pictureBox1;
    private ScottPlot.WinForms.FormsPlot formsPlot1;
    private PictureBox pictureBox2;
    private Button button1;
    private Button button2;
    private Button button3;
    private Button button4;
    private Button button5;
}
