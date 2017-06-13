using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Reflection;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework
{
    public partial class Interface : Form
    {
        
        public Interface()
        {
            InitializeComponent();
        }

        private void Interface_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Products.GetProductDetail();
            maxPrice.Text += Products.GetMaximumPrice();
            minPrice.Text += Products.getMinimumPrice();
            avrPrice.Text += Products.getAveragePrice();

            dataGridView2.DataSource = Customers.GetCustomerDetail();
            Cus_max.Text += Customers.GetMaximumTotalPrice();
            Cus_Min.Text += Customers.GetMinimumTotalPrice();
            Cus_Avg.Text += Customers.GetAverageTotalPrice();
        }

        
    }
}
