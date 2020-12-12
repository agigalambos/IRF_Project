using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace IRF_beadandó_F9bobl
{
    public partial class Lap3 : UserControl
    {
        ProductSalesEntities context = new ProductSalesEntities();
        Szűrő szűrő = new Szűrő();

        Excel.Application xlApp; 
        Excel.Workbook xlWB; 
        Excel.Worksheet xlSheet; 

        public Lap3()
        {
            InitializeComponent();

            Broom broom = new Broom();
            this.Controls.Add(broom);
            broom.Left = 700;
            broom.Top = 25;

            AdatBetöltés();

            broom.Click += Broom_Click;

        }

        private void Broom_Click(object sender, EventArgs e)
        {
            genderComboBox.Text = "";
            cityComboBox.Text = "";
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

            string[] típus = new string[ctComboBox.Items.Count];

            for (int i = 0; i < ctComboBox.Items.Count; i++)
            {
                típus[i] = ctComboBox.Items[i].ToString();
            }

            //var nem = genderComboBox.SelectedItem;

            if (genderComboBox.SelectedItem != null && genderComboBox.SelectedItem != "All")
            {
                szűrő.gender = genderComboBox.SelectedItem.ToString();
                nemek = nemek.Where(val => val == szűrő.gender.ToString()).ToArray();
            }

            if (cityComboBox.SelectedItem != null && cityComboBox.SelectedItem != "All")
            {
                szűrő.city = cityComboBox.SelectedItem.ToString();
                városok = városok.Where(val => val == szűrő.city.ToString()).ToArray();
            }

            if (ctComboBox.SelectedItem != null && ctComboBox.SelectedItem != "All")
            {
                szűrő.type = ctComboBox.SelectedItem.ToString();
                típus = típus.Where(val => val == szűrő.type.ToString()).ToArray();
            }

            var adatok = (from x in context.MainTable
                              //if (nem != null)
                          where nemek.Contains(x.Gender) &&
                                városok.Contains(x.City) &&
                                típus.Contains(x.Customer_type)
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

        private void genderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdatFrissítés();
        }

        private void cityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdatFrissítés();
        }


        private void CreateExcel()
        {
            try
            {
                xlApp = new Excel.Application();
                xlWB = xlApp.Workbooks.Add(Missing.Value);
                xlSheet = xlWB.ActiveSheet;

                // Tábla létrehozása
                CreateTable(); // Ennek megírása a következő feladatrészben következik

                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex) // Hibakezelés a beépített hibaüzenettel
            {
                string errMsg = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(errMsg, "Error");

                // Hiba esetén az Excel applikáció bezárása automatikusan
                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;
            }

        }

        private void CreateTable()
        {
            string[] headers = new string[] {
             "Date",
             "Product line",
             "Gender",
             "Unit Price",
             "Quantity",
             "Total",
             "City",
             "Customer type",
             "Payment"
            };

            for (int i = 1; i < headers.Length + 1; i++)
            {
                xlSheet.Cells[1, i] = headers[i - 1];
            }


            object[,] values = new object[dataGridView1.Rows.Count, headers.Length];


            int counter = 0;



            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                values[counter, 0] = dr.Cells[0].Value;
                values[counter, 1] = dr.Cells[1].Value;
                values[counter, 2] = dr.Cells[2].Value;
                values[counter, 3] = dr.Cells[3].Value;
                values[counter, 4] = dr.Cells[4].Value;
                values[counter, 5] = dr.Cells[5].Value;
                values[counter, 6] = dr.Cells[6].Value;
                values[counter, 7] = dr.Cells[7].Value;
                values[counter, 8] = dr.Cells[8].Value;
                counter++;
            }

            string GetCell(int x, int y) //private string
            {
                string ExcelCoordinate = "";
                int dividend = y;
                int modulo;

                while (dividend > 0)
                {
                    modulo = (dividend - 1) % 26;
                    ExcelCoordinate = Convert.ToChar(65 + modulo).ToString() + ExcelCoordinate;
                    dividend = (int)((dividend - modulo) / 26);
                }
                ExcelCoordinate += x.ToString();

                return ExcelCoordinate;
            }

            xlSheet.get_Range(
            GetCell(2, 1),
            GetCell(1 + values.GetLength(0), values.GetLength(1))).Value2 = values;

            //formázás
            Excel.Range headerRange = xlSheet.get_Range(GetCell(1, 1), GetCell(1, headers.Length));
            headerRange.Font.Bold = true;
            headerRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            headerRange.EntireColumn.AutoFit();
            headerRange.RowHeight = 40;
            headerRange.Interior.Color = Color.LightBlue;
            headerRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            CreateExcel();
        }

        private void ctComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdatFrissítés();
        }
    }
}
