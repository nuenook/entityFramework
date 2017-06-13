using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPIModel;
using WebAPITEST.Interfaces;

namespace WebAPITEST.Repositories
{
    public class ICustomerRepository : ICustomer
    {
        NORTHWNDEntities1 db = new NORTHWNDEntities1();

        public bool Add(Customer item)
        {
            if (item == null) return false;

            db.Customers.Add(item);
            db.SaveChanges();

            return true;
        }

        public bool Delete(string id)
        {
            if (id == null) return false;

            //Customer cus = (Customer)db.Customers.Where(c => c.CustomerID == id);

            return true;
        }

        public Customer Get(string id)
        {
            //Customer cus = db.Customers.FirstOrDefault(c => c.CustomerID == id);
            var cus = new Customer();
            return cus;

        }

        public IEnumerable<Customer> GetALL()
        {
            return db.Customers;
        }
    }
}