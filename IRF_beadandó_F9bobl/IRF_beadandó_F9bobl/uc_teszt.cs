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
    public partial class uc_teszt : UserControl
    {
        public uc_teszt()
        {
            InitializeComponent();

            Lines line = new Lines();

            line.Width = this.Width;
            line.Height = this.Height;


            this.Controls.Add(line);
        }
    }
}
