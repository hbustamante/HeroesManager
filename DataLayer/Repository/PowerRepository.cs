using DataLayer.Interfaces;
using DataLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer.Repository
{
    public class PowerRepository : Repository<Power>, IPowerRepository
    {
        public PowerRepository(HeroDbContext context) : base(context) { }
        public IEnumerable<Power> GetAllWithHeros()
        {
            return _context.Powers.Include(a => a.Heros);
        }

        public Power GetWithHero(int id)
        {
            return _context.Powers.Where(a => a.PowerId == id).Include(a => a.Heros).FirstOrDefault();
        }
    }
}
