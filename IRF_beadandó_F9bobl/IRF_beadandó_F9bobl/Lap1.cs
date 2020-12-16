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

        Filter filter = new Filter();
        Lines line = new Lines();
        
        public Lap1()
        {
            InitializeComponent();

            LoadData();

            panel1.BackColor = Color.FromArgb(100, 91, 128, 99);

            AddBroom();
            CreateFrame();
           
        }

        private void CreateFrame() 
        {
            //panel keret
            line.Width = this.Width + 2;
            line.Height = panel1.Height;
            panel1.Controls.Add(line);
        }

        private void AddBroom()
        {
            //seprű gomb beállítása
            Broom broom = new Broom();
            panel1.Controls.Add(broom);
            broom.Left = paymentComboBox.Location.X + paymentComboBox.Width + 30;
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
        
        private void LoadData()
        {
            //chart1
            var data = (from x in context.MainTable
                         group x by new { x.ProductLines.Name } into g
                        orderby (from x in g select x.Total).Sum() ascending
                        select new
                         {
                             ProductLine = g.Key.Name,
                             Quantity = (from x in g select x.Total).Sum()

                         });
            chart1BindingSource.DataSource = data.ToList();
            chart1.DataSource = chart1BindingSource;
            chart1.DataBind();

            

            var rate = (from x in context.MainTable
                        group x by new { x.City } into g 
                        select new Rates
                        {
                            City = g.Key.City,
                            Rate =(double)((from x in g select x.Total).Sum()/
                                   (double)(from y in context.MainTable
                                    select y.Total).Sum().Value)*100,
                           
                        });

            ratesBindingSource.DataSource = rate.ToList();
            chart2.DataSource = ratesBindingSource;
            chart2.DataBind();

            chart2.PaletteCustomColors = new Color[] {Color.FromArgb(255,41, 117, 60),
                                                      Color.FromArgb(255,95, 115, 100),
                                                      Color.FromArgb(255, 17, 48, 25),
                                                     };
            //chart3
            var data3 = (from x in context.MainTable
                        group x by new { x.Month } into g
                         orderby (from x in g select x.Date).FirstOrDefault() ascending
                         select new
                        {
                            
                            Month = g.Key.Month,
                            Quantity = (from x in g select x.Total).Sum()

                        });
            chart3BindingSource.DataSource = data3.ToList();
            chart3.DataSource = chart3BindingSource;
            chart3.DataBind();
        }

        


        private void RefreshData()
        {
            //all

            string[] genders = new string[genderComboBox.Items.Count];

            for (int i = 0; i < genderComboBox.Items.Count; i++)
            {
                genders[i] = genderComboBox.Items[i].ToString();
            }

            string[] payments = new string[paymentComboBox.Items.Count];

            for (int i = 0; i < paymentComboBox.Items.Count; i++)
            {
                payments[i] = paymentComboBox.Items[i].ToString();
            }

            string[] types = new string[ctComboBox.Items.Count];

            for (int i = 0; i < ctComboBox.Items.Count; i++)
            {
                types[i] = ctComboBox.Items[i].ToString();
            }

            if (genderComboBox.SelectedItem != null && genderComboBox.SelectedItem != "All")
            {
                filter.gender = genderComboBox.SelectedItem.ToString();
                genders = genders.Where(val => val == filter.gender.ToString()).ToArray();
            }

            if (paymentComboBox.SelectedItem != null && paymentComboBox.SelectedItem != "All")
            {
                filter.city = paymentComboBox.SelectedItem.ToString();
                payments = payments.Where(val => val == filter.city.ToString()).ToArray();
            }

            if (ctComboBox.SelectedItem != null && ctComboBox.SelectedItem != "All")
            {
                filter.type = ctComboBox.SelectedItem.ToString();
                types = types.Where(val => val == filter.type.ToString()).ToArray();
            }

            //chart1

            var data = (from x in context.MainTable
                        where genders.Contains(x.Gender) &&
                               payments.Contains(x.Payment) &&
                               types.Contains(x.Customer_type)
                        group x by new { x.ProductLines.Name } into g
                        orderby (from x in g select x.Total).Sum() ascending
                        select new
                        {
                            ProductLine = g.Key.Name,
                            Quantity = (from x in g select x.Total).Sum()

                        });
            chart1BindingSource.DataSource = data.ToList();
            chart1.DataSource = chart1BindingSource;
            chart1.DataBind();

            //chart2


            var rate = (from x in context.MainTable
                         where genders.Contains(x.Gender) &&
                                 payments.Contains(x.Payment) &&
                                 types.Contains(x.Customer_type)
                         group x by new { x.City } into g
                         select new Rates
                         {
                             City = g.Key.City,
                             Rate = (double)((from x in g select x.Total).Sum() /
                                    (double)(from y in context.MainTable
                                             where genders.Contains(y.Gender) &&
                                                     payments.Contains(y.Payment) &&
                                                        types.Contains(y.Customer_type)
                                             select y.Total).Sum().Value) * 100,

                         });

            ratesBindingSource.DataSource = rate.ToList();
            chart2.DataSource = ratesBindingSource;
            chart2.DataBind();

            //chart3
            var data3 = (from x in context.MainTable
                         where genders.Contains(x.Gender) &&
                                 payments.Contains(x.Payment) &&
                                 types.Contains(x.Customer_type)
                         group x by new { x.Month } into g
                         orderby (from x in g select x.Date).FirstOrDefault() ascending
                         select new
                         { 
                             Month = g.Key.Month,
                             Quantity = (from x in g select x.Total).Sum()

                         });
            chart3BindingSource.DataSource = data3.ToList();
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
