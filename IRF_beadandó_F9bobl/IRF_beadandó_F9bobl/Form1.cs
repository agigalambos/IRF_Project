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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lap1 uc = new Lap1();

            panel1.Controls.Clear();
            panel1.Controls.Add(uc);

            //Form2 f2 = new Form2();
            //this.Hide();
            //f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lap2 uc = new Lap2();

            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lap3 uc = new Lap3();

            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }
    }
}
