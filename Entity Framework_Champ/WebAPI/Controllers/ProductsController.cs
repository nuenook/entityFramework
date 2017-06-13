using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Repositories;
using WebAPIModel;

namespace WebAPI.Controllers
{
    public class ProductsController : ApiController
    {
        IProductRepositories repository = new IProductRepositories();
        [HttpGet]
        public IEnumerable<Product> GetAllProducts()
        {
            return repository.GetAll();
            //  return products;
        }
        [HttpGet]
        public IHttpActionResult GetProduct(int id)
        {
            var product = repository.Get(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
        [HttpPost]
        public Product PostProduct(Product item)
        {
            return repository.Add(item);
        }

        [HttpPut]
        public IEnumerable PutProduct(int id, Product product)
        {
            //product.Id = id;
            if (repository.Update(product))
            {
                return repository.GetAll();
            }
            else
            {
                return null;
            }
        }
        [HttpDelete]
        public bool DeleteProduct(int id)
        {
            if (repository.Delete(id))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
