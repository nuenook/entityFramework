using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPIModel;
using WebAPITEST.Interfaces;

namespace WebAPITEST.Repositories
{
    public class ICarRepository : ICar
    {
        traineeEntities db = new traineeEntities();
        public IEnumerable<Car> GetALLCars()
        {
            return db.Cars;
        }
    }
}