using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class Products
    { 
        public static Array GetProductDetail()
        {
            using (var db = new NORTHWNDEntities())
            {
                var products = db.Products.Select(p => new
                {
                    p.ProductID,
                    p.ProductName,
                    Price = (float)p.UnitPrice,
                    PriceInVAT = (float)p.UnitPrice + (float)p.UnitPrice * (float)0.07
                }).ToArray();

                return products;
            }
        }

        public static float GetMaximumPrice()
        {
            using (var db = new NORTHWNDEntities())
            {
                var maxPrice = (float)db.Products.Select(p => p.UnitPrice).Max();
                return maxPrice;
            }
            
        }

        public static float getMinimumPrice()
        {
            using (var db = new NORTHWNDEntities())
            {
                var minPrice = (float)db.Products.Select(p => p.UnitPrice).Min();
                return minPrice;
            }

        }

        public static float getAveragePrice()
        {
            using (var db = new NORTHWNDEntities())
            {
                var minPrice = (float)db.Products.Select(p => p.UnitPrice).Average();
                return minPrice;
            }
        }
    }

}

