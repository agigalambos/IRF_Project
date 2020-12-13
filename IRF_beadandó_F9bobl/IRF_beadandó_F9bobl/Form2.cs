using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_beadandó_F9bobl
{
    public partial class Form2 : Form
    {
        Line line = new Line();

        public Form2()
        {
            InitializeComponent();
            line.Width = this.Width;
            line.Height = this.Height;
            this.Controls.Add(line);

            this.Resize += Form2_Resize;
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            line.Width = this.Width;
            line.Height = this.Height;
            this.Controls.Add(line);
        }
    }
}
