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
    public partial class Lap1 : UserControl
    {
        ProductSalesEntities context = new ProductSalesEntities();

        Szűrő szűrő = new Szűrő();
        Lines line = new Lines();
        
        public Lap1()
        {
            InitializeComponent();

            LoadData();

            panel1.BackColor = Color.FromArgb(100, 91, 128, 99);

            //seprű ikon beállítása
            Broom broom = new Broom();
            panel1.Controls.Add(broom);
            broom.Left = paymentComboBox.Location.X + paymentComboBox.Width+30;
            broom.Top = label3.Location.Y;
            broom.Click += Broom_Click;


            //panel keret
            line.Width = this.Width+2;//+23;
            line.Height = panel1.Height;//+40;

            panel1.Controls.Add(line);
        }

        private void Broom_Click(object sender, EventArgs e)
        {
            genderComboBox.Text = "";
            ctComboBox.Text = "";
            paymentComboBox.Text = "";
            LoadData();
        }
        Arány arány = new Arány();
        private void LoadData()
        {
            //chart1
            var adat = (from x in context.MainTable
                         group x by new { x.ProductLines.Name } into g
                        orderby (from x in g select x.Total).Sum() ascending
                        select new
                         {
                             ProductLine = g.Key.Name,
                             Quantity = (from x in g select x.Total).Sum()

                         });
            chart1BindingSource.DataSource = adat.ToList();
            chart1.DataSource = chart1BindingSource;
            chart1.DataBind();

            

            var arány = (from x in context.MainTable
                        group x by new { x.City } into g 
                        select new Arány
                        {
                            City = g.Key.City,
                            Rate =(double)((from x in g select x.Total).Sum()/
                                   (double)(from y in context.MainTable
                                    select y.Total).Sum().Value)*100,
                           
                        });

            arányBindingSource1.DataSource = arány.ToList();
            chart2.DataSource = arányBindingSource1;
            chart2.DataBind();

            chart2.PaletteCustomColors = new Color[] {Color.FromArgb(255,41, 117, 60),
                                                      Color.FromArgb(255,95, 115, 100),
                                                      Color.FromArgb(255, 17, 48, 25),
                                                     };
            //chart3
            var adat3 = (from x in context.MainTable
                        group x by new { x.Month } into g
                         orderby (from x in g select x.Date).FirstOrDefault() ascending
                         select new
                        {
                            
                            Month = g.Key.Month,
                            Quantity = (from x in g select x.Total).Sum()

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
                        orderby (from x in g select x.Total).Sum() ascending
                        select new
                        {
                            ProductLine = g.Key.Name,
                            Quantity = (from x in g select x.Total).Sum()

                        });
            chart1BindingSource.DataSource = adat.ToList();
            chart1.DataSource = chart1BindingSource;
            chart1.DataBind();

            //chart2


            var arány = (from x in context.MainTable
                         where nemek.Contains(x.Gender) &&
                                 fizmod.Contains(x.Payment) &&
                                 típus.Contains(x.Customer_type)
                         group x by new { x.City } into g
                         select new Arány
                         {
                             City = g.Key.City,
                             Rate = (double)((from x in g select x.Total).Sum() /
                                    (double)(from y in context.MainTable
                                             where nemek.Contains(y.Gender) &&
                                                     fizmod.Contains(y.Payment) &&
                                                        típus.Contains(y.Customer_type)
                                             select y.Total).Sum().Value) * 100,

                         });

            arányBindingSource1.DataSource = arány.ToList();
            chart2.DataSource = arányBindingSource1;
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
                             Month = g.Key.Month,
                             Quantity = (from x in g select x.Total).Sum()

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
