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

            Adatbetöltés();
        }

        private void Adatbetöltés()
        {
            var ps = (from x in context.MainTable
                      group x by new { x.ProductLines.Name, x.City } into g
                      select new
                      {
                          ProductLine = g.Key.Name,
                          City = g.Key.City,
                          Quantity = (from x in g select x.Quantity).Sum()

                      });
            dataGridView1.DataSource = ps.ToList();


            var adat = (from x in context.MainTable
                        group x by new { x.ProductLines.Name, x.Month } into g
                        select new
                        {
                            ProductLine = g.Key.Name,
                            Month = g.Key.Month,
                            Quantity = (from x in g select x.Quantity).Sum()

                        });

            dataGridView2.DataSource = adat.ToList();

        }
    }
}
