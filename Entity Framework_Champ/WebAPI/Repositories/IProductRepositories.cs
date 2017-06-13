using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Interface;
using WebAPIModel;

namespace WebAPI.Repositories
{
    public class IProductRepositories : IProduct
    {
        TestDBEntities db = new TestDBEntities();

        public IEnumerable<Product> GetAll()
        {
            // TO DO : Code to get the list of all the records in database
            
            return db.Products;
        }

        public Product Get(int id)
        {
            // TO DO : Code to find a record in database
            return db.Products.Find(id);
        }

        public Product Add(Product item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            // TO DO : Code to save record into database
            db.Products.Add(item);
            db.SaveChanges();
            return item;
        }

        public bool Update(Product item)
        {
            

            return true;
        }

        public bool Delete(int id)
        {
            // TO DO : Code to remove the records from database
            Product Productss = db.Products.Find(id);
            db.Products.Remove(Productss);
            db.SaveChanges();
            return true;
        }
    }
}