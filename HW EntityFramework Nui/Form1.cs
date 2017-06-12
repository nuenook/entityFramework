using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace HW_EntityFramework_Nui
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            //   Customers cust = new Customers();
            setTable();
            getProducts();
            getCustomers();
        }

        public void getCustomers()
        {
            using (var dbs = new NORTHWNDEntities())
            {
                //var cust2 = dbs.Customers.Select(p => new
                //{
                //    p.CustomerID,
                //    p.CompanyName,
                //    p.ContactName,
                //    TotalOrderPrice = p.Orders.Select(o => o.Order_Details.Select(od => od.UnitPrice))
                //}).ToList();
                //dataGridView3.DataSource = cust2;
                //MessageBox.Show("123");

                var cust = dbs.Customers.Select(p => new
                {
                    p.CustomerID,
                    p.CompanyName,
                    p.ContactName,
                    TotalOrderPrice = (float?)p.Orders.Sum(o => o.Order_Details.Sum(od => od.UnitPrice * od.Quantity))
                }).ToList();
                dataGridView3.DataSource = cust;
                DataTable dt = new DataTable();
                dt = ToDataTable(cust);
                dataGridView3.DataSource = dt;

                DataTable dt2 = new DataTable();
                dt2.Columns.Add("The Max is ");
                dt2.Columns.Add("The Min is ");
                dt2.Columns.Add("The Average is ");
                dt2.Columns.Add("Summary is ");
                
                string mx = dbs.Customers.Max(p => 
                    (float?)p.Orders.Sum(o => o.Order_Details.Sum(od => od.UnitPrice * od.Quantity))
                ).ToString();
                string mn = dbs.Customers.Min(p => 
                (float?)p.Orders.Sum(o => o.Order_Details.Sum(od => od.UnitPrice * od.Quantity))
                ).ToString();

                string avg = dbs.Customers.Average(p => 
                    (double?)p.Orders.Sum(o => o.Order_Details.Sum(od => od.UnitPrice * od.Quantity))
                ).ToString();
                
                string sm = dbs.Customers.Sum(p => 
                   p.Orders.Sum(o => o.Order_Details.Sum(od => od.UnitPrice * od.Quantity))
                ).ToString();

                DataRow dr = dt2.NewRow();
                dr["The Max is "] = mx;
                dr["The Min is "] = mn;
                dr["The Average is "] = avg;
                dr["Summary is "] = sm;

                dt2.Rows.Add(dr);
                dataGridView4.DataSource = dt2;

            }
        
        }


        public void getProducts()
        {
            using (var dbs = new NORTHWNDEntities())
            {
                var pd = dbs.Products.Select(p => new
                {
                    ProductCode = p.ProductID,
                    p.ProductName,
                    Price = p.UnitPrice,
                    PriceIncludeVat = ((float)p.UnitPrice * (float)1.07)
                }).ToList();

                DataTable dt = new DataTable();
                dt = ToDataTable(pd);
                dataGridView1.DataSource = dt;

                DataTable dt2 = new DataTable();
                dt2.Columns.Add("The Max Price");
                dt2.Columns.Add("The Min Price");
                dt2.Columns.Add("The Average Price");

                string mx = dbs.Products.Max(p => p.UnitPrice).ToString();
                string mn = dbs.Products.Min(p => p.UnitPrice).ToString();
                string avg = dbs.Products.Average(p => p.UnitPrice).ToString();

                DataRow dr = dt2.NewRow();
                dr["The Max Price"] = mx;
                dr["The Min Price"] = mn;
                dr["The Average Price"] = avg;

                dt2.Rows.Add(dr);

                dataGridView2.DataSource = dt2;


            }

        }

        public static DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Defining type of data column gives proper data table 
                var type = (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) ? Nullable.GetUnderlyingType(prop.PropertyType) : prop.PropertyType);
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name, type);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }

        public void setTable()
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
