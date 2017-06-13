namespace EntityFramework
{
    partial class Interface
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CustomersTap = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.maxPrice = new System.Windows.Forms.Label();
            this.minPrice = new System.Windows.Forms.Label();
            this.avrPrice = new System.Windows.Forms.Label();
            this.Cus_Avg = new System.Windows.Forms.Label();
            this.Cus_Min = new System.Windows.Forms.Label();
            this.Cus_max = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.CustomersTap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(486, 455);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.CustomersTap);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(716, 481);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.avrPrice);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.minPrice);
            this.tabPage1.Controls.Add(this.maxPrice);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(708, 455);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Products";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CustomersTap
            // 
            this.CustomersTap.Controls.Add(this.Cus_Avg);
            this.CustomersTap.Controls.Add(this.Cus_Min);
            this.CustomersTap.Controls.Add(this.Cus_max);
            this.CustomersTap.Controls.Add(this.dataGridView2);
            this.CustomersTap.Location = new System.Drawing.Point(4, 22);
            this.CustomersTap.Name = "CustomersTap";
            this.CustomersTap.Padding = new System.Windows.Forms.Padding(3);
            this.CustomersTap.Size = new System.Drawing.Size(708, 455);
            this.CustomersTap.TabIndex = 1;
            this.CustomersTap.Text = "Customers";
            this.CustomersTap.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(486, 455);
            this.dataGridView2.TabIndex = 0;
            // 
            // maxPrice
            // 
            this.maxPrice.AutoSize = true;
            this.maxPrice.Location = new System.Drawing.Point(513, 26);
            this.maxPrice.Name = "maxPrice";
            this.maxPrice.Size = new System.Drawing.Size(109, 13);
            this.maxPrice.TabIndex = 2;
            this.maxPrice.Text = "The Maximum Price : ";
            // 
            // minPrice
            // 
            this.minPrice.AutoSize = true;
            this.minPrice.Location = new System.Drawing.Point(513, 118);
            this.minPrice.Name = "minPrice";
            this.minPrice.Size = new System.Drawing.Size(106, 13);
            this.minPrice.TabIndex = 3;
            this.minPrice.Text = "The Minimum Price : ";
            // 
            // avrPrice
            // 
            this.avrPrice.AutoSize = true;
            this.avrPrice.Location = new System.Drawing.Point(513, 219);
            this.avrPrice.Name = "avrPrice";
            this.avrPrice.Size = new System.Drawing.Size(105, 13);
            this.avrPrice.TabIndex = 4;
            this.avrPrice.Text = "The Average Price : ";
            // 
            // Cus_Avg
            // 
            this.Cus_Avg.AutoSize = true;
            this.Cus_Avg.Location = new System.Drawing.Point(515, 259);
            this.Cus_Avg.Name = "Cus_Avg";
            this.Cus_Avg.Size = new System.Drawing.Size(105, 13);
            this.Cus_Avg.TabIndex = 7;
            this.Cus_Avg.Text = "The Average Price : ";
            // 
            // Cus_Min
            // 
            this.Cus_Min.AutoSize = true;
            this.Cus_Min.Location = new System.Drawing.Point(515, 158);
            this.Cus_Min.Name = "Cus_Min";
            this.Cus_Min.Size = new System.Drawing.Size(106, 13);
            this.Cus_Min.TabIndex = 6;
            this.Cus_Min.Text = "The Minimum Price : ";
            // 
            // Cus_max
            // 
            this.Cus_max.AutoSize = true;
            this.Cus_max.Location = new System.Drawing.Point(515, 66);
            this.Cus_max.Name = "Cus_max";
            this.Cus_max.Size = new System.Drawing.Size(109, 13);
            this.Cus_max.TabIndex = 5;
            this.Cus_max.Text = "The Maximum Price : ";
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 502);
            this.Controls.Add(this.tabControl1);
            this.Name = "Interface";
            this.Text = "Interface";
            this.Load += new System.EventHandler(this.Interface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.CustomersTap.ResumeLayout(false);
            this.CustomersTap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage CustomersTap;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label maxPrice;
        private System.Windows.Forms.Label minPrice;
        private System.Windows.Forms.Label avrPrice;
        private System.Windows.Forms.Label Cus_Avg;
        private System.Windows.Forms.Label Cus_Min;
        private System.Windows.Forms.Label Cus_max;
    }
}