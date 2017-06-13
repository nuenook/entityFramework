using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIModel;
using WebAPITEST.Repositories;

namespace WebAPITEST.Controllers
{
    public class CarsController : ApiController
    {
        [HttpGet]
        public IEnumerable<Car> GetAllCars()
        {

            var cars = new ICarRepository();

            return cars.GetALLCars();
        }
    }
}
