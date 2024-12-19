namespace WiiRemoteEmulator;

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
        button1 = new Button();
        button2 = new Button();
        TopLeftValue = new Label();
        TopRightValue = new Label();
        BottomLeftValue = new Label();
        BottomRightValue = new Label();
        TopRight = new Label();
        TopLeft = new Label();
        BottomLeft = new Label();
        BottomRight = new Label();
        CalibrateBoard = new Button();
        SuspendLayout();
        // 
        // button1
        // 
        button1.ImageAlign = ContentAlignment.MiddleLeft;
        button1.Location = new Point(450, 367);
        button1.Name = "button1";
        button1.Size = new Size(144, 47);
        button1.TabIndex = 0;
        button1.Text = "Connect Board";
        button1.UseVisualStyleBackColor = true;
        button1.Click += ConnectWiiMote_Click;
        // 
        // button2
        // 
        button2.ImageAlign = ContentAlignment.MiddleLeft;
        button2.Location = new Point(450, 317);
        button2.Name = "button2";
        button2.Size = new Size(144, 44);
        button2.TabIndex = 1;
        button2.Text = "Start Update";
        button2.UseVisualStyleBackColor = true;
        button2.Click += StartUpdateTimer_Click;
        // 
        // TopLeftValue
        // 
        TopLeftValue.AutoSize = true;
        TopLeftValue.Location = new Point(49, 49);
        TopLeftValue.Name = "TopLeftValue";
        TopLeftValue.Size = new Size(99, 20);
        TopLeftValue.TabIndex = 2;
        TopLeftValue.Text = "TopLeft Value";
        // 
        // TopRightValue
        // 
        TopRightValue.AutoSize = true;
        TopRightValue.Location = new Point(172, 49);
        TopRightValue.Name = "TopRightValue";
        TopRightValue.Size = new Size(109, 20);
        TopRightValue.TabIndex = 3;
        TopRightValue.Text = "TopRight Value";
        // 
        // BottomLeftValue
        // 
        BottomLeftValue.AutoSize = true;
        BottomLeftValue.Location = new Point(24, 78);
        BottomLeftValue.Name = "BottomLeftValue";
        BottomLeftValue.Size = new Size(124, 20);
        BottomLeftValue.TabIndex = 5;
        BottomLeftValue.Text = "BottomLeft Value";
        // 
        // BottomRightValue
        // 
        BottomRightValue.AutoSize = true;
        BottomRightValue.Location = new Point(172, 78);
        BottomRightValue.Name = "BottomRightValue";
        BottomRightValue.Size = new Size(134, 20);
        BottomRightValue.TabIndex = 4;
        BottomRightValue.Text = "BottomRight Value";
        // 
        // TopRight
        // 
        TopRight.AutoSize = true;
        TopRight.Location = new Point(172, 20);
        TopRight.Name = "TopRight";
        TopRight.Size = new Size(69, 20);
        TopRight.TabIndex = 7;
        TopRight.Text = "TopRight";
        // 
        // TopLeft
        // 
        TopLeft.AutoSize = true;
        TopLeft.Location = new Point(49, 20);
        TopLeft.Name = "TopLeft";
        TopLeft.Size = new Size(59, 20);
        TopLeft.TabIndex = 6;
        TopLeft.Text = "TopLeft";
        // 
        // BottomLeft
        // 
        BottomLeft.AutoSize = true;
        BottomLeft.Location = new Point(24, 109);
        BottomLeft.Name = "BottomLeft";
        BottomLeft.Size = new Size(84, 20);
        BottomLeft.TabIndex = 9;
        BottomLeft.Text = "BottomLeft";
        // 
        // BottomRight
        // 
        BottomRight.AutoSize = true;
        BottomRight.Location = new Point(172, 109);
        BottomRight.Name = "BottomRight";
        BottomRight.Size = new Size(94, 20);
        BottomRight.TabIndex = 8;
        BottomRight.Text = "BottomRight";
        // 
        // button3
        // 
        CalibrateBoard.ImageAlign = ContentAlignment.MiddleLeft;
        CalibrateBoard.Location = new Point(450, 267);
        CalibrateBoard.Name = "CalibrateBoard";
        CalibrateBoard.Size = new Size(144, 44);
        CalibrateBoard.TabIndex = 10;
        CalibrateBoard.Text = "Calibrate BalanceBoard";
        CalibrateBoard.UseVisualStyleBackColor = true;
        CalibrateBoard.Click += CalibrateBoard_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1054, 549);
        Controls.Add(CalibrateBoard);
        Controls.Add(BottomLeft);
        Controls.Add(BottomRight);
        Controls.Add(TopRight);
        Controls.Add(TopLeft);
        Controls.Add(BottomLeftValue);
        Controls.Add(BottomRightValue);
        Controls.Add(TopRightValue);
        Controls.Add(TopLeftValue);
        Controls.Add(button2);
        Controls.Add(button1);
        Name = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button button1;
    private Button button2;
    public Label TopLeftValue;
    public Label TopRightValue;
    public Label BottomLeftValue;
    public Label BottomRightValue;
    public Label TopRight;
    public Label TopLeft;
    public Label BottomLeft;
    public Label BottomRight;
    private Button CalibrateBoard;
}