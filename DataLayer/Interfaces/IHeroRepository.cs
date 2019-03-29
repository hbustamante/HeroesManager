using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Interfaces
{
    public interface IHeroRepository: IRepository<Hero>
    {
        IEnumerable<Hero> GetAllWithPower();
        IEnumerable<Hero> FindWithPower(Func<Hero, bool> predicate);
        IEnumerable<Hero> FindWithPowerAndHouse(Func<Hero, bool> predicate);
    }
}
