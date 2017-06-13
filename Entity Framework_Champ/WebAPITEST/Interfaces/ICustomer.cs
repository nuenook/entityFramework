using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIModel;

namespace WebAPITEST.Interfaces
{
    interface ICustomer
    {
        IEnumerable<Customer> GetALL();
        Customer Get(string id);
        bool Add(Customer item);
        bool Delete(string id);
    }
}
