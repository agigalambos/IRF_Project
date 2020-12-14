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
    public partial class Lap1 : UserControl
    {
        ProductSalesEntities context = new ProductSalesEntities();

        Szűrő szűrő = new Szűrő();

        public Lap1()
        {
            InitializeComponent();

            LoadData();

            //panel1.BackColor = Color.FromArgb(161, 165, 214);
            //panel1.Controls.Add(label4);
            //this.BackColor=Color.FromArgb(161, 165, 214);
            this.Dock = DockStyle.Fill;

            Broom broom = new Broom();
            this.Controls.Add(broom);
            broom.Left = paymentComboBox.Location.X + paymentComboBox.Width+30;
            broom.Top = label3.Location.Y;
            broom.Click += Broom_Click;
        }

        private void Broom_Click(object sender, EventArgs e)
        {
            genderComboBox.Text = "";
            ctComboBox.Text = "";
            paymentComboBox.Text = "";
            LoadData();
        }

        

        ProductSale ps = new ProductSale();

        private void LoadData()
        {
            //chart1
            var adat = (from x in context.MainTable
                         group x by new { x.ProductLines.Name } into g
                         select new
                         {
                             ProductLine = g.Key.Name,
                             Quantity = (from x in g select x.Quantity).Sum()

                         });
            chart1BindingSource.DataSource = adat.ToList();
            chart1.DataSource = chart1BindingSource;
            chart1.DataBind();

            var adat2 = (from x in context.MainTable
                        group x by new { x.City } into g //, x.ProductLines.Name
                        select new
                        {
                            //ProductLine = g.Key.Name,
                            City = g.Key.City,
                            Quantity = (from x in g select x.Quantity).Sum()

                        });
            chart2BindingSource.DataSource = adat2.ToList();
            chart2.DataSource = chart2BindingSource;
            chart2.DataBind();



            //chart3
            var adat3 = (from x in context.MainTable
                        group x by new { x.Month } into g
                         orderby (from x in g select x.Date).FirstOrDefault() ascending
                         select new
                        {
                            //productline - ez szintén key volt  
                            Month = g.Key.Month,
                            Quantity = (from x in g select x.Quantity).Sum()

                        });
            chart3BindingSource.DataSource = adat3.ToList();
            chart3.DataSource = chart3BindingSource;
            chart3.DataBind();



        }



        private void RefreshData()
        {
            //összes

            string[] nemek = new string[genderComboBox.Items.Count];

            for (int i = 0; i < genderComboBox.Items.Count; i++)
            {
                nemek[i] = genderComboBox.Items[i].ToString();
            }

            string[] fizmod = new string[paymentComboBox.Items.Count];

            for (int i = 0; i < paymentComboBox.Items.Count; i++)
            {
                fizmod[i] = paymentComboBox.Items[i].ToString();
            }

            string[] típus = new string[ctComboBox.Items.Count];

            for (int i = 0; i < ctComboBox.Items.Count; i++)
            {
                típus[i] = ctComboBox.Items[i].ToString();
            }

            if (genderComboBox.SelectedItem != null && genderComboBox.SelectedItem != "All")
            {
                szűrő.gender = genderComboBox.SelectedItem.ToString();
                nemek = nemek.Where(val => val == szűrő.gender.ToString()).ToArray();
            }

            if (paymentComboBox.SelectedItem != null && paymentComboBox.SelectedItem != "All")
            {
                szűrő.city = paymentComboBox.SelectedItem.ToString();
                fizmod = fizmod.Where(val => val == szűrő.city.ToString()).ToArray();
            }

            if (ctComboBox.SelectedItem != null && ctComboBox.SelectedItem != "All")
            {
                szűrő.type = ctComboBox.SelectedItem.ToString();
                típus = típus.Where(val => val == szűrő.type.ToString()).ToArray();
            }

            //chart1

            var adat = (from x in context.MainTable
                        where nemek.Contains(x.Gender) &&
                               fizmod.Contains(x.Payment) &&
                               típus.Contains(x.Customer_type)
                        group x by new { x.ProductLines.Name } into g
                        select new
                        {
                            ProductLine = g.Key.Name,
                            Quantity = (from x in g select x.Quantity).Sum()

                        });
            chart1BindingSource.DataSource = adat.ToList();
            chart1.DataSource = chart1BindingSource;
            chart1.DataBind();

            //chart2

            var adat2 = (from x in context.MainTable
                         where nemek.Contains(x.Gender) &&
                                 fizmod.Contains(x.Payment) &&
                                 típus.Contains(x.Customer_type)
                         group x by new { x.City } into g //, x.ProductLines.Name
                         select new
                         {
                             //ProductLine = g.Key.Name,
                             City = g.Key.City,
                             Quantity = (from x in g select x.Quantity).Sum()

                         });
            chart2BindingSource.DataSource = adat2.ToList();
            chart2.DataSource = chart2BindingSource;
            chart2.DataBind();

            //chart3
            var adat3 = (from x in context.MainTable
                         where nemek.Contains(x.Gender) &&
                                 fizmod.Contains(x.Payment) &&
                                 típus.Contains(x.Customer_type)
                         group x by new { x.Month } into g
                         orderby (from x in g select x.Date).FirstOrDefault() ascending
                         select new
                         {
                             //productline - ez szintén key volt  
                             Month = g.Key.Month,
                             Quantity = (from x in g select x.Quantity).Sum()

                         });
            chart3BindingSource.DataSource = adat3.ToList();
            chart3.DataSource = chart3BindingSource;
            chart3.DataBind();

        }


        private void genderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void ctComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void paymentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
