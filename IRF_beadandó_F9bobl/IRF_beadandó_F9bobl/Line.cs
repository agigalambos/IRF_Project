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
            Pen pen = new Pen(Color.FromArgb(255, 15, 19, 61));
            pen.Width = 3;
            g.DrawLine(pen, 0, Height, Width, Height);
        }
    }
}
