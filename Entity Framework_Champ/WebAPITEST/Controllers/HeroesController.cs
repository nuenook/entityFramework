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
    public class HeroesController : ApiController
    {
        [HttpGet]
        public IEnumerable<Hero> GetAllHeroes()
        {

            var heroes = new IHeroRepository();

            return heroes.GetALL();
        }

        [HttpGet]
        public IHttpActionResult GetHero(int id)
        {
            var heroes = new IHeroRepository();
           
            if (heroes.Get(id) == null)
            {
                return NotFound();
            }
            return Ok(heroes.Get(id));
        }

        [HttpDelete]
        public bool DeleteHero(int id)
        {
            var heroes = new IHeroRepository();
            return heroes.Delete(id);
        }

        [HttpPost]
        public bool AddHero(Hero item)
        {
            var heroes = new IHeroRepository();
            return heroes.Add(item);
        }

        
    }
}
