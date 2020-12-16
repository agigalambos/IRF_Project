using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_beadandó_F9bobl.Entities
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
            
            Pen pen = new Pen(Color.FromArgb(255, 41, 117, 60)); 
            pen.Width = 2;
            
            g.DrawLine(pen, 1, 1, Width-1, 1);
            g.DrawLine(pen, Width-1, 1, Width-1 , Height-2);
            g.DrawLine(pen, 1, 1, 1, Height-2);
            g.DrawLine(pen, 1, Height-2, Width-1, Height-2);
        }

    }
}
