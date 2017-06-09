using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityHW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table = GetTable_metadata(table);

            DataTable table2 = new DataTable();
            table2 = GetTable_metadata2(table2);

            max.Text = min.Text = avg.Text = "0.00";
            Max2.Text = Min2.Text = Avg2.Text = Sum2.Text = "0.00";

            dataGrid1.DataSource = table;
            dataGrid2.DataSource = table2;
        }
        private DataTable GetTable_metadata2(DataTable table)
        {
            table.Columns.Add("Customer ID");
            table.Columns.Add("Company Name");
            table.Columns.Add("Contact Name");
            table.Columns.Add("Total Order Price");
            return table;
        }
        private DataTable GetTable_metadata(DataTable table)
        {
            table.Columns.Add("ProductCode");
            table.Columns.Add("ProductName");
            table.Columns.Add("Price");
            table.Columns.Add("Price include VAT");
            return table;
        }
        private void Getdata_1v2(string search)
        {
            DataTable table = new DataTable();
            table = GetTable_metadata(table);
            float _max, _min, _avg;
            _max = _min = _avg = 0;
            int[] index = new int[2];
            for (int i = 0; i < 2; i++) index[i] = -1;
            using (var db = new NORTHWNDEntities())
            {

                var test = db.Products.Select(c => new
                {
                    ProductCode = c.ProductID,
                    ProductName = c.ProductName,
                    Price = (float)c.UnitPrice,
                    PriceIncludeVAT = ((float?)c.UnitPrice * 1.07)
                });
                if (!String.IsNullOrEmpty(search))
                {
                    test = test.Where(t => t.ProductName.Contains(search) || t.ProductCode.ToString().Equals(search));
                }
                if (test.ToList().Count() != 0)
                {
                    _max = test.Select(c => (float?)c.Price).Max(a => a.Value);
                    _min = test.Select(c => (float?)c.Price).Min(a => a.Value);
                    _avg = test.Select(c => (float?)c.Price).Average(a => a.Value);

                    int count = 0;
                    foreach (var p in test)
                    {
                        DataRow dr = table.NewRow();
                        dr["ProductCode"] = p.ProductCode;
                        dr["ProductName"] = p.ProductName;
                        dr["Price"] = p.Price;
                        dr["Price include VAT"] = p.PriceIncludeVAT;
                        table.Rows.Add(dr);
                        if (p.Price == _max) index[0] = count;
                        if (p.Price == _min) index[1] = count;
                        count++;
                    }
                }
                else
                {
                    DataRow dr = table.NewRow();
                    dr["ProductCode"] = "Data not found.";
                    table.Rows.Add(dr);
                }
            }
            max.Text = SetFormat(_max);
            min.Text = SetFormat(_min);
            avg.Text = SetFormat(_avg);
            dataGrid1.DataSource = table;
            setGridColour(dataGrid1, index);
        }
        private void GetData_2(string search)
        {
            DataTable table = new DataTable();
            table = GetTable_metadata2(table);
            float _max, _min, _avg, _sum;
            _max = _min = _avg = _sum = 0;
            int[] index = new int[2];
            for (int i = 0; i < 2; i++) index[i] = -1;

            using (var db = new NORTHWNDEntities())
            {
                var test = db.Customers.Select(c => new
                {
                    c.CustomerID,
                    c.CompanyName,
                    c.ContactName,
                    ToTalOrderPrice = (float?)c.Orders.Sum(a => a.Order_Details.Sum(t => t.Quantity * t.UnitPrice))
                });
                if (!String.IsNullOrEmpty(search))
                {
                    test = test.Where(t => t.CustomerID.Contains(search) || t.CompanyName.Contains(search));
                }
                if (test.ToList().Count() != 0)
                {
                    _max = test.Select(c => c.ToTalOrderPrice).Max(a => a.Value);
                    _min = test.Select(c => c.ToTalOrderPrice).Min(a => a.Value);
                    _avg = test.Select(c => c.ToTalOrderPrice).Average(a => a.Value);
                    _sum = test.Select(c => c.ToTalOrderPrice).Sum(a => a.Value);


                    int count = 0;
                    foreach (var p in test)
                    {
                        DataRow dr = table.NewRow();
                        dr["Customer ID"] = p.CustomerID;
                        dr["Company Name"] = p.CompanyName;
                        dr["Contact Name"] = p.ContactName;
                        dr["Total Order Price"] = p.ToTalOrderPrice;
                        if (p.ToTalOrderPrice == _max) index[0] = count;
                        else if (p.ToTalOrderPrice == _min) index[1] = count;
                        table.Rows.Add(dr);
                        count++;
                    }
                }
                else
                {
                    DataRow dr = table.NewRow();
                    dr["Customer ID"] = "Data not found.";
                    table.Rows.Add(dr);
                }

            }
            Max2.Text = SetFormat(_max);
            Min2.Text = SetFormat(_min);
            Avg2.Text = SetFormat(_avg);
            Sum2.Text = SetFormat(_sum);
            dataGrid2.DataSource = table;
            setGridColour(dataGrid2, index);
        }
        private string SetFormat(float n)
        {
            return String.Format("{0:n}", n);
        }
        private void setGridColour(DataGridView a, int[] index)
        {
            if (index[0] != -1)
            {
                a.Rows[index[0]].DefaultCellStyle.BackColor = setMaxColour();
            }
            if (index[1] != -1)
            {
                a.Rows[index[1]].DefaultCellStyle.BackColor = setMinColour();
            }
        }
        private Color setMaxColour()
        { return Color.PowderBlue; }
        private Color setMinColour()
        { return Color.Pink; }
        private void search_but1_Click(object sender, EventArgs e)
        {
            string search = null;
            search = search_box1.Text;
            Getdata_1v2(search);
        }
        private void search_but2_Click(object sender, EventArgs e)
        {
            string search = null;
            search = search_box2.Text;
            GetData_2(search);
        }
        private void Show_1_Click(object sender, EventArgs e)
        {
            Getdata_1v2(null);
        }
        private void show_2_Click(object sender, EventArgs e)
        {
            GetData_2(null);
        }
    }
}
