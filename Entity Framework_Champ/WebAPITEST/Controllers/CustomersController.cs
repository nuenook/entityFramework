using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebAPIModel;
using WebAPITEST.Repositories;

namespace WebAPITEST.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CustomersController : ApiController
    {
        [HttpGet]
        public IEnumerable<Customer> GetAllCustomers()
        {

            var customers = new ICustomerRepository();

            return customers.GetALL();
        }

        [HttpGet]
        public IHttpActionResult GetCustomer(string id)
        {
            var customer = new ICustomerRepository();
            if (customer.Get(id) == null)
            {
                return NotFound();
            }
            return Ok(customer.Get(id));
        }

       
    }
}
