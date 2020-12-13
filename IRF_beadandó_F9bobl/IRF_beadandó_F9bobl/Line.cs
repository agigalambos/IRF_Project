using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_beadandó_F9bobl
{
    public class Line:Label
    {
        public Line()
        {
            Paint += Line_Paint;           
        }

        private void Line_Paint(object sender, PaintEventArgs e)
        {
            DrawLine(e.Graphics);
        }

        private void DrawLine(Graphics g)
        {
            

            Pen pen = new Pen(Color.FromArgb(255, 255, 0, 0));
            pen.Width = 2;
            var x = pen.Width;
            g.DrawLine(pen, 5,5, Width-20, 5);
            g.DrawLine(pen, Width-20, 5, Width-20, Height-45);
            g.DrawLine(pen, 5, 5, 5, Height-45);
            g.DrawLine(pen, 5, Height-45, Width-20, Height-45);
        }

    }
}
