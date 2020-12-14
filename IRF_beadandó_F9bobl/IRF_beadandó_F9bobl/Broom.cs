using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_beadandó_F9bobl
{
    public class Broom : Button
    {
        public Broom()
        {
            AutoSize = false;
            Width = 40;
            Height = Width;
            Paint += Broom_Paint;
        }


        private void Broom_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }

        private void DrawImage(Graphics g)
        {
            Image imageFile = Image.FromFile("Images/broom.png");
            g.DrawImage(imageFile, new Rectangle(0, 0, Width, Height));
            

        }

    }
}
