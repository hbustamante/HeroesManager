using DataLayer.Interfaces;
using DataLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer.Repository
{
    public class HeroRepository : Repository<Hero>, IHeroRepository
    {
        public HeroRepository(HeroDbContext context) : base(context) { }
        public IEnumerable<Hero> FindWithPower(Func<Hero, bool> predicate)
        {
            return _context.Heros
                .Include(a => a.Power)
                .Where(predicate);
        }

        public IEnumerable<Hero> FindWithPowerAndHouse(Func<Hero, bool> predicate)
        {
            return _context.Heros
               .Include(a => a.Power)
               .Include(a => a.House)
               .Where(predicate);
        }

        public IEnumerable<Hero> GetAllWithPower()
        {
            return _context.Heros.Include(a => a.Power);
        }
    }
}
