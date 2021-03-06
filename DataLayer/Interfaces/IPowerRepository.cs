﻿using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Interfaces
{
    public interface IPowerRepository : IRepository<Power>
    {
        IEnumerable<Power> GetAllWithHeros();
        Power GetWithHero(int id);
    }
}
