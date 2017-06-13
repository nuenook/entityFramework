using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class Customers
    {
        public static Array GetCustomerDetail()
        {
            using (var db = new NORTHWNDEntities())
            {
                var customers = db.Customers.Select( c => new 
                                 {
                                     c.CustomerID,
                                     c.CompanyName,
                                     c.ContactName,
                                     TotalOrderPrice = (float?)c.Orders.Sum(o => (float)o.Order_Details.Sum(g => (float)g.Quantity * (float)g.UnitPrice))
                                 }).ToArray();

                return customers;
            }
        }

        public static float GetMaximumTotalPrice()
        {
            using (var db = new NORTHWNDEntities())
            {
                var max_total = db.Customers.Select(c => c.Orders.Sum(o => o.Order_Details.Sum(od => (float)od.Quantity * (float)od.UnitPrice))).Max();

                return max_total;
            }
        }

        public static float GetMinimumTotalPrice()
        {
            using (var db = new NORTHWNDEntities())
            {
                var min_total = db.Customers.Select(c => c.Orders.Sum(o => o.Order_Details.Sum(od => (float)od.Quantity * (float)od.UnitPrice))).Min();

                return min_total;
            }
        }

        public static float GetAverageTotalPrice()
        {
            using (var db = new NORTHWNDEntities())
            {
                var avg_total = db.Customers.Select(c => c.Orders.Sum(o => o.Order_Details.Sum(od => (float)od.Quantity * (float)od.UnitPrice))).Average();

                return avg_total;
            }
        }
    }
}
