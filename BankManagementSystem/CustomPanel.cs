using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    internal class CustomPanel:Panel
    {
       
            public Color ColorTop { get; set; }
            public Color ColorBottom { get; set; }
        public int CornerRadius { get; set; } = 0; // Default corner radius

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            if (CornerRadius > 0)
            {
                // Create a rounded rectangle path
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, CornerRadius, CornerRadius, 180, 90);
                path.AddArc(Width - CornerRadius, 0, CornerRadius, CornerRadius, 270, 90);
                path.AddArc(Width - CornerRadius, Height - CornerRadius, CornerRadius, CornerRadius, 0, 90);
                path.AddArc(0, Height - CornerRadius, CornerRadius, CornerRadius, 90, 90);
                path.CloseFigure();

                // Set the region of the panel to the rounded rectangle
                Region = new Region(path);

                // Fill the panel background
                g.FillPath(Brushes.LightBlue, path);
                g.DrawPath(Pens.DarkBlue, path); // Optional border
            }

            LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle, this.ColorTop, this.ColorBottom, LinearGradientMode.Vertical);
            g.FillRectangle(lgb, this.ClientRectangle);
            base.OnPaint(e);
        }
       
      

    }
}
