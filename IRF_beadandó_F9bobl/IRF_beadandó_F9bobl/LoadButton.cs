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
            BackColor= Color.FromArgb(255, 143, 147, 186);
            Width = 190;
            Height = 80;
            Font = new Font("Arial", 10);
            Click += LoadButton_Click;
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            this.BackColor= Color.FromArgb(100, 143, 147, 186);
            
        }
    }
}
