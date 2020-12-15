using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IRF_beadandó_F9bobl.Entities;

namespace IRF_beadandó_F9bobl
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedSingle;

            panel2.BackColor = Color.FromArgb(255, 17, 48, 25);
            panel2.Height = this.Height;

            this.Text = "Product sales dashboard";
            Load += Form1_Load;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadButton1.BackColor = Color.FromArgb(100, 91, 128, 99);
            loadButton2.BackColor = Color.FromArgb(255, 91, 128, 99);
            loadButton3.BackColor = Color.FromArgb(255, 91, 128, 99);
            Lap1 uc = new Lap1();
            uc.Dock = DockStyle.Fill;

            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }

        private void loadButton1_Click_1(object sender, EventArgs e)
        {
            loadButton2.BackColor = Color.FromArgb(255, 91, 128, 99);
            loadButton3.BackColor = Color.FromArgb(255, 91, 128, 99);
            Lap1 uc = new Lap1();
            uc.Dock = DockStyle.Fill;

            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }

        private void loadButton2_Click_1(object sender, EventArgs e)
        {
            loadButton1.BackColor = Color.FromArgb(255, 91, 128, 99);
            loadButton3.BackColor = Color.FromArgb(255, 91, 128, 99);

            Lap2 uc = new Lap2();
            //uc.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }

        private void loadButton3_Click_1(object sender, EventArgs e)
        {
            loadButton1.BackColor = Color.FromArgb(255, 91, 128, 99);
            loadButton2.BackColor = Color.FromArgb(255, 91, 128, 99);


            Lap3 uc = new Lap3();
            uc.Dock = DockStyle.Fill;

            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }
    }
}
