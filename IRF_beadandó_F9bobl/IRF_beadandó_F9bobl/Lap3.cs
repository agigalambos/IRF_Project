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
    public partial class Lap3 : UserControl
    {
        ProductSalesEntities context = new ProductSalesEntities();
        Szűrő szűrő = new Szűrő();

        public Lap3()
        {
            InitializeComponent();

            AdatBetöltés();

        }
        private void AdatBetöltés()
        {
            var adatok = (from x in context.MainTable
                          select new
                          {
                              Date = x.Date,
                              ProductLine = x.Product_line,
                              Gender = x.Gender,
                              UnitPrice = x.Unit_price,
                              x.Quantity,
                              x.Total,
                              x.City,
                              x.Customer_type,
                              x.Payment,
                          });

            dataGridView1.DataSource = adatok.ToList();
        }

        private void AdatFrissítés()
        {
            string[] nemek = new string[genderComboBox.Items.Count];

            for (int i = 0; i < genderComboBox.Items.Count; i++)
            {
                nemek[i] = genderComboBox.Items[i].ToString();
            }

            string[] városok = new string[cityComboBox.Items.Count];

            for (int i = 0; i < cityComboBox.Items.Count; i++)
            {
                városok[i] = cityComboBox.Items[i].ToString();
            }

            //var nem = genderComboBox.SelectedItem;

            if (genderComboBox.SelectedItem != null && genderComboBox.SelectedItem != "Mind")
            {
                szűrő.gender = genderComboBox.SelectedItem.ToString();
                nemek = nemek.Where(val => val == szűrő.gender.ToString()).ToArray();
            }

            if (cityComboBox.SelectedItem != null && cityComboBox.SelectedItem != "Mind")
            {
                szűrő.city = cityComboBox.SelectedItem.ToString();
                városok = városok.Where(val => val == szűrő.city.ToString()).ToArray();
            }

            var adatok = (from x in context.MainTable
                              //if (nem != null)
                          where nemek.Contains(x.Gender) &&
                                városok.Contains(x.City)
                          select new
                          {
                              Date = x.Date,
                              ProductLine = x.Product_line,
                              Gender = x.Gender,
                              UnitPrice = x.Unit_price,
                              x.Quantity,
                              x.Total,
                              x.City,
                              x.Customer_type,
                              x.Payment,

                          });

            dataGridView1.DataSource = adatok.ToList();
        }

 
    }
}
