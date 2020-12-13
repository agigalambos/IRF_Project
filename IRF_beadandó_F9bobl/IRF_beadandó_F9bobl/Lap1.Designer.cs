
namespace IRF_beadandó_F9bobl
{
    partial class Lap1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.ctComboBox = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.paymentComboBox = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chart2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chart3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(40, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1067, 36);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "1. lap";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(40, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Gender";
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "All",
            "Male",
            "Female"});
            this.genderComboBox.Location = new System.Drawing.Point(41, 82);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(199, 24);
            this.genderComboBox.TabIndex = 2;
            this.genderComboBox.SelectedIndexChanged += new System.EventHandler(this.genderComboBox_SelectedIndexChanged);
            // 
            // ctComboBox
            // 
            this.ctComboBox.FormattingEnabled = true;
            this.ctComboBox.Items.AddRange(new object[] {
            "All",
            "Normal",
            "Member"});
            this.ctComboBox.Location = new System.Drawing.Point(261, 82);
            this.ctComboBox.Name = "ctComboBox";
            this.ctComboBox.Size = new System.Drawing.Size(199, 24);
            this.ctComboBox.TabIndex = 4;
            this.ctComboBox.SelectedIndexChanged += new System.EventHandler(this.ctComboBox_SelectedIndexChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(260, 54);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 22);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "Customer type";
            // 
            // paymentComboBox
            // 
            this.paymentComboBox.FormattingEnabled = true;
            this.paymentComboBox.Items.AddRange(new object[] {
            "All",
            "Ewallet",
            "Cash",
            "Credit card"});
            this.paymentComboBox.Location = new System.Drawing.Point(482, 82);
            this.paymentComboBox.Name = "paymentComboBox";
            this.paymentComboBox.Size = new System.Drawing.Size(199, 24);
            this.paymentComboBox.TabIndex = 6;
            this.paymentComboBox.SelectedIndexChanged += new System.EventHandler(this.paymentComboBox_SelectedIndexChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(482, 54);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(200, 22);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "Payment";
            // 
            // chart1
            // 
            chartArea10.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chart1.Legends.Add(legend10);
            this.chart1.Location = new System.Drawing.Point(17, 143);
            this.chart1.Name = "chart1";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            series10.XValueMember = "ProductLine";
            series10.YValueMembers = "Quantity";
            this.chart1.Series.Add(series10);
            this.chart1.Size = new System.Drawing.Size(517, 271);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea11.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.chart2.Legends.Add(legend11);
            this.chart2.Location = new System.Drawing.Point(657, 143);
            this.chart2.Name = "chart2";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            series11.XValueMember = "City";
            series11.YValueMembers = "Quantity";
            this.chart2.Series.Add(series11);
            this.chart2.Size = new System.Drawing.Size(520, 271);
            this.chart2.TabIndex = 8;
            this.chart2.Text = "chart2";
            // 
            // chart3
            // 
            chartArea12.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea12);
            legend12.Name = "Legend1";
            this.chart3.Legends.Add(legend12);
            this.chart3.Location = new System.Drawing.Point(-24, 443);
            this.chart3.Name = "chart3";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Legend = "Legend1";
            series12.Name = "Series1";
            series12.Points.Add(dataPoint4);
            series12.XValueMember = "Month";
            series12.YValueMembers = "Quantity";
            this.chart3.Series.Add(series12);
            this.chart3.Size = new System.Drawing.Size(1201, 369);
            this.chart3.TabIndex = 9;
            this.chart3.Text = "chart3";
            // 
            // Lap1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.paymentComboBox);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.ctComboBox);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Lap1";
            this.Size = new System.Drawing.Size(1305, 791);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.ComboBox ctComboBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox paymentComboBox;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.BindingSource chart1BindingSource;
        private System.Windows.Forms.BindingSource chart2BindingSource;
        private System.Windows.Forms.BindingSource chart3BindingSource;
    }
}
