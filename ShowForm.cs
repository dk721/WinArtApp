using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinArtApp
{
    public partial class ShowForm : Form
    {

        private double phaseShift;
        int ampl = 50;
        double freq = 0.2;
        double pnt = 0.25;
        double speed = 0.1;
        public ShowForm()
        {
            InitializeComponent();

            DoubleBuffered = true;

            freqBar.Value = (int)(freq * 10);
            freqValue.Text = freq.ToString("0.0");
            amplBar.Value = ampl;
            amplValue.Text = ampl.ToString();
            xBar.Value = (int)(panel.Width * pnt);
            xValue.Text = xBar.Value.ToString();
            speedBar.Value = (int)(speed * 100);
            speedValue.Text = speed.ToString();

            panel_SizeChanged(null, null);
            panel.Paint += new PaintEventHandler(Panel_Paint);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.GreenYellow, 2);
            Brush brush = new SolidBrush(Color.GreenYellow);
            Brush background = new SolidBrush(Color.LightBlue);
            Brush pn = new SolidBrush(Color.Yellow);

            int yOffset = panel.Height / 2;
            int xOffset = 0;
            int circleSize = 40;
            

            g.FillRectangle(background, new Rectangle(0, 0, panel.Width, panel.Height));

            Point[] points = new Point[panel.Width];
            for (int x = 0; x < panel.Width; x++)
            {
                double phase = 2 * Math.PI * freq * (x + xOffset) / panel.Width + phaseShift;
                int y = (int)(ampl * Math.Sin(phase));
                points[x] = new Point(x, y + yOffset);
            }
            int centerX = Math.Clamp((int)(panel.Width * pnt), 0, points.Length - 1);

            Point[] fillPoints = new Point[points.Length + 2];
            Array.Copy(points, fillPoints, points.Length);
            fillPoints[points.Length] = new Point(panel.Width - 1, panel.Height - 1);
            fillPoints[points.Length + 1] = new Point(0, panel.Height - 1);
            g.FillPolygon(brush, fillPoints);

            int centerY = points[centerX].Y;
            int circleX = centerX - circleSize / 2;
            int circleY = centerY - circleSize;
            g.FillEllipse(pn, new Rectangle(circleX, circleY, circleSize, circleSize));

            pen.Dispose();
            brush.Dispose();
            background.Dispose();
            pn.Dispose();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            phaseShift += speed;
            panel.Invalidate();
        }

        private void freqBar_Scroll(object sender, EventArgs e)
        {
            freq = 0.1 * freqBar.Value;
            freqValue.Text = freq.ToString("0.0");
        }

        private void amplBar_Scroll(object sender, EventArgs e)
        {
            ampl = amplBar.Value;
            amplValue.Text = ampl.ToString();
        }

        private void panel_SizeChanged(object sender, EventArgs e)
        {
            amplBar.Maximum = panel.Height / 2;
            if (ampl > amplBar.Maximum)
            {
                ampl = amplBar.Maximum;
                amplValue.Text = ampl.ToString("0.00");
            }
            xBar.Maximum = panel.Width;
        }

        private void xBar_Scroll(object sender, EventArgs e)
        {
            pnt = Math.Clamp((double)xBar.Value / panel.Width, 0, 1);
            xValue.Text = pnt.ToString("0.00");
        }

        private void speedBar_Scroll(object sender, EventArgs e)
        {
            speed = (double)speedBar.Value / 100;
            speedValue.Text = speed.ToString();
        }
    }
}
