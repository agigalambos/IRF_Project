
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
            this.loadButton3 = new IRF_beadandó_F9bobl.LoadButton();
            this.loadButton2 = new IRF_beadandó_F9bobl.LoadButton();
            this.loadButton1 = new IRF_beadandó_F9bobl.LoadButton();
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
            this.panel1.Size = new System.Drawing.Size(1732, 1060);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            this.loadButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(147)))), ((int)(((byte)(186)))));
            this.loadButton3.Font = new System.Drawing.Font("Arial", 10F);
            this.loadButton3.Location = new System.Drawing.Point(0, 726);
            this.loadButton3.Name = "loadButton3";
            this.loadButton3.Size = new System.Drawing.Size(195, 80);
            this.loadButton3.TabIndex = 5;
            this.loadButton3.Text = "Spreadsheet";
            this.loadButton3.UseVisualStyleBackColor = false;
            this.loadButton3.Click += new System.EventHandler(this.loadButton3_Click);
            // 
            // loadButton2
            // 
            this.loadButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(147)))), ((int)(((byte)(186)))));
            this.loadButton2.Font = new System.Drawing.Font("Arial", 10F);
            this.loadButton2.Location = new System.Drawing.Point(0, 362);
            this.loadButton2.Name = "loadButton2";
            this.loadButton2.Size = new System.Drawing.Size(195, 80);
            this.loadButton2.TabIndex = 4;
            this.loadButton2.Text = "Average value of purchases";
            this.loadButton2.UseVisualStyleBackColor = false;
            this.loadButton2.Click += new System.EventHandler(this.loadButton2_Click);
            // 
            // loadButton1
            // 
            this.loadButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(147)))), ((int)(((byte)(186)))));
            this.loadButton1.Font = new System.Drawing.Font("Arial", 10F);
            this.loadButton1.Location = new System.Drawing.Point(0, 230);
            this.loadButton1.Name = "loadButton1";
            this.loadButton1.Size = new System.Drawing.Size(195, 80);
            this.loadButton1.TabIndex = 3;
            this.loadButton1.Text = "Total value of purchases";
            this.loadButton1.UseVisualStyleBackColor = false;
            this.loadButton1.Click += new System.EventHandler(this.loadButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private LoadButton loadButton3;
        private LoadButton loadButton2;
        private LoadButton loadButton1;
        public System.Windows.Forms.Panel panel2;
    }
}

