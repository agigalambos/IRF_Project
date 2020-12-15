using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_beadandó_F9bobl
{
    public class Lines:Label
    {
        public Lines()
        {
            Paint += Line_Paint;           
        }

        private void Line_Paint(object sender, PaintEventArgs e)
        {
            DrawLine(e.Graphics);
        }

        private void DrawLine(Graphics g)
        {
            

            //Pen pen = new Pen(Color.FromArgb(255, 255, 0, 0));
            //pen.Width = 1;
            //var x = pen.Width;
            //g.DrawLine(pen, 5,5, Width, 5);
            //g.DrawLine(pen, Width, 5, Width, Height);
            //g.DrawLine(pen, 5, 5, 5, Height);
            //g.DrawLine(pen, 5, Height, Width, Height);

            Pen pen = new Pen(Color.FromArgb(255, 41, 117, 60));
            pen.Width = 2;
            var x = pen.Width;
            g.DrawLine(pen, 1, 1, Width - 19, 1);
            g.DrawLine(pen, Width - 19, 1, Width - 19, Height - 41);
            g.DrawLine(pen, 1, 1, 1, Height - 41);
            g.DrawLine(pen, 1, Height - 41, Width - 19, Height - 41);
        }

    }
}
