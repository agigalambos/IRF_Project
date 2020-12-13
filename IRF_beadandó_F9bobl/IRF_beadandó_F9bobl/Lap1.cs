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

        public Lap1()
        {
            InitializeComponent();

            LoadChart1();
            LoadChart2();
            LoadChart3();
        }
        private void LoadChart1()
        {
            var adat2 = (from x in context.MainTable
                         group x by new { x.ProductLines.Name } into g
                         select new
                         {
                             ProductLine = g.Key.Name,
                             Quantity = (from x in g select x.Quantity).Sum()

                         });
            chart1BindingSource.DataSource = adat2.ToList();
            chart1.DataSource = chart1BindingSource;
            chart1.DataBind();

        }

        ProductSale ps = new ProductSale();

        private void LoadChart2()
        {

            var adat = (from x in context.MainTable
                      group x by new { x.City } into g //, x.ProductLines.Name
                        select new
                         {
                             //ProductLine = g.Key.Name,
                             City=g.Key.City,
                             Quantity = (from x in g select x.Quantity).Sum()

                         });
            chart2BindingSource.DataSource = adat.ToList();
            chart2.DataSource = chart2BindingSource;
            chart2.DataBind();


        }
        
        private void LoadChart3()
        {
            var adat = (from x in context.MainTable
                         group x by new { x.Month } into g
                         select new
                         {
                          //productline - ez szintén key volt  
                             Month = g.Key.Month,
                             Quantity = (from x in g select x.Quantity).Sum()

                         });
            chart3BindingSource.DataSource = adat.ToList();
            chart3.DataSource = chart3BindingSource;
            chart3.DataBind();
        }

        private void RefreshData()
        {
            //chart1



            var adat2 = (from x in context.MainTable
                         group x by new { x.ProductLines.Name } into g
                         select new
                         {
                             ProductLine = g.Key.Name,
                             Quantity = (from x in g select x.Quantity).Sum()

                         });
            chart1BindingSource.DataSource = adat2.ToList();
            chart1.DataSource = chart1BindingSource;
            chart1.DataBind();
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
