using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIModel;

namespace WebAPITEST.Interfaces
{
    interface IHero
    {
        IEnumerable<Hero> GetALL();
        Hero Get(int id);
        bool Add(Hero item);
        bool Delete(int id);
    }
}
