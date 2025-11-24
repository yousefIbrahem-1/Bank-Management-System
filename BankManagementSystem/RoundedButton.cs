using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Bank
{
    internal class RoundedButton: Button
    {
        public int BorderRadius { get; set; } = 30; // Default border radius

        protected override void OnPaint(PaintEventArgs pevent)
        {
            // Create a GraphicsPath for the rounded rectangle
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, BorderRadius, BorderRadius, 180, 90); // Top-left
            path.AddArc(this.Width - BorderRadius, 0, BorderRadius, BorderRadius, 270, 90); // Top-right
            path.AddArc(this.Width - BorderRadius, this.Height - BorderRadius, BorderRadius, BorderRadius, 0, 90); // Bottom-right
            path.AddArc(0, this.Height - BorderRadius, BorderRadius, BorderRadius, 90, 90); // Bottom-left
            path.CloseFigure();

            this.Region = new Region(path);

            // Draw the button
            base.OnPaint(pevent);
        }

        protected override void OnResize(EventArgs e)
        {
            // Invalidate the button to redraw when resized
            this.Invalidate();
            base.OnResize(e);
        }
    }
}
