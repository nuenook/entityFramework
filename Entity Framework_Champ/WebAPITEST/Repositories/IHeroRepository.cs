using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPIModel;
using WebAPITEST.Interfaces;

namespace WebAPITEST.Repositories
{
    public class IHeroRepository : IHero

    {
        MyHeroesEntities db = new MyHeroesEntities();

        public bool Add(Hero item)
        {
            db.Heroes.Add(item);
            db.SaveChanges();
            Hero hero = db.Heroes.FirstOrDefault(h => h.id == item.id);
            if (hero != null)
            {
                return true;
            }
            return false;

        }
        public bool Update(Hero item)
        {
            db.Heroes.Add(item);
            db.SaveChanges();
            Hero hero = db.Heroes.FirstOrDefault(h => h.id == item.id);
            if (hero != null)
            {
                return true;
            }
            return false;

        }

        public bool Delete(int id)
        {
            Hero hero = db.Heroes.FirstOrDefault(h => h.id == id);
            if (hero != null)
            {
                db.Heroes.Remove(hero);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public Hero Get(int id)
        {
            Hero hero = db.Heroes.FirstOrDefault(h => h.id == id);
            return hero;
        }

        public IEnumerable<Hero> GetALL()
        {
            return db.Heroes;
        }
    }
}