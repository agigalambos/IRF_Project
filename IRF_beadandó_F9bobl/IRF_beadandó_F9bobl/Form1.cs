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
            panel2.BackColor = Color.FromArgb(255, 15, 19, 61);
            panel2.Height = this.Height;

            this.Text = "Product sales dashboard";
            

            button1.BackColor = Color.FromArgb(255, 143, 147, 186);
            button2.BackColor = Color.FromArgb(255, 143, 147, 186);
            button3.BackColor = Color.FromArgb(255, 143, 147, 186);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(100, 143, 147, 186);
            button2.BackColor = Color.FromArgb(255, 143, 147, 186);
            button3.BackColor = Color.FromArgb(255, 143, 147, 186);
            Lap1 uc = new Lap1();
            uc.Dock = DockStyle.Fill;

            panel1.Controls.Clear();
            panel1.Controls.Add(uc);

            //Form2 f2 = new Form2();
            //this.Hide();
            //f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(255, 143, 147, 186);
            button2.BackColor = Color.FromArgb(100, 143, 147, 186);
            button3.BackColor = Color.FromArgb(255, 143, 147, 186);

            Lap2 uc = new Lap2();
            //uc.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(255, 143, 147, 186);
            button2.BackColor = Color.FromArgb(255, 143, 147, 186);
            button3.BackColor = Color.FromArgb(100, 143, 147, 186);

            Lap3 uc = new Lap3();
            uc.Dock = DockStyle.Fill;

            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }
    }
}
