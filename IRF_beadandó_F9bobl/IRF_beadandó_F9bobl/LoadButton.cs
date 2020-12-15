using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_beadandó_F9bobl
{
    public class LoadButton:Button
    {
        public LoadButton()
        {
            BackColor= Color.FromArgb(255, 91, 128, 99);
            Width = 190;
            Height = 80;
            Font = new Font("Arial", 10);
            //FlatAppearance.BorderColor = Color.FromArgb(255, 17, 48, 25);
            //FlatAppearance.BorderSize = 0;
            ForeColor = Color.White;
            Click += LoadButton_Click;
            
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            this.BackColor= Color.FromArgb(150, 91, 128, 99);
            //Form1 f1 = new Form1();
            //f1.panel1.Controls.Clear();
            
        }
    }
}
