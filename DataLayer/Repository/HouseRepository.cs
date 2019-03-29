using DataLayer.Interfaces;
using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repository
{
    public class HouseRepository: Repository<House>, IHouseRepository
    {
        public HouseRepository(HeroDbContext context) : base(context) { }
    }
}
