namespace WinArtApp
{
    partial class ShowForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            speedBar = new TrackBar();
            xBar = new TrackBar();
            speedLabel = new Label();
            xLabel = new Label();
            freqBar = new TrackBar();
            freqLabel = new Label();
            freqValue = new Label();
            amplLabel = new Label();
            amplValue = new Label();
            amplBar = new TrackBar();
            xValue = new Label();
            speedValue = new Label();
            timer = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)speedBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)freqBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)amplBar).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 240F));
            tableLayoutPanel1.Controls.Add(panel, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(628, 327);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel
            // 
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(3, 3);
            panel.Name = "panel";
            panel.Size = new Size(382, 321);
            panel.TabIndex = 0;
            panel.SizeChanged += panel_SizeChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(speedBar, 0, 7);
            tableLayoutPanel2.Controls.Add(xBar, 0, 5);
            tableLayoutPanel2.Controls.Add(speedLabel, 0, 6);
            tableLayoutPanel2.Controls.Add(xLabel, 0, 4);
            tableLayoutPanel2.Controls.Add(freqBar, 0, 1);
            tableLayoutPanel2.Controls.Add(freqLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(freqValue, 1, 1);
            tableLayoutPanel2.Controls.Add(amplLabel, 0, 2);
            tableLayoutPanel2.Controls.Add(amplValue, 1, 3);
            tableLayoutPanel2.Controls.Add(amplBar, 0, 3);
            tableLayoutPanel2.Controls.Add(xValue, 1, 5);
            tableLayoutPanel2.Controls.Add(speedValue, 1, 7);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(391, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 9;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(234, 321);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // speedBar
            // 
            speedBar.Dock = DockStyle.Fill;
            speedBar.Location = new Point(3, 147);
            speedBar.Maximum = 100;
            speedBar.Name = "speedBar";
            speedBar.Size = new Size(209, 22);
            speedBar.TabIndex = 9;
            speedBar.TickStyle = TickStyle.None;
            speedBar.Scroll += speedBar_Scroll;
            // 
            // xBar
            // 
            xBar.Dock = DockStyle.Fill;
            xBar.Location = new Point(3, 104);
            xBar.Maximum = 100;
            xBar.Name = "xBar";
            xBar.Size = new Size(209, 22);
            xBar.TabIndex = 8;
            xBar.TickStyle = TickStyle.None;
            xBar.Scroll += xBar_Scroll;
            // 
            // speedLabel
            // 
            speedLabel.AutoSize = true;
            tableLayoutPanel2.SetColumnSpan(speedLabel, 2);
            speedLabel.Dock = DockStyle.Fill;
            speedLabel.Location = new Point(3, 129);
            speedLabel.Name = "speedLabel";
            speedLabel.Size = new Size(228, 15);
            speedLabel.TabIndex = 7;
            speedLabel.Text = "Скорость";
            // 
            // xLabel
            // 
            xLabel.AutoSize = true;
            tableLayoutPanel2.SetColumnSpan(xLabel, 2);
            xLabel.Dock = DockStyle.Fill;
            xLabel.Location = new Point(3, 86);
            xLabel.Name = "xLabel";
            xLabel.Size = new Size(228, 15);
            xLabel.TabIndex = 6;
            xLabel.Text = "Полжение";
            // 
            // freqBar
            // 
            freqBar.Dock = DockStyle.Fill;
            freqBar.Location = new Point(3, 18);
            freqBar.Maximum = 100;
            freqBar.Minimum = 1;
            freqBar.Name = "freqBar";
            freqBar.Size = new Size(209, 22);
            freqBar.TabIndex = 0;
            freqBar.TickStyle = TickStyle.None;
            freqBar.Value = 1;
            freqBar.Scroll += freqBar_Scroll;
            // 
            // freqLabel
            // 
            freqLabel.AutoSize = true;
            tableLayoutPanel2.SetColumnSpan(freqLabel, 2);
            freqLabel.Dock = DockStyle.Fill;
            freqLabel.Location = new Point(3, 0);
            freqLabel.Name = "freqLabel";
            freqLabel.Size = new Size(228, 15);
            freqLabel.TabIndex = 1;
            freqLabel.Text = "Частота";
            // 
            // freqValue
            // 
            freqValue.AutoSize = true;
            freqValue.Dock = DockStyle.Fill;
            freqValue.Location = new Point(218, 15);
            freqValue.Name = "freqValue";
            freqValue.Size = new Size(13, 28);
            freqValue.TabIndex = 2;
            freqValue.Text = "0";
            freqValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // amplLabel
            // 
            amplLabel.AutoSize = true;
            tableLayoutPanel2.SetColumnSpan(amplLabel, 2);
            amplLabel.Dock = DockStyle.Fill;
            amplLabel.Location = new Point(3, 43);
            amplLabel.Name = "amplLabel";
            amplLabel.Size = new Size(228, 15);
            amplLabel.TabIndex = 3;
            amplLabel.Text = "Амплитуда (высота)";
            // 
            // amplValue
            // 
            amplValue.AutoSize = true;
            amplValue.Dock = DockStyle.Fill;
            amplValue.Location = new Point(218, 58);
            amplValue.Name = "amplValue";
            amplValue.Size = new Size(13, 28);
            amplValue.TabIndex = 4;
            amplValue.Text = "0";
            amplValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // amplBar
            // 
            amplBar.Dock = DockStyle.Fill;
            amplBar.Location = new Point(3, 61);
            amplBar.Maximum = 100;
            amplBar.Name = "amplBar";
            amplBar.Size = new Size(209, 22);
            amplBar.TabIndex = 5;
            amplBar.TickStyle = TickStyle.None;
            amplBar.Scroll += amplBar_Scroll;
            // 
            // xValue
            // 
            xValue.AutoSize = true;
            xValue.Dock = DockStyle.Fill;
            xValue.Location = new Point(218, 101);
            xValue.Name = "xValue";
            xValue.Size = new Size(13, 28);
            xValue.TabIndex = 10;
            xValue.Text = "0";
            xValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // speedValue
            // 
            speedValue.AutoSize = true;
            speedValue.Dock = DockStyle.Fill;
            speedValue.Location = new Point(218, 144);
            speedValue.Name = "speedValue";
            speedValue.Size = new Size(13, 28);
            speedValue.TabIndex = 11;
            speedValue.Text = "0";
            speedValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // timer
            // 
            timer.Interval = 25;
            // 
            // ShowForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 327);
            Controls.Add(tableLayoutPanel1);
            Name = "ShowForm";
            Text = "ShowForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)speedBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)xBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)freqBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)amplBar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel;
        private System.Windows.Forms.Timer timer;
        private TableLayoutPanel tableLayoutPanel2;
        private TrackBar freqBar;
        private Label freqLabel;
        private Label freqValue;
        private Label amplLabel;
        private Label amplValue;
        private TrackBar amplBar;
        private TrackBar speedBar;
        private TrackBar xBar;
        private Label speedLabel;
        private Label xLabel;
        private Label xValue;
        private Label speedValue;
    }
}