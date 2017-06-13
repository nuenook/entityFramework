using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIModel;

namespace WebAPITEST.Interfaces
{
    interface ICar
    {
        IEnumerable<Car> GetALLCars();
    }
}
