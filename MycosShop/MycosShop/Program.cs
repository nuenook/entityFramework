using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MycosShop
{
    class Program
    {
        static void Main(string[] args)
        {
            getsCustomer();
            getCustomer();
            getCustomers();
            addCustomer();
            updateCustomer();
            deleteCustomer();
            getShop();
        }

       public static void getCustomer()
        {
            
            using (var db = new NORTHWNDEntities())
            {
                var customers = db.Customers.First();            
            }
            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name.ToString());

        }

        public static void addCustomer()
        {

            using (var db = new NORTHWNDEntities())
            {
                Customer cus = new Customer{Address="suThep", CompanyName="No", City ="ChiangMai", ContactName="ChiangMai", ContactTitle="Title", Country="ChiangMai", CustomerID="1111", Fax="053", Phone="222", PostalCode="111", Region="000" };
                db.Customers.Add(cus);
                db.SaveChanges();
            }
            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name.ToString());

        }
        public static void updateCustomer()
        {

            using (var db = new NORTHWNDEntities())
            {
                var cus = db.Customers.Where(c => c.CustomerID == "1111").FirstOrDefault();
                if(cus != null)
                {
                    cus.Fax = "093-236";
                    cus.Phone = "0932635";
                    db.SaveChanges();
                }
                
            }
            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name.ToString());

        }

        public static void deleteCustomer()
        {

            using (var db = new NORTHWNDEntities())
            {
                var cus = db.Customers.Where(c => c.CustomerID == "1111").FirstOrDefault();
                if (cus != null)
                {
                    db.Customers.Remove(cus);
                    db.SaveChanges();
                }

            }
            Console.WriteLine(System.Reflection.MethodBase.GetCurrentMethod().Name.ToString());

        }
        public static void getCustomers()
        {
            using (var dbs = new NORTHWNDEntities())
            {
                
                 var test = dbs.Customers.Select(c => new { c.CustomerID,
                    c.CompanyName,
                    c.ContactName
                    ,TotalOrderPrice = (float?)c.Orders.Sum(o => (float)o.Order_Details.Sum(g => (float)g.Quantity * (float)g.UnitPrice))

                }).ToList();

                foreach (var eiei in test)
                {
                    Console.WriteLine(eiei.CustomerID +" \t"+ eiei.CompanyName + " \t" + eiei.ContactName + " \t" + eiei.TotalOrderPrice);
                }
            }         
        }

        public static void getsCustomer()
        {
            IEnumerable<Customer> cus = new List<Customer>();
            using ( var db = new NORTHWNDEntities())
            {
                var curs = from Customer in db.Customers select Customer;
                cus = curs.ToList();

            }

        }

        public static void getShop()
        {
            using (var db = new NORTHWNDEntities())
            {
                var test = db.Products.Select(p => new
                {
                    ProductCode = p.ProductID.ToString(),
                    ProductName = p.ProductName,
                    Price = (float)p.UnitPrice,
                    PriceVAT = (float)((float)p.UnitPrice + (float)p.UnitPrice * 0.07)

                }).ToList();
            }
        }
    }
}
