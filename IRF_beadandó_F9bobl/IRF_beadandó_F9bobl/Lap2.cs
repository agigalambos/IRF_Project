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
    public partial class Lap2 : UserControl
    {
        ProductSalesEntities context = new ProductSalesEntities();
        public Lap2()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {

            //chart1
            var adat = (from x in context.MainTable
                        group x by new { x.ProductLines.Name } into g
                        select new
                        {
                            ProductLine = g.Key.Name,
                            Total = (from x in g select x.Quantity).Average()

                        }) ;
            chart1BindingSource.DataSource = adat.ToList();
            chart1.DataSource = chart1BindingSource;
            chart1.DataBind();

            var adat2 = (from x in context.MainTable
                         group x by new { x.City } into g //, x.ProductLines.Name
                         select new
                         {
                             //ProductLine = g.Key.Name,
                             City = g.Key.City,
                             Total = (from x in g select x.Quantity).Sum()

                         });
            chart2BindingSource.DataSource = adat2.ToList();
            chart2.DataSource = chart2BindingSource;
            chart2.DataBind();



            //chart3
            var adat3 = (from x in context.MainTable
                         group x by new { x.Month } into g
                         select new
                         {
                             //productline - ez szintén key volt  
                             Month = g.Key.Month,
                             Total = (from x in g select x.Quantity).Sum() //nem lehet, hogy avg kéne?

                         });
            chart3BindingSource.DataSource = adat3.ToList();
            chart3.DataSource = chart3BindingSource;
            chart3.DataBind();



        }

    }
}

