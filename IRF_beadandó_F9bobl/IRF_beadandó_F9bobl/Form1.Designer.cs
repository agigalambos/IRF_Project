
namespace IRF_beadandó_F9bobl
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.loadButton3 = new IRF_beadandó_F9bobl.Entities.LoadButton();
            this.loadButton2 = new IRF_beadandó_F9bobl.Entities.LoadButton();
            this.loadButton1 = new IRF_beadandó_F9bobl.Entities.LoadButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(193, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1700, 878);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.loadButton3);
            this.panel2.Controls.Add(this.loadButton2);
            this.panel2.Controls.Add(this.loadButton1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 1200);
            this.panel2.TabIndex = 1;
            // 
            // loadButton3
            // 
            this.loadButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(128)))), ((int)(((byte)(99)))));
            this.loadButton3.Font = new System.Drawing.Font("Arial", 10F);
            this.loadButton3.ForeColor = System.Drawing.Color.White;
            this.loadButton3.Location = new System.Drawing.Point(0, 701);
            this.loadButton3.Name = "loadButton3";
            this.loadButton3.Size = new System.Drawing.Size(195, 80);
            this.loadButton3.TabIndex = 8;
            this.loadButton3.Text = "Spreadsheet";
            this.loadButton3.UseVisualStyleBackColor = false;
            this.loadButton3.Click += new System.EventHandler(this.loadButton3_Click_1);
            // 
            // loadButton2
            // 
            this.loadButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(128)))), ((int)(((byte)(99)))));
            this.loadButton2.Font = new System.Drawing.Font("Arial", 10F);
            this.loadButton2.ForeColor = System.Drawing.Color.White;
            this.loadButton2.Location = new System.Drawing.Point(0, 277);
            this.loadButton2.Name = "loadButton2";
            this.loadButton2.Size = new System.Drawing.Size(195, 80);
            this.loadButton2.TabIndex = 7;
            this.loadButton2.Text = "Average value of purchases";
            this.loadButton2.UseVisualStyleBackColor = false;
            this.loadButton2.Click += new System.EventHandler(this.loadButton2_Click_1);
            // 
            // loadButton1
            // 
            this.loadButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(128)))), ((int)(((byte)(99)))));
            this.loadButton1.Font = new System.Drawing.Font("Arial", 10F);
            this.loadButton1.ForeColor = System.Drawing.Color.White;
            this.loadButton1.Location = new System.Drawing.Point(0, 144);
            this.loadButton1.Name = "loadButton1";
            this.loadButton1.Size = new System.Drawing.Size(195, 80);
            this.loadButton1.TabIndex = 6;
            this.loadButton1.Text = "Total value of purchases";
            this.loadButton1.UseVisualStyleBackColor = false;
            this.loadButton1.Click += new System.EventHandler(this.loadButton1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1900, 878);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1918, 925);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1918, 925);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel panel2;
        private Entities.LoadButton loadButton3;
        private Entities.LoadButton loadButton2;
        private Entities.LoadButton loadButton1;
        public System.Windows.Forms.Panel panel1;
    }
}

